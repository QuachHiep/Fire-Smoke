using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoFire.Class
{
    public class ThreadMonitor
    {
        private CancellationTokenSource _cts;
        private Task _monitorTask;

        public void StartMonitoring(int intervalMs = 1000)
        {
            if (_monitorTask != null && !_monitorTask.IsCompleted)
            {
                Console.WriteLine("Đang theo dõi rồi.");
                return;
            }

            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            _monitorTask = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    var process = Process.GetCurrentProcess();
                    var threads = process.Threads;

                    Console.WriteLine($"\n--- THREAD MONITOR [{DateTime.Now:HH:mm:ss}] ---");

                    foreach (ProcessThread thread in threads)
                    {
                        Console.WriteLine($"[ID={thread.Id}] State={thread.ThreadState}, Start={thread.StartTime:HH:mm:ss}");
                    }

                    Console.WriteLine($"Số lượng thread: {threads.Count}");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Thread.Sleep(intervalMs); // khoảng thời gian giữa mỗi lần theo dõi

                }

                Console.WriteLine("Đã dừng theo dõi luồng.");
            }, token);
        }

        public void StopMonitoring()
        {
            _cts?.Cancel();
            _monitorTask?.Wait();
        }
    }
}
