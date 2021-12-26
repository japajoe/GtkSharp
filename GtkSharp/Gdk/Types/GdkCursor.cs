using GtkSharp.Gdk.Native;
using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkCursor : GObject
    {
        public GdkCursor(GdkCursorType type)
        {
            handle = NativeGdkCursor.gdk_cursor_new(type);
        }
    }
}