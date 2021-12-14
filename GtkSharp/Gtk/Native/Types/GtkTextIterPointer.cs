using System;
using System.Runtime.InteropServices;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Native.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GtkTextIterPointer
    {
        public IntPtr pointer;

        public GtkTextIterPointer(GtkTextIter iter)
        {
            pointer = MarshalHelper.MarshalStructureToPtr<GtkTextIter>(iter);
        }

        public bool IsNullPointer
        {
            get { return pointer == IntPtr.Zero; }
        }

        public void Free()
        {
            MarshalHelper.FreePtr(pointer);
        }
    }
}
