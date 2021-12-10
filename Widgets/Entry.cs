using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Entry : Widget
    {
        private event EntryActivateEvent onActivateEvent;
        private event EntryBackspaceEvent onBackspaceEvent;
        private event EntryCopyClipboardEvent onCopyClipboardEvent;
        private event EntryCutClipboardEvent onCutClipboardEvent;
        private event EntryDeleteFromCursorEvent onDeleteFromCursorEvent;
        private event EntryIconPressEvent onIconPressEvent;
        private event EntryIconReleaseEvent onIconReleaseEvent;
        private event EntryInsertAtCursorEvent onInsertAtCursorEvent;
        private event EntryInsertEmojiEvent onInsertEmojiEvent;
        private event EntryMoveCursorEvent onMoveCursorEvent;
        private event EntryPasteClipboardEvent onPasteClipboardEvent;
        private event EntryPopulatePopupEvent onPopulatePopupEvent;
        private event EntryBufferDeletedEvent onDeletedEvent;
        private event EntryBufferInsertedEvent onInsertedEvent;
        private event EntryChangedEvent onChangedEvent;

        private GtkEntryActivateCallback onEntryActivateCallback;
        private GtkEntryBackspaceCallback onEntryBackspaceCallback;
        private GtkEntryCopyClipboardCallback onEntryCopyClipboardCallback;
        private GtkEntryCutClipboardCallback onEntryCutClipboardCallback;
        private GtkEntryDeleteFromCursorCallback onEntryDeleteFromCursorCallback;
        private GtkEntryIconPressCallback onEntryIconPressCallback;
        private GtkEntryIconReleaseCallback onEntryIconReleaseCallback;
        private GtkEntryInsertAtCursorCallback onEntryInsertAtCursorCallback;
        private GtkEntryInsertEmojiCallback onEntryInsertEmojiCallback;
        private GtkEntryMoveCursorCallback onEntryMoveCursorCallback;
        private GtkEntryPasteClipboardCallback onEntryPasteClipboardCallback;
        private GtkEntryPopulatePopupCallback onEntryPopulatePopupCallback;
        private GtkEntryBufferDeletedCallback onEntryBufferDeletedCallback;
        private GtkEntryBufferInsertedCallback onEntryBufferInsertedCallback;
        
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

        public EntryActivateEvent onActivate
        {
            get
            {
                return onActivateEvent;
            }
            set
            {
                onActivateEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryActivateCallback.IsNullPointer())
                    {
                        onEntryActivateCallback = OnActivate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onEntryActivateCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryBackspaceEvent onBackspace
        {
            get
            {
                return onBackspaceEvent;
            }
            set
            {
                onBackspaceEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryBackspaceCallback.IsNullPointer())
                    {
                        onEntryBackspaceCallback = OnBackspace;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "backspace", onEntryBackspaceCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardEvent;
            }
            set
            {
                onCopyClipboardEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryCopyClipboardCallback.IsNullPointer())
                    {
                        onEntryCopyClipboardCallback = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onEntryCopyClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryCutClipboardEvent onCutClipboard
        {
            get
            {
                return onCutClipboardEvent;
            }
            set
            {
                onCutClipboardEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryCutClipboardCallback.IsNullPointer())
                    {
                        onEntryCutClipboardCallback = OnCutClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "cut-clipboard", onEntryCutClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryDeleteFromCursorEvent onDeleteFromCursor
        {
            get
            {
                return onDeleteFromCursorEvent;
            }
            set
            {
                onDeleteFromCursorEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryDeleteFromCursorCallback.IsNullPointer())
                    {
                        onEntryDeleteFromCursorCallback = OnDeleteFromCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "delete-from-cursor", onEntryDeleteFromCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryIconPressEvent onIconPress
        {
            get
            {
                return onIconPressEvent;
            }
            set
            {
                onIconPressEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryIconPressCallback.IsNullPointer())
                    {
                        onEntryIconPressCallback = OnIconPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-press", onEntryIconPressCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryIconReleaseEvent onIconRelease
        {
            get
            {
                return onIconReleaseEvent;
            }
            set
            {
                onIconReleaseEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryIconReleaseCallback.IsNullPointer())
                    {
                        onEntryIconReleaseCallback = OnIconRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-release", onEntryIconReleaseCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryInsertAtCursorEvent onInsertAtCursor
        {
            get
            {
                return onInsertAtCursorEvent;
            }
            set
            {
                onInsertAtCursorEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryInsertAtCursorCallback.IsNullPointer())
                    {
                        onEntryInsertAtCursorCallback = OnInsertAtCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-at-cursor", onEntryInsertAtCursorCallback.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }
        
        public EntryInsertEmojiEvent onInsertEmoji
        {
            get
            {
                return onInsertEmojiEvent;
            }
            set
            {
                onInsertEmojiEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryInsertEmojiCallback.IsNullPointer())
                    {
                        onEntryInsertEmojiCallback = OnInsertEmoji;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-emoji", onEntryInsertEmojiCallback.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }
        
        public EntryMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorEvent;
            }
            set
            {
                onMoveCursorEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryMoveCursorCallback.IsNullPointer())
                    {
                        onEntryMoveCursorCallback = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onEntryMoveCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryPasteClipboardEvent onPasteClipboard
        {
            get
            {
                return onPasteClipboardEvent;
            }
            set
            {
                onPasteClipboardEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryPasteClipboardCallback.IsNullPointer())
                    {
                        onEntryPasteClipboardCallback = OnPasteClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "paste-clipboard", onEntryPasteClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupEvent;
            }
            set
            {
                onPopulatePopupEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryPopulatePopupCallback.IsNullPointer())
                    {
                        onEntryPopulatePopupCallback = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onEntryPopulatePopupCallback.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }

        public EntryBufferDeletedEvent onDeleted
        {
            get
            {
                return onDeletedEvent;
            }
            set
            {
                onDeletedEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onEntryBufferDeletedCallback.IsNullPointer())
                    {
                        onEntryBufferDeletedCallback = OnDeleted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "deleted-text", onEntryBufferDeletedCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }

        public EntryBufferInsertedEvent onInserted
        {
            get
            {
                return onInsertedEvent;
            }
            set
            {
                onInsertedEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onEntryBufferInsertedCallback.IsNullPointer())
                    {
                        onEntryBufferInsertedCallback = OnInserted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "inserted-text", onEntryBufferInsertedCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }

        public EntryChangedEvent onChanged
        {
            get
            {
                return onChangedEvent;
            }
            set
            {
                onChangedEvent = value;
            }
        }

        public Entry()
        {
            stringBuilder = new StringBuilder(1024);

            NativeEntry.GtkSharpEntryCreate(out handle);
            NativeEntry.GtkSharpEntryGetBuffer(out handle, out buffer);
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

        void OnActivate(IntPtr widget, IntPtr data)
        {
            onActivate?.Invoke();
        }

        void OnBackspace(IntPtr widget, IntPtr data)
        {
            onBackspace?.Invoke();
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            onCopyClipboard?.Invoke();
        }

        void OnCutClipboard(IntPtr widget, IntPtr data)
        {
            onCutClipboard?.Invoke();
        }

        void OnDeleteFromCursor(IntPtr widget, GtkDeleteType type, int count, IntPtr data)
        {
            onDeleteFromCursor?.Invoke(type, count);
        }

        void OnIconPress(IntPtr widget, GtkEntryIconPosition position, IntPtr gdkEvent, IntPtr data)
        {
            GdkEventPointer e;
            e.pointer = gdkEvent;
            onIconPress?.Invoke(position, e);
        }

        void OnIconRelease(IntPtr widget, GtkEntryIconPosition position, IntPtr gdkEvent, IntPtr data)
        {
            GdkEventPointer e;
            e.pointer = gdkEvent;
            onIconRelease?.Invoke(position, e);
        }

        void OnInsertAtCursor(IntPtr widget, IntPtr text, IntPtr data)
        {
            string t = MarshalHelper.MarshalPtrToString(text);
            onInsertAtCursor?.Invoke(t);
        }

        void OnInsertEmoji(IntPtr widget, IntPtr data)
        {
            onInsertEmoji?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            onMoveCursor?.Invoke(step, count, extendSelection);
        }

        void OnPasteClipboard(IntPtr widget, IntPtr data)
        {
            onPasteClipboard?.Invoke();
        }

        void OnPopulatePopup(IntPtr widget, IntPtr data)
        {
            onPopulatePopup?.Invoke();
        }        

        private void OnDeleted(IntPtr textbuffer, uint position, uint n_chars, IntPtr data)
        {
            onDeleted?.Invoke(position, n_chars);
            onChanged?.Invoke();
        }

        private void OnInserted(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data)
        {
            if(onInserted != null)
            {
                string text = MarshalHelper.MarshalPtrToString(chars);
                onInserted(position, text, n_chars);
            }
            
            onChanged?.Invoke();
        }
    }
}