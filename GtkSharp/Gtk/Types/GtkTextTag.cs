using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkTextTag : GObject
    {        
        public GtkTextTag(string text)
        {
            handle = NativeTextTag.gtk_text_tag_new(text);
        }

        public GtkTextTagPointer GetPointer()
        {
            GtkTextTagPointer p = new GtkTextTagPointer();
            p.pointer = handle.pointer;
            return p;
        }
    }
}