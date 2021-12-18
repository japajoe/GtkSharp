using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    public abstract class Editable : Widget
    {
        private GEventHandler<EditableChangedCallback,EditableChangedEvent> changedHandler = new GEventHandler<EditableChangedCallback, EditableChangedEvent>();
        private GEventHandler<EditableDeleteTextCallback,EditableDeleteTextEvent> deleteTextHandler = new GEventHandler<EditableDeleteTextCallback, EditableDeleteTextEvent>();
        private GEventHandler<EditableInsertTextCallback,EditableInsertTextEvent> insertTextHandler = new GEventHandler<EditableInsertTextCallback, EditableInsertTextEvent>();

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

        public EditableDeleteTextEvent DeleteText 
        { 
            get
            {
                return deleteTextHandler.Event;
            }
            set
            {
                deleteTextHandler.Event = value;
                deleteTextHandler.SignalConnect(handle.pointer, "delete-text", OnDeleteText, handle.pointer);
            }        
        }
        
        public EditableInsertTextEvent InsertText 
        { 
            get
            {
                return insertTextHandler.Event;
            }
            set
            {
                insertTextHandler.Event = value;
                insertTextHandler.SignalConnect(handle.pointer, "insert-text", OnInsertText, handle.pointer);
            }
        }

        protected virtual void OnChanged(IntPtr widget, IntPtr data)
        {
            Changed?.Invoke();
        }

        protected virtual void OnDeleteText(IntPtr widget, int startPos, int endPos, IntPtr data)
        {
            DeleteText?.Invoke(startPos, endPos);
        }

        protected virtual void OnInsertText(IntPtr widget, IntPtr newText, int textLength, ref int newPosition, IntPtr data)
        {
            if(InsertText != null)
            {
                string text = MarshalHelper.MarshalPtrToString(newText);
                InsertText.Invoke(text, textLength, ref newPosition);
            }
        }      
    }
}