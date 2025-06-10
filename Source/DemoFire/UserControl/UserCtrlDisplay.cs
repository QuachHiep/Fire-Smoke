using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using DemoFire;
using DemoFire.Class;
using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using Newtonsoft.Json;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using PreviewDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace DKVN
{
    public partial class UserCtrlDisplay : UserControl
    {
        #region Varibale
        private int m_indexView;
        private int m_countView;
        private int m_iIndexControl;
        private DateTime _timeWarning;
        private VideoCaptureUser capture;
        private bool m_bInitSDK;
        private string camera_Name = "";
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private string str;
        public bool _Disposed = false;
        public bool _Warning = false;
        private bool m_bRecord = false;

        private bool bSpreadOut = false;
        string rtspUrl = "";
        private static List<BoundingBox> previousBoundingBox = null;
        HttpClient client = new HttpClient();
        TwilioSMSExample twilio = new TwilioSMSExample();

        private Form1 main;

        private Status _Status = new Status();
        private Thread m_Thread_Warning;
        Dictionary<int, Task> videoThreads = new Dictionary<int, Task>();
        Dictionary<int, CancellationTokenSource> cancellationTokens = new Dictionary<int, CancellationTokenSource>();

        ThreadMonitor monitor = new ThreadMonitor();

        MySqlConnection connection = null;

        #endregion

        public UserCtrlDisplay(int indexCtrl, string controlName, Form1 obj, int indexView, int countView)
        {
            InitializeComponent();

            m_countView = countView;
            m_iIndexControl = indexCtrl;
            m_indexView = indexView-1;
            lbNameControl.Text = controlName;
            camera_Name = controlName.Trim();
            lbIndexControl.Text = (indexCtrl >= 0) ? ((indexCtrl + 1).ToString()) : "";
            lbIndexControl.ForeColor = (Color.DodgerBlue);
            main = obj;
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }
        }
        private void UserCtrlDisplay_Load(object sender, EventArgs e)
        {
            //monitor.StartMonitoring(5000); // Ghi thông tin luồng mỗi 2 giây
            connection = new MySqlConnection(ClassSystemConfig.Ins.m_ClsCommon.connectionString);
        }

        #region Proccess OLD
        private void DrawGraphicOLD(string name, double x1, double y1, double x2, double y2, double score, CogColorConstants color)
        {
            //Resize region detect color
            CogRectangleAffine rec = new CogRectangleAffine();
            rec.SetOriginLengthsRotationSkew(x1, y1, Math.Abs(x2-x1), Math.Abs(y2 -y1), 0, 0);
            rec.Color = color;
            rec.LineWidthInScreenPixels = 2;
            cogDisplay1.StaticGraphics.Add(rec, "rect");

            CogGraphicLabel label = new CogGraphicLabel();
            label.Alignment = CogGraphicLabelAlignmentConstants.BottomLeft;
            label.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            label.Color = CogColorConstants.White;
            label.BackgroundColor = color;
            label.SetXYText(x1, y1, name.ToUpper()+": " + score.ToString("F2"));
            cogDisplay1.StaticGraphics.Add(label, "label");
        }
        private void GraphicLabel(double x1, double y1, string text)
        {
            CogGraphicLabel label = new CogGraphicLabel();
            label.Alignment = CogGraphicLabelAlignmentConstants.TopLeft;
            label.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            label.Color = CogColorConstants.White;
            label.BackgroundColor = CogColorConstants.Red;
            label.SetXYText(x1, y1, text);
            cogDisplay1.StaticGraphics.Add(label, "label");
        }
        public async Task<string> Predict(int frameIndex, byte[] frameBytes)
        {
            var content = new MultipartFormDataContent();

            #region Image
            // Thêm ảnh vào yêu cầu với key là "file"
            content.Add(new ByteArrayContent(frameBytes), "file", $"frame_{frameIndex}.jpg");
            #endregion
            DateTime _time1 = DateTime.Now;
            // Gửi yêu cầu POST tới API Flask
            var response = await client.PostAsync(ClassSystemConfig.Ins.m_ClsCommon.url_Server, content);
            double total_time = (DateTime.Now - _time1).TotalMilliseconds;
            Console.WriteLine("Time detect: " + total_time.ToString("F2"));
            if (response.IsSuccessStatusCode)
            {
                // Đọc response body dưới dạng chuỗi JSON
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize JSON thành danh sách các phát hiện
                var result = JsonConvert.DeserializeObject<List<Detection>>(responseBody);

                if (result != null)
                {
                    foreach (var detection in result)
                    {
                        Console.WriteLine($"{detection.label}: ({detection.x1}, {detection.y1}) - ({detection.x2}, {detection.y2}), Score: {detection.score}");
                    }
                }

                return responseBody;
            }
            else
            {
                return ("Error: " + response.StatusCode);
            }
        }
        
        public async Task<string> Predict_b64(int frameIndex, string base64Image)
        {
            #region Image
            // Thêm ảnh vào yêu cầu với key là "file"
            var jsonContent = new StringContent(
            $"{{\"image\": \"{base64Image}\"}}",
            Encoding.UTF8,
            "application/json");
            #endregion

            // Đóng kết nối khi xong
            var response = await client.PostAsync(ClassSystemConfig.Ins.m_ClsCommon.url_Server, jsonContent);
            // Kiểm tra kết quả
            if (response.IsSuccessStatusCode)
            {
                // Đọc response body dưới dạng chuỗi JSON
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize JSON thành danh sách các phát hiện
                var result = JsonConvert.DeserializeObject<List<Detection>>(responseBody);

                if (result != null)
                {
                    foreach (var detection in result)
                    {
                        Console.WriteLine($"{detection.label}: ({detection.x1}, {detection.y1}) - ({detection.x2}, {detection.y2}), Score: {detection.score}");
                    }
                }

                return responseBody;
            }
            else
            {
                return ("Error: " + response.StatusCode);
            }
        }
        public void DrawGraphic(string name, double x1, double y1, double x2, double y2, double score, int width, int height)
        {
            CogColorConstants color;
            if (name == "SMOKE")
                color = CogColorConstants.Cyan;
            else
                color = CogColorConstants.Red;

            int originalWidth = width, originalHeight = height;
            int resizeWidth = 640, resizeHeight = 640;

            int x1Original = (int)(x1 * originalWidth / (float)resizeWidth);
            int y1Original = (int)(y1 * originalHeight / (float)resizeHeight);
            int x2Original = (int)(x2 * originalWidth / (float)resizeWidth);
            int y2Original = (int)(y2 * originalHeight / (float)resizeHeight);

            double w = Math.Abs(x2Original - x1Original);
            double h = Math.Abs(y2Original - y1Original);

            //Resize region detect color
            CogRectangleAffine rec = new CogRectangleAffine();
            rec.SetOriginLengthsRotationSkew(x1Original, y1Original, w, h, 0, 0);
            rec.Color = color;
            rec.LineWidthInScreenPixels = 2;
            cogDisplay1.StaticGraphics.Add(rec, "rect");
            Console.WriteLine("Width : " + w.ToString("F2") + " Height: " + h.ToString("F2"));

            CogGraphicLabel label = new CogGraphicLabel();
            label.Alignment = CogGraphicLabelAlignmentConstants.BottomLeft;
            label.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            label.Color = CogColorConstants.White;
            label.BackgroundColor = color;
            label.SetXYText(x1Original, y1Original, name.ToUpper() + ": " + score.ToString("F2"));
            cogDisplay1.StaticGraphics.Add(label, "label");
        }

        public async void Read_Video(string video_path)
        {
            var capture = new VideoCapture(video_path);

            if (!capture.IsOpened())
            {
                Console.WriteLine("Cannot open the video file.");
                return;
            }
            int frameIndex = 0;
            previousBoundingBox = new List<BoundingBox>();
            Mat frame = new Mat();
            Mat frame_resize = new Mat();
            while (true)
            {
                try
                {
                    cogDisplay1.StaticGraphics.Clear();
                    bool succes = capture.Read(frame);
                    if (!succes || frame.Empty())
                    {
                        Console.WriteLine("Lỗi: Không thể đọc frame hoặc hết video.");
                        break;
                    }
                    int width = frame.Width;
                    int height = frame.Height;

                    #region process
                    if (frameIndex % 5 != 0)
                    {
                        //if (frameIndex % 8 != 0)
                        //    goto END;
                        //else
                        //{
                        //    if (previousBoundingBox != null && previousBoundingBox.Count > 0)
                        //    {
                        //        foreach (var boundingBox in previousBoundingBox)
                        //        {
                        //            string label = boundingBox.Label;
                        //            double x1 = boundingBox.X1;
                        //            double y1 = boundingBox.Y1;
                        //            double x2 = boundingBox.X2;
                        //            double y2 = boundingBox.Y2;
                        //            double score = boundingBox.Score;
                        //            // Draw graphic or process bounding box data
                        //            DrawGraphic(label, x1, y1, x2, y2, score, width, height);
                        //        }
                        //    }
                        //    goto END;
                        //}
                        goto END;
                    }
                    else
                    {
                        Cv2.Resize(frame, frame_resize, new OpenCvSharp.Size(640, 640));
                        string image_str = ClassSystemConfig.Ins.m_ClsFunc.ImageToBase64(frame_resize);
                        int length = image_str.Length;
                        DateTime _time1 = DateTime.Now;
                        string predictionResult = await Predict_b64(frameIndex, image_str);
                        double total_time = (DateTime.Now - _time1).TotalMilliseconds;
                        Console.WriteLine("Time detect: " + total_time.ToString("F2"));

                        if (predictionResult.Contains("Error"))
                            goto END;

                        var result = JsonConvert.DeserializeObject<List<Detection>>(predictionResult);
                        if (result == null)
                            return;
                        if (result.Count == 0)
                        {
                            _Warning = false;
                            goto END;
                        }
                        //else
                        //{
                        //    if (previousBoundingBox != null)
                        //        previousBoundingBox.Clear();
                        //}
                        foreach (var detection in result)
                        {
                            string label = detection.label;
                            double x1 = Convert.ToDouble(detection.x1);
                            double y1 = Convert.ToDouble(detection.y1);
                            double x2 = Convert.ToDouble(detection.x2);
                            double y2 = Convert.ToDouble(detection.y2);
                            double score = Convert.ToDouble(detection.score);

                            DrawGraphic(label, x1, y1, x2, y2, score, width, height);
                            Bitmap img_Graphic = GetImageGraphic();
                            BoundingBox newBoundingBox = new BoundingBox(label, x1, y1, x2, y2, score);
                            //previousBoundingBox.Add(newBoundingBox);
                            string image_graphic_path = "";
                            ClassSystemConfig.Ins.m_ClsFunc.SaveImageRaw("frame_" + frameIndex.ToString(), frame, img_Graphic, ref image_graphic_path);
                            AddCameraLogData(camera_Name, label, image_graphic_path);
                            main.UpdateCameraLogInvoke(this);
                            _Warning = true;
                            _timeWarning = DateTime.Now;
                        }
                    }

                #endregion

                END:
                    UI_Screen(frame.ToBitmap());
                    frameIndex++;
                    Thread.Sleep(5);
                    // Thoát khi nhấn phím ESC
                    int key = Cv2.WaitKey(10);
                    if (_Disposed == true)
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            capture.Release();
            capture.Dispose();
        }
        public void Stop()
        {
            _Disposed = true;

            if (m_Thread_Warning != null)
            {
                m_Thread_Warning.Abort();
            }
        }
        public Bitmap GetImageGraphic()
        {
            Bitmap image = null;
            if (cogDisplay1.InvokeRequired)
            {
                cogDisplay1.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        image = (Bitmap)cogDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image);
                    }
                    catch
                    {

                    }
                }));
            }
            else
            {
                try
                {
                    image = (Bitmap)cogDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image);
                }
                catch
                {

                }
            }
            return image;
        }
        public Bitmap GetImageBitmap()
        {
            Bitmap image = null;
            if (cogDisplay1.InvokeRequired)
            {
                cogDisplay1.Invoke(new MethodInvoker(delegate
                {
                    GetImageBitmap();
                }));
            }
            else
            {
                image = (cogDisplay1.Image.ToBitmap());
            }
            return image;
        }

        #endregion

        #region Capture Screen and Get Graphic
        public static Bitmap takeComponentScreenShot(Control control)
        {
            // find absolute position of the control in the screen.
            Rectangle rect = control.RectangleToScreen(control.Bounds);

            Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }
        public static Bitmap takeComponentScreenShot2(Control control)
        {
            // find absolute position of the control in the screen.
            Control ctrl = control;
            Rectangle rect = new Rectangle(System.Drawing.Point.Empty, ctrl.Size);
            do
            {
                rect.Offset(ctrl.Location);
                ctrl = ctrl.Parent;
            }
            while (ctrl != null);

            Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);

            return bmp;
        }
        private Bitmap Merge2Images(Bitmap img1, Bitmap img2)
        {
            Bitmap imageMerge = null;
            try
            {
                int width = 0;
                int height = 0;
                Bitmap img3;
                Graphics g;

                width = img1.Width + img2.Width;
                height = Math.Max(img1.Height, img2.Height);

                img3 = new Bitmap(width, height);
                g = Graphics.FromImage(img3);

                g.Clear(Color.Black);
                g.DrawImage(img1, new System.Drawing.Point(0, 0));
                g.DrawImage(img2, new System.Drawing.Point(img1.Width, 0));
                g.Dispose();

                imageMerge = new Bitmap(img3);
            }
            catch
            {

            }
            return imageMerge;
        }
        private Bitmap CaptureScreenControl(Control control)
        {
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(control.ClientRectangle.Width,
                                    control.ClientRectangle.Height);
                control.DrawToBitmap(bmp, control.ClientRectangle);
            }
            catch (ArgumentException ex)
            {

            }

            return bmp;
        }
        #endregion

        #region Function
        public static byte[] ConvertMatToByteArray(Mat mat)
        {
            //return mat.ToBytes(".jpg");
            using (var ms = new MemoryStream())
            {
                Cv2.ImEncode(".jpg", mat, out var encodedImage); // Có thể thay đổi thành ".png" nếu bạn muốn dùng PNG
                return encodedImage.ToArray();  // Trả về mảng byte
            }
        }
        private List<double> GetListDoubleFromShortArray(short[] shArray, ref List<Int32> iListRet)
        {
            List<double> dlistRet = new List<double>();
            if (shArray != null && shArray.Length > 0)
            {
                for (int iIndex = 0; iIndex < shArray.Length - 1;)
                {
                    Int32 value = (((Int32)shArray[iIndex + 1] & 0xFFFF) << 16) | ((Int32)shArray[iIndex] & 0xFFFF);
                    int iFraction = (value) & 0x7FFFFF;
                    int iExponent = (value >> 23) & 0xFF;
                    int iSign = (value >> 31) & 1;

                    double temp = 0;
                    for (int i = 1; i <= 23; i++)
                    {
                        temp += ((iFraction >> (23 - i)) & 1) * Math.Pow(2, (-1) * i);
                    }
                    double dTemp = (double)(Math.Pow(-1, iSign) * Math.Pow(2, iExponent - 127)) * (1 + temp);
                    dlistRet.Add(dTemp);
                    dlistRet.Add(0);
                    iListRet.Add(value);
                    iListRet.Add(0);
                    iIndex += 2;
                }

            }
            return dlistRet;
        }
        private short[] ConvertStringDoubleToShortArray(string strDouble)
        {
            short[] data = new short[2];
            try
            {
                float fWrite = float.Parse(strDouble, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                byte[] res = BitConverter.GetBytes(fWrite);

                data[0] = (short)(res[0] | ((res[1] << 8) & 0xFF00));
                data[1] = (short)(res[2] | ((res[3] << 8) & 0xFF00));
            }
            catch
            { }
            return data;
        }
        private short[] ConvertInt32ToShortArray(int int32_val)
        {
            short[] data = new short[2];
            try
            {
                data[0] = (short)(int32_val & 0xFFFF);
                data[1] = (short)((int32_val >> 16) & 0xFFFF);
            }
            catch
            { }
            return data;
        }
        private short[] GetShortArrayFromStringASCII(string strData)
        {
            short[] shArray = null;
            try
            {
                if (strData != null && strData.Length > 0)
                {
                    int iSizeArray = (int)Math.Round(strData.Length / 2.0, MidpointRounding.AwayFromZero);
                    shArray = new short[iSizeArray];
                    char[] charArray = strData.ToCharArray();
                    int iIncs = 0;
                    for (int iCnt = 0; iCnt < charArray.Length;)
                    {
                        short shLow = (short)charArray[iCnt];
                        short shHigh = 0;
                        if (iCnt + 1 < charArray.Length)
                            shHigh = (short)charArray[iCnt + 1];
                        shArray[iIncs] = (short)(shLow | (shHigh << 8));
                        iIncs++;
                        iCnt += 2;
                    }
                }

            }
            catch
            {

            }
            return shArray;
        }
        private short[] ListShortValue(List<double> data)
        {
            short[] buff = new short[10];
            buff[0] = (short)(ClassSystemConfig.Ins.m_ClsCommon.m_iIndexControl + 1);
            buff[1] = 1;
            buff[2] = 1;
            for (int i = 0; i < 3; i++)
            {
                //short[] tmp = ConvertDoubleToShortArray(data[i]);
                int tmp = (int)(data[i] * 10000);
                buff[3 + i * 2] = (short)(tmp & 0xFFFF);
                buff[4 + i * 2] = (short)((tmp >> 16) & 0xFFFF);
            }
            return buff;
        }
        private short[] ConvertDoubleToShortArray(double dDouble)
        {
            short[] data = new short[2];
            try
            {
                byte[] res = BitConverter.GetBytes(dDouble);

                data[0] = (short)(res[0] | ((res[1] << 8) & 0xFF00));
                data[1] = (short)(res[2] | ((res[3] << 8) & 0xFF00));
            }
            catch
            { }
            return data;
        }
        public void HideSetupView()
        {
            panelMenu.Visible = false;
        }
        public static void ControlTextInvoke(System.Windows.Forms.Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate
                {
                    control.Text = text;
                }));
            }
            else
            {
                control.Text = text;
            }
        }
        public void AddCameraLogData(string camera,string _event,string image_Path)
        {
            try
            {
                connection.Open();

                // Câu lệnh SQL để thêm dữ liệu vào bảng camera_log
                string query = "INSERT INTO camera_log (Time, Camera, Event, image_Path) " +
                               "VALUES (@Time, @Camera, @Event, @image_Path)";
                // Tạo MySqlCommand và truyền kết nối và câu truy vấn vào
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Camera", camera);
                    cmd.Parameters.AddWithValue("@Event", _event);
                    cmd.Parameters.AddWithValue("@image_Path", image_Path);

                    // Thực thi câu lệnh SQL
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi thực hiện xong
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void SpreadZoom()
        {
            bSpreadOut = !bSpreadOut; // Đảo ngược giá trị
            main.ChangeSpreadView(m_countView, bSpreadOut, m_iIndexControl);
            btnSpread.BackColor = bSpreadOut ? SystemColors.MenuHighlight : Color.Transparent;
        }
        private void UI_Screen(Bitmap bmp)
        {
            CogImage24PlanarColor imageInput = new CogImage24PlanarColor(bmp);
            cogDisplay1.Image = imageInput;
            cogDisplay1.AutoFit = false;
        }

        #endregion

        #region Camera Read Video
        public void Read_Video_byRTSP(string url, int index)
        {
            // Dừng task cũ nếu đã tồn tại
            if (videoThreads.ContainsKey(index))
            {
                Console.WriteLine($"Dừng luồng cũ ở index {index}...");

                cancellationTokens[index]?.Cancel(); // Yêu cầu hủy
                videoThreads[index]?.Wait();         // Đợi task dừng

                // Xóa ra khỏi danh sách
                videoThreads.Remove(index);
                cancellationTokens.Remove(index);
            }

            if (capture != null)
            {
                capture.Release();
                capture = null;
            }
            capture = new VideoCaptureUser(url);

            if (!capture.IsOpened())
            {
                Console.WriteLine("Không thể kết nối tới camera RTSP");
                return;
            }

            // Tạo token hủy
            var cts = new CancellationTokenSource();
            cancellationTokens[index] = cts;

            // Dùng Task để chạy async function đúng cách
            Task videoTask = Task.Run(() => ProcessVideo(index, cts.Token));
            videoThreads[index] = videoTask;
        }

        private async Task ProcessVideo(int index, CancellationToken token)
        {
            int frameIndex = 0;
            while (!token.IsCancellationRequested)
            {
                try
                {
                    Mat frame = capture.Read();
                    Mat frame_resize = new Mat();
                    if (frame == null || frame.Empty())
                        continue;

                    //Mat frameCopy = frame.Clone();

                    //using (Bitmap bmp = BitmapConverter.ToBitmap(frameCopy))
                    //{
                    //    UI_Screen(bmp);
                    //}

                    //frameCopy.Dispose();
                    cogDisplay1.StaticGraphics.Clear();
                    
                    int width = frame.Width;
                    int height = frame.Height;

                    #region process
                    if (frameIndex % 5 != 0)
                    {
                        goto END;
                    }
                    else
                    {
                        Cv2.Resize(frame, frame_resize, new OpenCvSharp.Size(640, 640));
                        string image_str = ClassSystemConfig.Ins.m_ClsFunc.ImageToBase64(frame_resize);
                        int length = image_str.Length;
                        DateTime _time1 = DateTime.Now;
                        string predictionResult = await Predict_b64(frameIndex, image_str);
                        double total_time = (DateTime.Now - _time1).TotalMilliseconds;
                        Console.WriteLine("Time detect: " + total_time.ToString("F2"));

                        if (predictionResult.Contains("Error"))
                            goto END;

                        var result = JsonConvert.DeserializeObject<List<Detection>>(predictionResult);
                        if (result == null)
                            return;
                        if (result.Count == 0)
                        {
                            _Warning = false;
                            goto END;
                        }
                        foreach (var detection in result)
                        {
                            string label = detection.label;
                            double x1 = Convert.ToDouble(detection.x1);
                            double y1 = Convert.ToDouble(detection.y1);
                            double x2 = Convert.ToDouble(detection.x2);
                            double y2 = Convert.ToDouble(detection.y2);
                            double score = Convert.ToDouble(detection.score);

                            DrawGraphic(label, x1, y1, x2, y2, score, width, height);
                            twilio.SendSMS("whatsapp:+84965154762", "whatsapp:+14155238886", "Warning: Fire Alarm!");
                            Bitmap img_Graphic = GetImageGraphic();
                            BoundingBox newBoundingBox = new BoundingBox(label, x1, y1, x2, y2, score);
                            //previousBoundingBox.Add(newBoundingBox);
                            string image_graphic_path = "";
                            ClassSystemConfig.Ins.m_ClsFunc.SaveImageRaw("frame_" + frameIndex.ToString(), frame, img_Graphic, ref image_graphic_path);
                            AddCameraLogData(camera_Name, label, image_graphic_path);
                            main.UpdateCameraLogInvoke(this);
                            _Warning = true;
                            _timeWarning = DateTime.Now;
                        }
                    }
                    #endregion
                    END:
                        UI_Screen(frame.ToBitmap());
                        frameIndex++;
                        Thread.Sleep(5);
                        // Thoát khi nhấn phím ESC
                        int key = Cv2.WaitKey(10);
                        if (_Disposed == true)
                            break;
                        await Task.Delay(10, token); // async-friendly sleep
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine($"Luồng index {index} bị hủy.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        #region test_after
        private async void ProcessVideoDetection()
        {
            while (!_Disposed)
            {
                try
                {
                    int frameIndex = 0;
                    Mat frame = new Mat();
                    Mat frame_resize = new Mat();
                    previousBoundingBox = new List<BoundingBox>();
                    cogDisplay1.StaticGraphics.Clear();
                    frame = capture.Read();
                    if (frame == null || frame.Empty())
                    {
                        Console.WriteLine("Lỗi: Không thể đọc frame hoặc hết video.");
                        continue;
                    }

                    #region process
                    if (frameIndex % 8 != 0)
                    {
                        if (previousBoundingBox != null && previousBoundingBox.Count > 0)
                        {
                            foreach (var boundingBox in previousBoundingBox)
                            {
                                string label = boundingBox.Label;
                                double x1 = boundingBox.X1;
                                double y1 = boundingBox.Y1;
                                double x2 = boundingBox.X2;
                                double y2 = boundingBox.Y2;
                                double score = boundingBox.Score;

                                // Draw graphic or process bounding box data
                                //DrawGraphic(label, x1, y1, x2, y2, score);
                            }
                        }
                        goto END;
                    }

                    Cv2.Resize(frame, frame_resize, new OpenCvSharp.Size(640, 640));
                    //byte[] frameBytes = ConvertMatToByteArray(frame);
                    string image_str = ClassSystemConfig.Ins.m_ClsFunc.ImageToBase64(frame_resize);
                    int length = image_str.Length;
                    DateTime _time1 = DateTime.Now;
                    string predictionResult = await Predict_b64(frameIndex, image_str);
                    double total_time = (DateTime.Now - _time1).TotalMilliseconds;
                    Console.WriteLine("Time detect: " + total_time.ToString("F2"));

                    //string predictionResult = await Predict_byte(frameIndex, frameBytes);
                    if (predictionResult.Contains("Error"))
                        goto END;

                    var result = JsonConvert.DeserializeObject<List<Detection>>(predictionResult);
                    if (result == null)
                        return;
                    if (result.Count == 0)
                    {
                        _Warning = false;
                        goto END;
                    }
                    else
                    {
                        if (previousBoundingBox != null)
                            previousBoundingBox.Clear();
                    }
                    foreach (var detection in result)
                    {
                        string label = detection.label;
                        double x1 = Convert.ToDouble(detection.x1);
                        double y1 = Convert.ToDouble(detection.y1);
                        double x2 = Convert.ToDouble(detection.x2);
                        double y2 = Convert.ToDouble(detection.y2);
                        double score = Convert.ToDouble(detection.score);

                        //DrawGraphic(label, x1, y1, x2, y2, score);
                        BoundingBox newBoundingBox = new BoundingBox(label, x1, y1, x2, y2, score);
                        previousBoundingBox.Add(newBoundingBox);
                        //previousBoundingBox = new BoundingBox(label, x1, y1, x2, y2, score);
                        _Warning = true;
                        _timeWarning = DateTime.Now;
                    }
                #endregion

                END:
                    UI_Screen(frame.ToBitmap());
                    frameIndex++;
                    Thread.Sleep(5);
                    // Thoát khi nhấn phím ESC
                    int key = Cv2.WaitKey(10);
                    if (_Disposed == true)
                        break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
        #endregion

        public void Release()
        {
            _Disposed = true;
            capture.Release();
        }

        #endregion

        #region Hand_Click
        private void btnHideSetup_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }
        private Int32 m_lRealHandle = -1;
        private void btnLive_Click(object sender, EventArgs e)
        {
            if (m_lUserID < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();

                lpPreviewInfo.hPlayWnd = cogDisplay1.Handle;
                lpPreviewInfo.lChannel = 1;
                lpPreviewInfo.dwStreamType = 0;
                lpPreviewInfo.dwLinkMode = 0;
                lpPreviewInfo.bBlocked = true;
                lpPreviewInfo.dwDisplayBufNum = 1;
                lpPreviewInfo.byProtoType = 0;
                lpPreviewInfo.byPreviewMode = 0;

                IntPtr pUser = new IntPtr();

                //if (RealData == null)
                //{
                //    RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//Ô¤ÀÀÊµÊ±Á÷»Øµ÷º¯Êý
                //}


                //Start live view 
                //m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, /*null*/RealData, pUser);
                if (m_lRealHandle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //
                    btnLive.Text = "Stop Live View";
                }
            }
            else
            {
                // Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                }
                m_lRealHandle = -1;
                btnLive.Text = "Live View";

            }
        }

        // Khởi tạo cổng
        int lPort = -1;
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            if (dwDataType == CHCNetSDK.NET_DVR_SYSHEAD)
            {
                // Nếu nhận được dữ liệu tiêu đề hệ thống, có thể dùng để giải mã video
                if (dwBufSize > 0)
                {
                    FileStream fs = new FileStream("syshead.dat", FileMode.Create);
                    byte[] buffer = new byte[dwBufSize];
                    Marshal.Copy(pBuffer, buffer, 0, (int)dwBufSize);
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Close();
                }
            }
            else if (dwDataType == CHCNetSDK.NET_DVR_STREAMDATA)
            {
                // Nếu là dữ liệu video, xử lý từng frame ở đây
                byte[] buffer = new byte[dwBufSize];
                Marshal.Copy(pBuffer, buffer, 0, (int)dwBufSize);
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName;
            //the path and file name to save
            sJpegPicFileName = "JPEG_test.jpg";
            Mat image = new Mat();

            int lChannel = 1; //Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //Image quality
            lpJpegPara.wPicSize = 0xff; //Picture size: 2- 4CIF£¬0xff- Auto

            CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName);
            image = Cv2.ImRead(sJpegPicFileName, ImreadModes.Color);
            CogImage24PlanarColor imageInput = new CogImage24PlanarColor(image.ToBitmap());
            cogDisplay1.Image = imageInput;

            return;
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            string sVideoFileName;
            string dateTime = DateTime.Now.ToString("HH.mm.ss-dd_MM_yy");
            sVideoFileName = @"D:\record\Video_"+ dateTime+".mp4";

            if (m_bRecord == false)
            {
                //Make a I frame
                int lChannel = 1; //Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);

                //Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    btnRecord.Text = "Stop Record";
                    m_bRecord = true;
                }
            }
            else
            {
                //Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    str = "Successful to stop recording and the saved file is " + sVideoFileName;
                    MessageBox.Show(str);
                    btnRecord.Text = "Start Record";
                    m_bRecord = false;
                }
            }

            return;
        }
        bool m_bLive2 = false;
        private void btnLive2_Click(object sender, EventArgs e)
        {
            //if (m_bLive2 == false)
            //{
            //    StartThreadGetImage();
            //    btnLive2.Text = "Stop";
            //    m_bLive2 = true;
            //}
            //else
            //{
            //    if (m_Thread_GetImage != null)
            //    {
            //        m_Thread_GetImage.Abort();
            //    }
            //    btnLive2.Text = "Live2";
            //    m_bLive2 = false;
            //}
        }
        private void bntConnectCam_Click(object sender, EventArgs e)
        {
            if (m_lUserID < 0)
            {
                string DVRIPAddress = txbIP_Cam.Text;
                Int16 DVRPortNumber = Int16.Parse(txbIP_Port.Text);
                string DVRUserName = txbUser_name.Text;
                string DVRPassword = txbUser_pass.Text;

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    MessageBox.Show("Login Success!");
                    bntConnectCam.Text = "Logout";
                }
            }
            else
            {
                //Logout the device
                if (m_lRealHandle >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lUserID = -1;
                bntConnectCam.Text = "Login";
            }
            return;
        }
        public static String[] GetVideoFilesFrom(String searchFolder, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            String[] filters = new String[] { "mp4" };
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }
        private void btnSpread_Click(object sender, EventArgs e)
        {
            SpreadZoom();
        }
        private void btnRTSP_Click(object sender, EventArgs e)
        {
            rtspUrl = txbRTSP_Link.Text.Trim();
            //Read_Video_byRTSP(rtspUrl);
        }
        private void btnCameraLive_Click(object sender, EventArgs e)
        {
            if (ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Count > 0)
            {
                Read_Video_byRTSP(ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam[m_indexView], m_indexView);
                StartThreadWarning();
            }
            else
                MessageBox.Show("Không có camera nào được cấu hình");
        }
        private void btnVideoPredict_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv";
            fileDialog.Title = "Select a video file";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = fileDialog.FileName;
                if (!string.IsNullOrEmpty(selectedFile))
                {
                    Read_Video(selectedFile);
                    StartThreadWarning();
                }
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
        }
        #endregion

        #region Thread Warning
        public void StartThreadWarning()
        {
            m_Thread_Warning = new Thread(Thread_Warning);
            m_Thread_Warning.Start();
        }
        DateTime m_TimeTogle = DateTime.Now;
        private bool isRed = false;
        private bool b_tmpWarning = false;
        private void Thread_Warning()
        {
            while (true)
            {
                var elapsedTime = (DateTime.Now - _timeWarning).TotalMilliseconds;
                WarningGraphic();
                // Nếu đã vượt quá 2 giây và x vẫn là false
                if (elapsedTime >= 2000 && !_Warning)
                {
                    b_tmpWarning = false;// Tắt hàm Warning
                }
                Thread.Sleep(200);
            }
        }
        private void WarningGraphic()
        {
            if (_Warning || b_tmpWarning)
            {
                var delta = (DateTime.Now - m_TimeTogle).TotalMilliseconds;
                if (delta >= 1000)
                {
                    if (isRed)
                    {
                        ControlTextInvoke(lbNameControl, "                     WARNING!");
                        panelHeader.BackColor = Color.Red;
                    }
                    else
                    {
                        panelHeader.BackColor = Color.Linen;
                    }
                    isRed = !isRed;
                    m_TimeTogle = DateTime.Now;
                }
            }
            else
            {
                ControlTextInvoke(lbNameControl, camera_Name);
                panelHeader.BackColor = Color.Linen;
            }

            _Warning = false;
            b_tmpWarning = true;
        }
        #endregion

        #region Class
        class Status
        {
            public bool VS_Alive { get; set; }
            public bool VS_Ready { get; set; }
        }

        class ApiResponse
        {
            public List<Detection> detections { get; set; }
        }

        public class Prediction
        {
            public float[] BoundingBox { get; set; }
            public float Confidence { get; set; }
            public float[] ClassProbabilities { get; set; }
        }

        class BoundingBox
        {
            public string Label { get; set; }
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }
            public double Score { get; set; }

            public BoundingBox(string label, double x1, double y1, double x2, double y2, double score)
            {
                Label = label;
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
                Score = score;
            }

            // Phương thức để in thông tin bounding box
            public override string ToString()
            {
                return $"{Label}, {X1}, {Y1}, {X2}, {Y2}, {Score:F2}";
            }
        }
        #endregion


    }
}
