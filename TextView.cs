using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public class TextView : Widget
    {
        private GtkTextBufferPointer buffer;
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

        public TextView()
        {
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);
            Gtk.GtkSharpTextViewCreate(out handle.pointer, out buffer.pointer);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpTextViewSetText(out handle.pointer, out buffer.pointer, text);
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            uint length = 0;
            Gtk.GtkSharpTextBufferGetLength(out buffer.pointer, out length);

            if(length > stringBuilder.Capacity)
                stringBuilder.EnsureCapacity((int)length);

            Gtk.GtkSharpTextViewGetText(out handle.pointer, out buffer.pointer, stringBuilder);            
            
            text = stringBuilder.ToString().Substring(0, (int)length);
            
            return text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpTextViewClearText(out handle.pointer, out buffer.pointer);
            this.text = string.Empty;
        }
    }
}