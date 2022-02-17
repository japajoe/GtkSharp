using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    public class EntryBuffer : Widget
    {
        private GEventHandler<EntryBufferDeletedTextCallback,EntryBufferDeletedTextEvent> deletedTextHandler = new GEventHandler<EntryBufferDeletedTextCallback, EntryBufferDeletedTextEvent>();
        private GEventHandler<EntryBufferInsertedTextCallback,EntryBufferInsertedTextEvent> insertedTextHandler = new GEventHandler<EntryBufferInsertedTextCallback, EntryBufferInsertedTextEvent>();

        public EntryBufferDeletedTextEvent DeletedText
        {
            get
            {
                return deletedTextHandler.Event;
            }
            set
            {
                deletedTextHandler.Event = value;
                deletedTextHandler.SignalConnect(handle.pointer, "deleted-text", OnDeletedText, handle.pointer);
            }
        }

        public EntryBufferInsertedTextEvent InsertedText
        {
            get
            {
                return insertedTextHandler.Event;
            }
            set
            {
                insertedTextHandler.Event = value;
                insertedTextHandler.SignalConnect(handle.pointer, "inserted-text", OnInsertedText, handle.pointer);
            }
        }
                
        public EntryBuffer(GtkEntryBufferPointer buffer)
        {
            this.handle.pointer = buffer.pointer;
        }

        public EntryBuffer()
        {
            handle = NativeEntryBuffer.gtk_entry_buffer_new(string.Empty, -1);
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;
            
            return NativeEntryBuffer.gtk_entry_buffer_get_text(handle);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeEntryBuffer.gtk_entry_buffer_set_text(handle, text, text.Length);
        }

        void OnDeletedText(IntPtr widget, uint position, uint n_chars, IntPtr data)
        {
            DeletedText?.Invoke(position, n_chars);
        }

        void OnInsertedText(IntPtr widget, uint position, IntPtr chars, uint n_chars, IntPtr data)
        {
            if(InsertedText != null)
            {
                string s = MarshalHelper.MarshalPtrToString(chars);
                InsertedText?.Invoke(position, s, n_chars);
            }
        }
    }
}