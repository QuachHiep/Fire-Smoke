using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Text.RegularExpressions;
using System.Threading;
using DKVN;
using System.Xml;
using MySql.Data.MySqlClient;

namespace DemoFire
{
    public partial class Form1 : Form
    {
        Thread m_ThreadUpdate;
        public int Col = 2;
        public int Row = 2;

        MySqlConnection connection = new MySqlConnection(ClassSystemConfig.Ins.m_ClsCommon.connectionString);


        public Form1()
        {
            StartLoadingForm();

            InitializeComponent();
            //this.TopMost = true;
        }
        public void UpdateCameraLogInvoke(System.Windows.Forms.Control control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate
                {
                    UpdateCameraLog();
                }));
            }
            else
            {
                UpdateCameraLog();
            }
        }
        public void UpdateCameraLog()
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Viết câu lệnh SQL để truy vấn dữ liệu
                string query = "SELECT Camera, Time, Event FROM camera_log ORDER BY STT DESC";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);

                // Tạo DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                // Điền dữ liệu vào DataTable
                dataAdapter.Fill(dataTable);

                // Gán DataTable vào DataGridView
                dgviewLog.DataSource = dataTable;

                ClassSystemConfig.Ins.m_ClsFunc.FormatDataGridView(dgviewLog);

                //dgviewLog.Columns["STT"].HeaderText = "STT";
                //dgviewLog.Columns["STT"].Width = 30;
                dgviewLog.Columns["Camera"].HeaderText = "Camera";
                dgviewLog.Columns["Camera"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgviewLog.Columns["Camera"].Width = 80;
                dgviewLog.Columns["Time"].HeaderText = "Time";
                dgviewLog.Columns["Time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgviewLog.Columns["Event"].HeaderText = "Event";
                dgviewLog.Columns["Event"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgviewLog.Columns["Event"].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                connection.Close();
            }
        }
        private void LoadCameraList()
        {
            // Cập nhật danh sách camera
            ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Clear();
            ClassSystemConfig.Ins.m_ClsFunc.GetRtspUrls(connection, ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeUI();
            LoadCameraList();

            m_ThreadUpdate = new Thread(ThreadUpdateStatus);
            m_ThreadUpdate.Start();
            Thread.Sleep(2000);
            StopLoadingForm();
            UpdateCameraLogInvoke(this);


            this.WindowState = FormWindowState.Maximized;
        }

        #region From Move
        bool MouseDown = false;
        System.Drawing.Point StartPoint;
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.Location.X - StartPoint.X), this.Location.Y + (e.Location.Y - StartPoint.Y));
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartPoint = e.Location;
        }
        #endregion

        #region SpreadView
        TableLayoutPanel[] tableLayoutPanelDevice;
        TableLayoutPanel[] tableLayoutPanels;
        public void LayoutSpreadView()
        {
            if (tableLayoutPanel2.InvokeRequired)
            {
                tableLayoutPanel2.Invoke(new Action(() =>
                {
                    LayoutSpreadView();
                }));
            }
            else
            {
                tableLayoutPanel2.Controls.Clear();
                tableLayoutPanel2.ColumnStyles.Clear();
                tableLayoutPanel2.RowStyles.Clear();
                tableLayoutPanel2.RowCount = Row; //col
                tableLayoutPanelDevice = new TableLayoutPanel[Row]; //col
                ClassSystemConfig.Ins.m_UserDisplay.Clear();

                if (Row > Col)
                {
                    for (int i = 0; i < Row; i++)
                    {
                        ClassSystemConfig.Ins.m_UserDisplay.Add(new UserCtrlDisplay[20]);
                    }
                }
                else
                {
                    for (int i = 0; i < Col; i++)
                    {
                        ClassSystemConfig.Ins.m_UserDisplay.Add(new UserCtrlDisplay[20]);
                    }
                }

                for (int i = 0; i < Row; i++)//col
                {
                    tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / Row)); //col
                    tableLayoutPanelDevice[i] = new TableLayoutPanel();
                    tableLayoutPanel2.Controls.Add(tableLayoutPanelDevice[i]);
                    tableLayoutPanelDevice[i].Dock = DockStyle.Fill;
                }

                int indexCam = 1;
                for (int j = 0; j < Row; j++)//col
                {
                    tableLayoutPanelDevice[j].ColumnCount = Col; //row
                    for (int i = 0; i < ClassSystemConfig.Ins.m_UserDisplay.Count; i++) //row
                    {
                        tableLayoutPanelDevice[j].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / Col));//rrow
                        ClassSystemConfig.Ins.m_UserDisplay[j][i] = new UserCtrlDisplay(j, "                   CAM"+ indexCam.ToString(), this, indexCam, i);
                        tableLayoutPanelDevice[j].Controls.Add(ClassSystemConfig.Ins.m_UserDisplay[j][i], i, 0);
                        ClassSystemConfig.Ins.m_UserDisplay[j][i].Dock = DockStyle.Fill;
                        indexCam++;
                    }
                }

            }
        }
        public void ChangeSpreadView(int indexView, bool spreadOut, int indexCam)
        {
            if (Col == 100)
            {
                if (spreadOut)
                {
                    if (indexView <= 2)
                    {
                        int d = tableLayoutPanel2.RowStyles.Count;
                        tableLayoutPanel2.RowStyles[1].Height = 0;
                        tableLayoutPanel2.RowStyles[0].Height = 100;
                        for (int i = 0; i < tableLayoutPanels[0].ColumnCount; i++)
                        {
                            tableLayoutPanels[0].ColumnStyles[i].Width = 0;
                        }
                        tableLayoutPanels[0].ColumnStyles[indexView].Width = 100;
                    }
                    else
                    {
                        tableLayoutPanel2.RowStyles[0].Height = 0;
                        tableLayoutPanel2.RowStyles[1].Height = 100;
                        for (int i = 0; i < tableLayoutPanels[1].ColumnCount; i++)
                        {
                            tableLayoutPanels[1].ColumnStyles[i].Width = 0;
                        }
                        tableLayoutPanels[1].ColumnStyles[indexView - 3].Width = 100;
                    }

                }
                else
                {
                    tableLayoutPanel2.RowStyles[0].Height = 50;
                    tableLayoutPanel2.RowStyles[1].Height = 50;

                    for (int i = 0; i < tableLayoutPanels[0].ColumnCount; i++)
                    {
                        tableLayoutPanels[0].ColumnStyles[i].Width = 100 / 3;
                        tableLayoutPanels[1].ColumnStyles[i].Width = 100 / 3;
                    }

                }
            }
            else
            {
                if (spreadOut)
                {
                    for (int i = 0; i < tableLayoutPanel2.RowCount; i++)
                    {
                        tableLayoutPanel2.RowStyles[i].Height = 0;
                    }
                    tableLayoutPanel2.RowStyles[indexCam].Height = 100;

                    for (int i = 0; i < tableLayoutPanelDevice[indexCam].ColumnCount; i++)
                    {
                        tableLayoutPanelDevice[indexCam].ColumnStyles[i].Width = 0;
                    }
                    tableLayoutPanelDevice[indexCam].ColumnStyles[indexView].Width = 100;
                }
                else
                {
                    for (int i = 0; i < tableLayoutPanel2.RowCount; i++)
                    {
                        tableLayoutPanel2.RowStyles[i].Height = 100 / tableLayoutPanel2.RowCount;
                    }

                    for (int i = 0; i < tableLayoutPanelDevice[indexCam].ColumnCount; i++)
                    {
                        tableLayoutPanelDevice[indexCam].ColumnStyles[i].Width = tableLayoutPanelDevice[indexCam].ColumnCount;
                    }
                }
            }
        }
        #endregion

        #region Save Log XML (Log In)
        public void SavePassLogIn(string fileSaving, string[] strPass)
        {
            string pathSaving = Directory.GetCurrentDirectory() + "\\" + "Config Setting";
            if (!Directory.Exists(pathSaving))
            {
                Directory.CreateDirectory(pathSaving);
            }
            //if (!File.Exists(pathSaving + "\\" + fileSaving))
            //    File.Create(pathSaving + "\\" + fileSaving);

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("Users");
                xmlDoc.AppendChild(rootNode);


                for (int i = 0; i < strPass.Length; i++)
                {
                    string strTemp = "";
                    switch (i)
                    {
                        case 0:
                            strTemp = "OP"; break;
                        case 1:
                            strTemp = "EGN"; break;
                        case 2:
                            strTemp = "MAS"; break;
                        default:
                            strTemp = ""; break;
                    }
                    byte[] bytesArr = Encoding.ASCII.GetBytes(strPass[i]);
                    string strWrite = "";
                    for (int iChar = 0; iChar < bytesArr.Length; iChar++)
                        strWrite += bytesArr[iChar].ToString("x");
                    XmlNode userNode = xmlDoc.CreateElement("Name");
                    XmlAttribute attribute = xmlDoc.CreateAttribute(strTemp);
                    attribute.Value = "Level " + i;
                    userNode.Attributes.Append(attribute);
                    userNode.InnerText = strWrite;
                    rootNode.AppendChild(userNode);

                }

                xmlDoc.Save(pathSaving + "\\" + fileSaving);
            }
            catch { }


        }
        public void LoadPasLogin(string fileSaving)
        {
            List<string> listPassTemp = new List<string>();
            try
            {
                string pathSaving = Directory.GetCurrentDirectory() + "\\" + "Config Setting";
                if (File.Exists(pathSaving + "\\" + fileSaving))
                {
                    XmlDataDocument xmlDoc = new XmlDataDocument();
                    XmlNodeList xmlNode;


                    FileStream fs = new FileStream(pathSaving + "\\" + fileSaving, FileMode.Open, FileAccess.Read);
                    xmlDoc.Load(fs);
                    xmlNode = xmlDoc.GetElementsByTagName("Users");
                    for (int iElem = 0; iElem <= xmlNode.Count - 1; iElem++)
                    {
                        for (int iChil = 0; iChil < xmlNode[iElem].ChildNodes.Count; iChil++)
                        {

                            listPassTemp.Add(xmlNode[iElem].ChildNodes.Item(iChil).InnerText.Trim());

                        }
                    }

                    fs.Close();
                }
            }
            catch
            {

            }

            try
            {
                ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[0] = (listPassTemp.Count > 0) ? ClassSystemConfig.Ins.m_ClsCommon.ConvertByteStringToASCII(listPassTemp[0]) : "1";
                ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[1] = (listPassTemp.Count > 1) ? ClassSystemConfig.Ins.m_ClsCommon.ConvertByteStringToASCII(listPassTemp[1]) : "123";
                ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[2] = (listPassTemp.Count > 2) ? ClassSystemConfig.Ins.m_ClsCommon.ConvertByteStringToASCII(listPassTemp[2]) : "123!";
            }
            catch
            {

            }
        }
        public void ShowUILogIn()
        {
            if (ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.OPERATOR])
            {
                btnLog.Enabled = false;
                btnSetting.Enabled = false;
                btnMainUI.Enabled = false;
            }
            else
                if (ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ENGINEER])
            {
                btnLog.Enabled = true;
                btnSetting.Enabled = false;
                btnMainUI.Enabled = true;
            }
            else
                    if (ClassSystemConfig.Ins.m_ClsCommon.m_bLogInMode[(int)ClassCommon.LOGIN_LEVEL.ADMIN])
            {
                btnLog.Enabled = true;
                btnSetting.Enabled = true;
                btnMainUI.Enabled = true;
            }
            else
            {
                btnLog.Enabled = false;
                btnSetting.Enabled = false;
                btnMainUI.Enabled = false;
            }

        }
        #endregion

        #region Save/Load Config
        public void SaveDeviceConfig(bool ShowMessage)
        {
            string file_name = Directory.GetCurrentDirectory() + @"\Config Setting\DeviceConfig.ini";

            if (!System.IO.File.Exists(file_name))
            {
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Config Setting");
            }

            try
            {
                using (StreamWriter objWriter = new StreamWriter(file_name))
                {
                    objWriter.WriteLine("[PROGRAM NAME]  " + ClassCommon.ProgramName);
                    objWriter.WriteLine("[MACHINE NAME]  " + ClassCommon.MachineName);

                    // IP CAM VISION
                    //for (int iControl = 0; iControl < ClassCommon.MaxDevice; iControl++)
                    //    objWriter.WriteLine(String.Format("[IP CAM VISION {0}]  {1}", iControl + 1, ClassSystemConfig.Ins.m_ClsCommon.m_ListIPCAM[iControl]));
                    //for (int i = 0; i < ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Count; i++)
                    //{
                    //    // Ghi vào tệp với tên camera từ 1 đến 9
                    //    objWriter.WriteLine("[RTSP CAMERA " + (i + 1) + "]  " + ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam[i]);
                    //}

                    // LOGIN
                    objWriter.WriteLine("[LOGIN USER]  " + ClassSystemConfig.Ins.m_ClsCommon.m_ListUserLogin[0]);
                    objWriter.WriteLine("[LOGIN PASS]  " + "***");

                    // SAVING
                    objWriter.WriteLine("[IS SAVE IMG_LOCAL]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgOKNG_Local ? 1 : 0));
                    objWriter.WriteLine("[IS SAVE GRAPHIC IMG LOCAL]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_Local ? 1 : 0));
                    objWriter.WriteLine("[IS SAVE LOG LOCAL]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local ? 1 : 0));
                    objWriter.WriteLine("[IS SAVE IMG_FTP]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgOKNG_FTP ? 1 : 0));
                    objWriter.WriteLine("[IS SAVE GRAPHIC IMG FTP]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_FTP ? 1 : 0));
                    objWriter.WriteLine("[IS SAVE LOG FTP]  " + (ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_FTP ? 1 : 0));

                    objWriter.WriteLine("[IS DELETE AUTO]  " + (ClassSystemConfig.Ins.m_ClsCommon.m_bAutoDeleteImg ? 1 : 0));
                    objWriter.WriteLine("[PERIOD DELETE]  " + ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete);
                    objWriter.WriteLine("[COMMON PATH]  " + ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath);

                    objWriter.WriteLine("[SHOW GRAPHIC]  " + (ClassSystemConfig.Ins.m_ClsCommon.m_bShowGraphic ? "1" : "0"));
                    objWriter.WriteLine("[SHOW ORIGIN]  " + (ClassSystemConfig.Ins.m_ClsCommon.m_bShowOrigin ? "1" : "0"));
                    objWriter.WriteLine("[SHOW PROGRESS STATUS]  " + (ClassSystemConfig.Ins.m_ClsCommon.m_bShowProgressStatus ? "1" : "0"));

                    objWriter.Close();
                }
                if (ShowMessage)
                {
                    MessageBox.Show("Saved Configurations");
                }
            }
            catch
            {
                if (ShowMessage)
                {
                    MessageBox.Show("Save Fail");
                }
            }

        }
        private void LoadDeviceConfig(bool ShowMessage)
        {
            string file_name = Directory.GetCurrentDirectory() + @"\Config Setting\DeviceConfig.ini";

            if (!System.IO.Directory.Exists(Directory.GetCurrentDirectory() + @"\Config Setting"))
            {
                System.IO.Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Config Setting");
            }
            else
            {
                try
                {
                    try
                    {
                        ClassCommon.ProgramName = ClassCommon.GetConfig(file_name, "PROGRAM NAME", "UT ALIGNMENT");
                        ClassCommon.MachineName = ClassCommon.GetConfig(file_name, "MACHINE NAME", "MC #2");

                        //for (int i = 0; i < 9; i++)
                        //{
                        //    // Ghi vào tệp với tên camera từ 1 đến 9
                        //    ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam.Add("");
                        //    ClassSystemConfig.Ins.m_ClsCommon.m_ListRtspCam[i] = ClassCommon.GetConfig(file_name, "RTSP CAMERA " + (i + 1), "");
                        //}

                        ClassSystemConfig.Ins.m_ClsCommon.m_ListUserLogin[0] = ClassCommon.GetConfig(file_name, "LOGIN USER", "Admin");
                        ClassSystemConfig.Ins.m_ClsCommon.m_ListPasswordLogin[0] = ClassCommon.GetConfig(file_name, "LOGIN PASS", "");

                        ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgOKNG_Local = (ClassCommon.GetConfig(file_name, "IS SAVE IMG_LOCAL", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_Local = (ClassCommon.GetConfig(file_name, "IS SAVE GRAPHIC IMG LOCAL", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local = (ClassCommon.GetConfig(file_name, "IS SAVE LOG LOCAL", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.IsSaveImgGraphic_FTP = (ClassCommon.GetConfig(file_name, "IS SAVE GRAPHIC IMG FTP", "1").Trim() == "1") ? true : false;

                        ClassSystemConfig.Ins.m_ClsCommon.m_bAutoDeleteImg = (ClassCommon.GetConfig(file_name, "IS DELETE AUTO", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.m_iPeriodDelete = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "PERIOD DELETE", "30"), 15);
                        ClassSystemConfig.Ins.m_ClsCommon.m_CommonPath = ClassCommon.GetConfig(file_name, "COMMON PATH", Directory.GetCurrentDirectory());

                        ClassSystemConfig.Ins.m_ClsCommon.m_bShowGraphic = (ClassCommon.GetConfig(file_name, "SHOW GRAPHIC", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.m_bShowOrigin = false; // (ClassCommon.GetConfig(file_name, "SHOW ORIGIN", "1").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.m_bShowProgressStatus = (ClassCommon.GetConfig(file_name, "SHOW PROGRESS STATUS", "0").Trim() == "1") ? true : false;

                        ClassSystemConfig.Ins.m_ClsCommon.m_bAutoReconnect = (ClassCommon.GetConfig(file_name, "AUTO RECONNECT", "0").Trim() == "1") ? true : false;
                        ClassSystemConfig.Ins.m_ClsCommon.IsSaveByFTP = (ClassCommon.GetConfig(file_name, "IS_FTP_SAVING", "1").Trim() == "1") ? true : false;

                        ClassSystemConfig.Ins.m_ClsCommon.m_iTimeBetween2Trigger = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "TIMEOUT GET IMAGE", "1000"), 1000);
                        ClassSystemConfig.Ins.m_ClsCommon.m_iModeTriggerLight = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "TRIGGER LIGHT MODE", "1"), 1);
                        ClassSystemConfig.Ins.m_ClsCommon.m_iTimeDelayTriggerCAM = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "DELAY TRIGGER CAM MS", "100"), 100);
                        ClassSystemConfig.Ins.m_ClsCommon.m_iTimeDelaySendReady = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "DELAY SEND READY MS", "50"), 50);
                        ClassSystemConfig.Ins.m_ClsCommon.m_iTimeoutCheckReady = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "TIMEOUT CHECK READY MS", "2000"), 2000);
                        ClassSystemConfig.Ins.m_ClsCommon.m_iFormatSavingMode = ClassSystemConfig.Ins.m_ClsCommon.ConvertStringToInt(ClassCommon.GetConfig(file_name, "SAVING JPG MODE", "0"), 0);
                        ClassSystemConfig.Ins.m_ClsCommon.m_bCheckTimeoutReady = (ClassCommon.GetConfig(file_name, "CHECK TIMEOUT READY", "0").Trim() == "1") ? true : false;

                    }
                    catch { }

                }
                catch
                {
                    if (ShowMessage)
                    {
                        MessageBox.Show("Load Fail");
                    }
                }
            }

        }

        #endregion

        #region Init
        private void InitializeUI()
        {
            LoadDeviceConfig(false);
            LoadPasLogin("User.xml");
            LayoutSpreadView();

            ClassSystemConfig.Ins.m_CameraList.Owner = this;
            ClassSystemConfig.Ins.m_FrmLogin.Owner = this;
            ClassSystemConfig.Ins.m_FrmSetting.Owner = this;
            ClassSystemConfig.Ins.m_FrmLogin.InitializeUI(this);
            ClassSystemConfig.Ins.m_FrmSetting.InitializeUI(this);
            ClassSystemConfig.Ins.m_CameraList.InitializeUI(this);
            ClassSystemConfig.Ins.m_FrmParamCamera.Innit(this);
            //ClassSystemConfig.Ins.m_SettingParam.InitPageSetup(this, 0, "SETTING");

        }
        
        #endregion

        #region Hand_Click
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_ThreadUpdate != null)
                m_ThreadUpdate.Abort();


            Thread.Sleep(100);
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Edit Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Function
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
        public static byte[] ImageToByteArray(dynamic img)
        {
            // Lấy thông tin mảng ảnh và chuyển sang byte array
            var shape = img.shape;
            int width = shape[1];
            int height = shape[0];
            int channels = shape[2];

            byte[] byteArray = img.tobytes();
            return byteArray;
        }
        static byte[] ConvertMatToByteArray(Mat mat)
        {
            // Encode frame (Mat) to JPG byte array
            return mat.ToBytes(".jpg");
        }
        public void ConvertBitmapToNumpy()
        {
            // Tải bitmap từ file
            Bitmap bitmap = new Bitmap("image.png");

            // Chuyển đổi Bitmap thành mảng byte
            int width = bitmap.Width;
            int height = bitmap.Height;
            byte[] pixelData;

            // Khóa bitmap để đọc pixel
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try
            {
                int stride = bitmapData.Stride;
                pixelData = new byte[stride * height];
                Marshal.Copy(bitmapData.Scan0, pixelData, 0, pixelData.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }


            //// Gửi dữ liệu tới Python
            //using (Py.GIL()) // Đảm bảo quản lý GIL khi gọi Python từ C#
            //{
            //    dynamic np = Py.Import("numpy");

            //    // Chuyển đổi mảng byte thành NumPy array
            //    dynamic numpyArray = np.array(pixelData);
            //    numpyArray = numpyArray.reshape(height, width, 3); // Reshape thành mảng 3D (height, width, channels)

            //    Console.WriteLine($"NumPy array shape: {numpyArray.shape}");
            //}
        }
        #endregion

        #region Thread
        private void ThreadUpdateStatus()
        {
            while (true)
            {
                ControlTextInvoke(lbTime, DateTime.Now.ToString("HH:mm:ss"));
                ControlTextInvoke(lbDate, DateTime.Now.ToString("MMM d, ddd"));
            }
        }

        #endregion

        #region Loading Form
        Thread m_threadLoadingForm;
        FormStartupLoading m_FrmLoad;
        private void LoadingForm()
        {
            try
            {
                m_FrmLoad = new FormStartupLoading();
                Application.Run(m_FrmLoad);

            }
            catch (System.Threading.ThreadAbortException ex)
            {
                Console.WriteLine("=>Throw: " + ex.Message);
                throw ex;

            }
        }
        public void StartLoadingForm()
        {
            m_threadLoadingForm = new Thread(new ThreadStart(LoadingForm));
            m_threadLoadingForm.Start();

        }
        public void StopLoadingForm()
        {
            try
            {
                m_FrmLoad.Invoke(new MethodInvoker(delegate { m_FrmLoad.Hide(); }));

                if (m_threadLoadingForm != null)
                {
                    m_threadLoadingForm.Abort();
                }
            }
            catch
            {

            }

        }
        #endregion

        private void btnVision_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoginIcon_Click(object sender, EventArgs e)
        {
            ClassSystemConfig.Ins.m_FrmLogin.ShowDialog();
            ClassSystemConfig.Ins.m_ClsFunc.SaveLog(ClassFunction.SAVING_LOG_TYPE.HANDLER_CLICKED,
                                                    "Clicked Login",
                                                    ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local, true);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ChangeButtonColorCLick(sender);
            ClassSystemConfig.Ins.m_FrmParamCamera.Show();
            ClassSystemConfig.Ins.m_FrmParamCamera.ShowOnScreen();
            ClassSystemConfig.Ins.m_ClsFunc.SaveLog(ClassFunction.SAVING_LOG_TYPE.HANDLER_CLICKED,
                                                    "Clicked Camera Setting",
                                                    ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local, true);
        }
        private void ChangeButtonColorCLick(object sender)
        {
            if ((Button)sender == btnMainUI)
            {
                btnMainUI.BackColor = Color.DeepSkyBlue;
                btnSetting.BackColor = Color.Aquamarine;
                btnLog.BackColor = Color.Aquamarine;

            }
            else
                if ((Button)sender == btnSetting)
            {
                btnMainUI.BackColor = Color.Aquamarine;
                btnSetting.BackColor = Color.DeepSkyBlue;
                btnLog.BackColor = Color.Aquamarine;
            }
            else
                    if ((Button)sender == btnLog)
            {
                btnMainUI.BackColor = Color.Aquamarine;
                btnSetting.BackColor = Color.Aquamarine;
                btnLog.BackColor = Color.DeepSkyBlue;
            }
        }

        private void btnMainUI_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ChangeButtonColorCLick(sender);
            ClassSystemConfig.Ins.m_FrmLogView.Show();
            ClassSystemConfig.Ins.m_FrmLogView.ShowOnScreen();
            ClassSystemConfig.Ins.m_ClsFunc.SaveLog(ClassFunction.SAVING_LOG_TYPE.HANDLER_CLICKED,
                                                    "Clicked Log View",
                                                    ClassSystemConfig.Ins.m_ClsCommon.IsSaveLog_Local, true);

        }
    }
}
