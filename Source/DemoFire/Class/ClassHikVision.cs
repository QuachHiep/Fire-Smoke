using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoFire.Class
{
    internal class ClassHikVision
    {
        // Khai báo các hàm từ thư viện PlayM4
        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PlayM4_OpenStream(int lPort, IntPtr pBuf, uint dwSize, uint dwBufSize);

        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PlayM4_InputData(int lPort, IntPtr pBuf, uint dwSize);

        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PlayM4_GetFrame(int lPort, IntPtr pFrame);

        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PlayM4_Play(int lPort, IntPtr hWnd);

        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PlayM4_StopRealPlay(int lPort);

        [DllImport("PlayM4.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int PlayM4_GetLastError(int lPort);
    }
}
