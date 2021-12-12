using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
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