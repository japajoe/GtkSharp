using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class TextView : Widget
    {
        public event TextViewChangedEvent onChanged;

        private GtkTextBufferChangedCallback onChangedNative;
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
                SetText(value);            
            }
        }

        public TextView()
        {
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);
            
            NativeTextView.GtkSharpTextViewCreate(out handle);
            NativeTextView.GtkSharpTextViewGetBuffer(out handle, out buffer);

            onChangedNative = GtkSharpDelegate.Create<GtkTextBufferChangedCallback>(this, "OnChanged");

            Gtk.GtkSharpTextBufferChangedCallbackConnect(out buffer.pointer, onChangedNative);            
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeTextBuffer.GtkSharpTextBufferSetText(out buffer, text, text.Length);
            
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            int length = 0;

            NativeTextBuffer.GtkSharpTextBufferGetCharCount(out buffer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;
            
            NativeTextBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeTextBuffer.GtkSharpTextBufferGetText(out buffer, out iterStart, out iterEnd, true, stringBuilder);
            NativeTextBuffer.GtkSharpTextIterFree(out iterStart);
            NativeTextBuffer.GtkSharpTextIterFree(out iterEnd);            
            
            text = stringBuilder.ToString().Substring(0, length);
            
            return text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;

            NativeTextBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeTextBuffer.GtkSharpTextBufferDelete(out buffer, out iterStart, out iterEnd);
            NativeTextBuffer.GtkSharpTextIterFree(out iterStart);
            NativeTextBuffer.GtkSharpTextIterFree(out iterEnd);             

            this.text = string.Empty;
        }

        public void SetReadOnly(bool readOnly)
        {
            if(handle.IsNullPointer)
                return;
        }        

        private void OnChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}