using GtkSharp.Gdk.Native.Types;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkPixbuf : GObject
    {
        internal GdkPixbufPointer handle;

        internal GdkPixbuf(GdkPixbufPointer handle)
        {
            this.handle = handle;
        }
    }
}