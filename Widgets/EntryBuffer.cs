using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
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