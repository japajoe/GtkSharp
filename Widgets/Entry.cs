using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

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

            NativeEntry.GtkSharpEntryCreate(out handle);
            NativeEntry.GtkSharpEntryGetBuffer(out handle, out buffer);

            onSubmitNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnSubmit");
            onDeletedNative = GtkSharpDelegate.Create<GtkEntryBufferDeletedCallback>(this, "OnDeleted");
            onInsertedCallback = GtkSharpDelegate.Create<GtkEntryBufferInsertedCallback>(this, "OnInserted");

            Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onSubmitNative.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out buffer.pointer, "deleted-text", onDeletedNative.ToIntPtr(), out buffer.pointer);
            Gtk.GtkSharpSignalConnect(out buffer.pointer, "inserted-text", onInsertedCallback.ToIntPtr(), out buffer.pointer);
        }

        public void SetText(string text)
        {
            if(buffer.IsNullPointer)
                return;                

            NativeEntryBuffer.GtkSharpEntryBufferSetText(out buffer, text, -1);
            this.text = text;
        }

        public string GetText()
        {
            if(buffer.IsNullPointer)
                return string.Empty;

            stringBuilder.Clear();

            int length = 0;            
            NativeEntryBuffer.GtkSharpEntryBufferGetTextLength(out buffer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }

            NativeEntryBuffer.GtkSharpEntryBufferGetText(out buffer, stringBuilder);

            this.text = stringBuilder.ToString().Substring(0, (int)length);
            
            return this.text;
        }

        public void Clear()
        {
            if(buffer.IsNullPointer)
                return;                

            uint newPosition;
            NativeEntryBuffer.GtkSharpEntryBufferDeleteText(out buffer, 0, -1, out newPosition);
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