using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
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