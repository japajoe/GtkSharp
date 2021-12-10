using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GdkEventButtonPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}