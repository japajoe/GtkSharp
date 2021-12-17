using GtkSharp.Gdk.Native.Types;
using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkScreen : GObject
    {
        internal GdkScreenPointer handle;

        public GdkScreen()
        {
            handle = NativeGdkScreen.gdk_screen_get_default();
        }
    }
}