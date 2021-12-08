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

        public bool ReadOnly
        {
            get
            {
                return GetReadOnly();
            }
            set
            {
                SetReadOnly(value);
            }
        }

        public TextView()
        {
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);
            
            NativeTextView.GtkSharpTextViewCreate(out handle);
            NativeTextView.GtkSharpTextViewGetBuffer(out handle, out buffer);

            onChangedNative = OnChanged;

            Gtk.GtkSharpSignalConnect(out buffer.pointer, "changed", onChangedNative.ToIntPtr(), out handle.pointer);
        }

        public void SetText(string text)
        {
            if(buffer.IsNullPointer)
                return;

            NativeTextBuffer.GtkSharpTextBufferSetText(out buffer, text, text.Length);
            
            this.text = text;
        }

        public string GetText()
        {
            if(buffer.IsNullPointer)
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
            if(buffer.IsNullPointer)
                return;

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;

            NativeTextBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeTextBuffer.GtkSharpTextBufferDelete(out buffer, out iterStart, out iterEnd);
            NativeTextBuffer.GtkSharpTextIterFree(out iterStart);
            NativeTextBuffer.GtkSharpTextIterFree(out iterEnd);             

            this.text = string.Empty;
        }

        public bool GetReadOnly()
        {
            if(handle.IsNullPointer)
                return false;
            
            bool readOnly;
            NativeTextView.GtkSharpTextViewGetEditable(out handle, out readOnly);
            
            //Invert value because true means 'editable' which means readonly is false
            return !readOnly;
        }

        public void SetReadOnly(bool readOnly)
        {
            if(handle.IsNullPointer)
                return;

            //Invert value because true means 'editable' which means readonly is false
            NativeTextView.GtkSharpTextViewSetEditable(out handle, !readOnly);
        }        

        private void OnChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}