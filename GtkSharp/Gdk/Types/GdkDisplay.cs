using GtkSharp.Gdk.Native;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkDisplay : GObject
    {
        public GdkDisplay()
        {
            handle = NativeGdkDisplay.gdk_display_get_default();
        }

        public GdkScreen GetScreen(int screenNum)
        {
            if(handle.IsNullPointer)
                return null;
            
            GObjectPointer s = NativeGdkDisplay.gdk_display_get_screen(handle, screenNum);
            return new GdkScreen(s.pointer);
        }

        public GdkScreen GetScreen()
        {
            if(handle.IsNullPointer)
                return null;

            GObjectPointer s = NativeGdkDisplay.gdk_display_get_default_screen(handle);
            return new GdkScreen(s.pointer);
        }
        
        public int GetScreenCount()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeGdkDisplay.gdk_display_get_n_screens(handle);
        }

        public GdkDeviceManager GetDeviceManager()
        {
            if(handle.IsNullPointer)
                return null;

            GObjectPointer obj = NativeGdkDisplay.gdk_display_get_device_manager(handle);
            return new GdkDeviceManager(obj.pointer);
        }

        public string GetName()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            return NativeGdkDisplay.gdk_display_get_name(handle);
        }

        public void WarpPointer(int x, int y, GdkScreen screen)
        {
            if(handle.IsNullPointer)
                return;
            
            if(screen.Handle.IsNullPointer)
                return;
            
            NativeGdkDisplay.gdk_display_warp_pointer(handle, screen.Handle, x, y);
        }
    }
}