using System;
using System.Runtime.InteropServices;
using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GList
    {
        public IntPtr data;
        public GListPointer next;
        public GListPointer prev;
    }
}