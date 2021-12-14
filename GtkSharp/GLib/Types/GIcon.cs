using GtkSharp.Glib.Native.Types;

namespace GtkSharp.GLib.Types
{
    public class GIcon : GObject
    {
        internal GIconPointer handle;

        public GIcon()
        {
            handle = new GIconPointer();
        }
    }
}