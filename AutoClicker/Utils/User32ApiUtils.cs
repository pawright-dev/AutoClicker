using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace AutoClicker.Utils
{
    public static class User32ApiUtils
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        internal static extern bool SetCursorPosition(int x, int y);

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        internal static extern bool GetCursorPosition(out POINT lpPoint);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        internal static extern void ExecuteMouseEvent(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        internal static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
    }
}
