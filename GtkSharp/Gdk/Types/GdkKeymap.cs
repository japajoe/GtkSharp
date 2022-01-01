using GtkSharp.Gdk.Native;
using GtkSharp.GLib.Types;

namespace GtkSharp.Gdk.Types
{
    public class GdkKeymap : GObject
    {
        public GdkKeymap()
        {
            handle = NativeGdkKeys.gdk_keymap_get_default();
        }

        public GdkKeymap(GdkDisplay display)
        {
            handle = NativeGdkKeys.gdk_keymap_get_for_display(display.Handle);
        }

        public GdkKeymapKey[] GetEntriesForKeyVal(uint keyval)
        {
            if(NativeGdkKeys.gdk_keymap_get_entries_for_keyval(handle, keyval, out GdkKeymapKey[] keymap))
            {
                return keymap;
            }

            return null;
        }
    }
}