using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Entry : Widget, IEditable
    {
        private EntryBuffer buffer;
        private string text;

        private GEventHandler<EntryActivateCallback,EntryActivateEvent> activateHandler = new GEventHandler<EntryActivateCallback, EntryActivateEvent>();
        private GEventHandler<EditableChangedCallback,EditableChangedEvent> changedHandler = new GEventHandler<EditableChangedCallback, EditableChangedEvent>();

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

        public EntryBuffer Buffer
        {
            get
            {
                return buffer;
            }
        }

        public EntryActivateEvent Activate
        {
            get
            {
                return activateHandler.Event;
            }
            set
            {
                activateHandler.Event = value;
                activateHandler.SignalConnect(handle.pointer, "activate", OnActivate, handle.pointer);
            }
        }

        public EditableChangedEvent Changed
        {
            get
            {
                return changedHandler.Event;
            }
            set
            {
                changedHandler.Event = value;
                changedHandler.SignalConnect(handle.pointer, "changed", OnChanged, handle.pointer);
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

            text = NativeEntry.gtk_entry_get_text(handle);
            
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeEntry.gtk_entry_set_text(handle, text);
        }

        void OnActivate(IntPtr widget, IntPtr data)
        {
            Activate?.Invoke();
        }

        void OnChanged(IntPtr widget, IntPtr data)
        {
            Changed?.Invoke();
        }
    }
}