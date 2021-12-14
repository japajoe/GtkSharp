using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class EntryBuffer : Widget
    {
        public EntryBuffer(GtkEntryBufferPointer buffer)
        {
            this.handle.pointer = buffer.pointer;
        }

        public EntryBuffer()
        {
            handle = NativeEntryBuffer.gtk_entry_buffer_new(null, -1);
        }
    }
}