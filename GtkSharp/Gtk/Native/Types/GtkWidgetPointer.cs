using System;
using System.Runtime.InteropServices;

namespace GtkSharp.Gtk.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkWidgetPointer
    {
        public IntPtr pointer;

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }
    }
}