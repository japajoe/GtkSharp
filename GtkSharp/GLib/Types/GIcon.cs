using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    public class GIcon : GObject
    {
        public GIcon()
        {
            handle = new GObjectPointer();
        }
    }
}