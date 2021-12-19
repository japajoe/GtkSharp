using GtkSharp.Glib.Native.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkTextTagTable : GObject
    {
        internal GObjectPointer handle;
        
        public GtkTextTagTable()
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