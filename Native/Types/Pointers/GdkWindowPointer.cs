using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkWindowPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}