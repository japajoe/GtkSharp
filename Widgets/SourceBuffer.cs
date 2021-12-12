using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class SourceBuffer : TextBufferBase
    {
        public SourceBuffer(GtkSourceBufferPointer buffer)
        {
            handle.pointer = buffer.pointer;
        }

        public SourceBuffer()
        {
            tagTable = new TextTagTable();
            GtkTextTagTablePointer t = tagTable.GetPointer();
            handle = NativeSourceBuffer.gtk_source_buffer_new(t);
        }

        public SourceBuffer(GtkSourceLanguagePointer language)
        {
            handle = NativeSourceBuffer.gtk_source_buffer_new_with_language(language);
        }
    }
}