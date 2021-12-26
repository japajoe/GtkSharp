using System;
using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkWindow : GObject
    {
        public GdkWindow(IntPtr pointer)
        {
            handle.pointer = pointer;
        }

        public void Setcursor(GdkCursor cursor)
        {
            if(handle.IsNullPointer)
            {
                return;
            }
            
            NativeGdkWindow.gdk_window_set_cursor(handle, cursor.handle);
        }
    }
}