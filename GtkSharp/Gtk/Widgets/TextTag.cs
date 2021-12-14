using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class TextTag : Widget
    {
        public TextTag(string text)
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