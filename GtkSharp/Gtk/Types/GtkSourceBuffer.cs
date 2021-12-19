using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Types
{
    public class GtkSourceBuffer : GtkTextBufferBase
    {
        public GtkSourceBuffer(GtkSourceBufferPointer buffer)
        {
            handle.pointer = buffer.pointer;
        }

        public GtkSourceBuffer()
        {
            tagTable = new GtkTextTagTable();
            GtkTextTagTablePointer t = tagTable.GetPointer();
            handle = NativeSourceBuffer.gtk_source_buffer_new(t);
        }

        public GtkSourceBuffer(GtkSourceLanguagePointer language)
        {
            handle = NativeSourceBuffer.gtk_source_buffer_new_with_language(language);
        }
    }
}