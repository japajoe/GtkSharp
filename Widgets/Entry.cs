using System;
using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Entry : Widget
    {
        public event EntrySubmitEvent onSubmit;
        public event EntryChangedEvent onChanged;

        private GtkCallback onSubmitNative;
        private GtkEntryBufferDeletedCallback onDeletedNative;
        private GtkEntryBufferInsertedCallback onInsertedCallback;
        private GtkEntryBufferPointer buffer;
        private StringBuilder stringBuilder;
        private string text = string.Empty;

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

        public Entry()
        {
            stringBuilder = new StringBuilder(1024);

            Gtk.GtkSharpTextEntryCreate(out handle.pointer, out buffer.pointer);

            onSubmitNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnSubmit");
            onDeletedNative = GtkSharpDelegate.Create<GtkEntryBufferDeletedCallback>(this, "OnDeleted");
            onInsertedCallback = GtkSharpDelegate.Create<GtkEntryBufferInsertedCallback>(this, "OnInserted");

            Gtk.GtkSharpCallbackConnect(out handle.pointer, "submit", onSubmitNative, out handle.pointer);
            Gtk.GtkSharpEntryBufferDeletedCallbackConnect(out buffer.pointer, onDeletedNative);
            Gtk.GtkSharpEntryBufferInsertedCallbackConnect(out buffer.pointer, onInsertedCallback);
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
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }

            Gtk.GtkSharpTextEntryGetText(out handle.pointer, out buffer.pointer, stringBuilder);

            this.text = stringBuilder.ToString().Substring(0, (int)length);
            
            return this.text;
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpTextEntryClearText(out handle.pointer, out buffer.pointer);
            this.text = string.Empty;
        }

        private void OnSubmit(IntPtr widget, IntPtr data)
        {
            onSubmit?.Invoke();
        }

        private void OnDeleted(IntPtr textbuffer, uint position, uint n_chars, IntPtr data)
        {
            onChanged?.Invoke();
        }

        private void OnInserted(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}