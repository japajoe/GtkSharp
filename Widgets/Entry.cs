using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Entry : Widget
    {
        private EntryBuffer buffer;
        private string text;

        public string Text
        {
            get
            {
                return GetText();
            }
            set
            {
                text = value;
                SetText(text);
            }
        }
        
        public Entry()
        {            
            handle = NativeEntry.gtk_entry_new();
            GtkEntryBufferPointer bufferPointer = NativeEntry.gtk_entry_get_buffer(handle);
            buffer = new EntryBuffer(bufferPointer);
        }

        public Entry(EntryBuffer buffer)
        {
            this.buffer = buffer;
            handle = NativeEntry.gtk_entry_new_with_buffer(buffer.handle);
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;
            if(buffer.handle.IsNullPointer)
                return string.Empty;

            text = NativeEntry.gtk_entry_get_text(handle);
            
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;
            if(buffer.handle.IsNullPointer)
                return;

            NativeEntry.gtk_entry_set_text(buffer.handle, text);
        }
    }
}