using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Gdk.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkGeometryPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}
