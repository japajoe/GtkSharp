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
            
            NativeGdkWindow.gdk_window_set_cursor(handle, cursor.Handle);
        }

        public bool GetPosition(out int x, out int y)
        {
            if(handle.IsNullPointer)
            {
                x = 0;
                y = 0;
                return false;
            }

            NativeGdkWindow.gdk_window_get_position(handle, out x, out y);
            return true;
        }

        public bool GetDevicePosition(GdkDevice device, out int x, out int y, out GdkModifierType modifierType)
        {
            if(handle.IsNullPointer)
            {
                x = 0;
                y = 0;
                modifierType = GdkModifierType.Button1Mask;
                return false;
            }
            
            NativeGdkWindow.gdk_window_get_device_position(handle, device.Handle, out x, out y, out modifierType);
            return true;
        }
    }
}