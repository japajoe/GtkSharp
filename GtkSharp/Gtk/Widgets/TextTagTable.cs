using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class TextTagTable : Widget
    {
        public TextTagTable()
        {
            handle = NativeTextTagTable.gtk_text_tag_table_new();
        }

        public GtkTextTagTablePointer GetPointer()
        {
            GtkTextTagTablePointer p = new GtkTextTagTablePointer();
            p.pointer = handle.pointer;
            return p;
        }
    }
}