using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Native.Types
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
