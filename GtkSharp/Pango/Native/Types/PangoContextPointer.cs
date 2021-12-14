using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Pango.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PangoContextPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}
