using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkTextBuffer : GtkTextBufferBase
    {
        public GtkTextBuffer(GtkTextBufferPointer buffer)
        {
            this.handle.pointer = buffer.pointer;
        }

        public GtkTextBuffer()
        {
            tagTable = new GtkTextTagTable();
            GtkTextTagTablePointer t = tagTable.GetPointer();
            handle = NativeTextBuffer.gtk_text_buffer_new(t);
        }
    }
}