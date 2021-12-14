using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Glib.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GFilePointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}
