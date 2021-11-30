using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Entry : Widget
    {
        private GtkEntryBufferPointer buffer;
        private StringBuilder stringBuilder;
        private string text;

        public string Text
        {
            get
            {
                return GetText();
            }
            set
            {
                SetText(text);            
            }
        }

        public Entry()
        {
            this.stringBuilder = new StringBuilder(1024);
            this.text = string.Empty;
            Gtk.GtkSharpTextEntryCreate(out handle.pointer, out buffer.pointer);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpTextEntrySetText(out handle.pointer, out buffer.pointer, text);
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            stringBuilder.Clear();

            uint length = 0;
            Gtk.GtkSharpEntryBufferGetLength(out buffer.pointer, out length);

            if(length > stringBuilder.Capacity)
                stringBuilder.EnsureCapacity((int)length);

            Gtk.GtkSharpTextEntryGetText(out handle.pointer, out buffer.pointer, stringBuilder);

            text = stringBuilder.ToString().Substring(0, (int)length);
            
            return this.text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpTextEntryClearText(out handle.pointer, out buffer.pointer);
            this.text = string.Empty;
        }
    }
}