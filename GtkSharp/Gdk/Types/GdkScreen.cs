using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkScreen : GObject
    {
        public int Width
        {
            get
            {
                return GetWidth();
            }
        }

        public int Height
        {
            get
            {
                return GetHeight();
            }
        }

        public GdkScreen()
        {
            handle = NativeGdkScreen.gdk_screen_get_default();
        }

        private int GetWidth()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeGdkScreen.gdk_screen_get_width(handle);
        }

        private int GetHeight()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeGdkScreen.gdk_screen_get_height(handle);
        }        
    }
}