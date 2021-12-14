using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class TextBuffer : TextBufferBase
    {
        public TextBuffer(GtkTextBufferPointer buffer)
        {
            this.handle.pointer = buffer.pointer;
        }

        public TextBuffer()
        {
            tagTable = new TextTagTable();
            GtkTextTagTablePointer t = tagTable.GetPointer();
            handle = NativeTextBuffer.gtk_text_buffer_new(t);
        }
    }
}