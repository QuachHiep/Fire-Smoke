using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenCvSharp;

namespace DemoFire.Class
{
    public class VideoCaptureUser
    {
        private VideoCapture cap;
        private ConcurrentQueue<Mat> frameQueue;
        private Thread readerThread;
        private bool isDisposed = false;

        public VideoCaptureUser(string url)
        {
            cap = new VideoCapture(url); // RTSP URL
            frameQueue = new ConcurrentQueue<Mat>();

            readerThread = new Thread(Reader);
            readerThread.IsBackground = true;
            readerThread.Start();
        }

        // Kiểm tra trạng thái kết nối RTSP
        public bool IsOpened()
        {
            return cap.IsOpened(); // Kiểm tra xem videoCapture có mở thành công không
        }

        // Đọc khung hình từ video stream và giữ lại khung mới nhất
        private void Reader()
        {
            while (!isDisposed)
            {
                Mat frame = new Mat();
                if (!cap.Read(frame) || frame.Empty())
                {
                    continue; // Nếu không đọc được khung, tiếp tục vòng lặp
                }

                // Không sử dụng using để giải phóng Mat trước khi hoàn tất xử lý
                if (frameQueue.Count > 0)
                {
                    // Đảm bảo rằng chúng ta không giữ lại các frame cũ chưa được xử lý
                    frameQueue.TryDequeue(out Mat temp);
                }

                // Đảm bảo rằng frame được đưa vào hàng đợi để tiếp tục xử lý
                frameQueue.Enqueue(frame);

                Thread.Sleep(10); // Giảm tải CPU
            }
        }

        // Đọc khung hình tiếp theo
        public Mat Read()
        {
            if (frameQueue.TryDequeue(out Mat frame))
            {
                return frame;
            }
            return null;
        }

        // Giải phóng tài nguyên
        public void Release()
        {
            isDisposed = true;

            // Đợi thread reader kết thúc nếu nó vẫn đang chạy
            if (readerThread != null && readerThread.IsAlive)
            {
                readerThread.Join(); // Đợi reader kết thúc
            }

            cap.Release();
        }
    }
}
