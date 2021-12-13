using System;
using System.Runtime.InteropServices;

namespace GtkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkTreeIter
    {
        public int stamp;
        public IntPtr user_data;
        public IntPtr user_data2;
        public IntPtr user_data3;
    }
}