using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Entry : Widget
    {
        private event EntryActivateEvent onActivateCallback;
        private event EntryBackspaceEvent onBackspaceCallback;
        private event EntryCopyClipboardEvent onCopyClipboardCallback;
        private event EntryCutClipboardEvent onCutClipboardCallback;
        private event EntryDeleteFromCursorEvent onDeleteFromCursorCallback;
        private event EntryIconPressEvent onIconPressCallback;
        private event EntryIconReleaseEvent onIconReleaseCallback;
        private event EntryInsertAtCursorEvent onInsertAtCursorCallback;
        private event EntryInsertEmojiEvent onInsertEmojiCallback;
        private event EntryMoveCursorEvent onMoveCursorCallback;
        private event EntryPasteClipboardEvent onPasteClipboardCallback;
        private event EntryPopulatePopupEvent onPopulatePopupCallback;
        private event EntryBufferDeletedEvent onDeletedCallback;
        private event EntryBufferInsertedEvent onInsertedCallback;
        private event EntryChangedEvent onChangedCallback;

        private GtkEntryActivateCallback onEntryActivate;
        private GtkEntryBackspaceCallback onEntryBackspace;
        private GtkEntryCopyClipboardCallback onEntryCopyClipboard;
        private GtkEntryCutClipboardCallback onEntryCutClipboard;
        private GtkEntryDeleteFromCursorCallback onEntryDeleteFromCursor;
        private GtkEntryIconPressCallback onEntryIconPress;
        private GtkEntryIconReleaseCallback onEntryIconRelease;
        private GtkEntryInsertAtCursorCallback onEntryInsertAtCursor;
        private GtkEntryInsertEmojiCallback onEntryInsertEmoji;
        private GtkEntryMoveCursorCallback onEntryMoveCursor;
        private GtkEntryPasteClipboardCallback onEntryPasteClipboard;
        private GtkEntryPopulatePopupCallback onEntryPopulatePopup;
        private GtkEntryBufferDeletedCallback onEntryBufferDeleted;
        private GtkEntryBufferInsertedCallback onEntryBufferInserted;
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
                return onActivateCallback;
            }
            set
            {
                onActivateCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryActivate.IsNullPointer())
                    {
                        onEntryActivate = OnActivate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onEntryActivate.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryBackspaceEvent onBackspace
        {
            get
            {
                return onBackspaceCallback;
            }
            set
            {
                onBackspaceCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryBackspace.IsNullPointer())
                    {
                        onEntryBackspace = OnBackspace;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "backspace", onEntryBackspace.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardCallback;
            }
            set
            {
                onCopyClipboardCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryCopyClipboard.IsNullPointer())
                    {
                        onEntryCopyClipboard = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onEntryCopyClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryCutClipboardEvent onCutClipboard
        {
            get
            {
                return onCutClipboardCallback;
            }
            set
            {
                onCutClipboardCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryCutClipboard.IsNullPointer())
                    {
                        onEntryCutClipboard = OnCutClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "cut-clipboard", onEntryCutClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryDeleteFromCursorEvent onDeleteFromCursor
        {
            get
            {
                return onDeleteFromCursorCallback;
            }
            set
            {
                onDeleteFromCursorCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryDeleteFromCursor.IsNullPointer())
                    {
                        onEntryDeleteFromCursor = OnDeleteFromCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "delete-from-cursor", onEntryDeleteFromCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryIconPressEvent onIconPress
        {
            get
            {
                return onIconPressCallback;
            }
            set
            {
                onIconPressCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryIconPress.IsNullPointer())
                    {
                        onEntryIconPress = OnIconPress;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-press", onEntryIconPress.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryIconReleaseEvent onIconRelease
        {
            get
            {
                return onIconReleaseCallback;
            }
            set
            {
                onIconReleaseCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryIconRelease.IsNullPointer())
                    {
                        onEntryIconRelease = OnIconRelease;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-release", onEntryIconRelease.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryInsertAtCursorEvent onInsertAtCursor
        {
            get
            {
                return onInsertAtCursorCallback;
            }
            set
            {
                onInsertAtCursorCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryInsertAtCursor.IsNullPointer())
                    {
                        onEntryInsertAtCursor = OnInsertAtCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-at-cursor", onEntryInsertAtCursor.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }
        
        public EntryInsertEmojiEvent onInsertEmoji
        {
            get
            {
                return onInsertEmojiCallback;
            }
            set
            {
                onInsertEmojiCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryInsertEmoji.IsNullPointer())
                    {
                        onEntryInsertEmoji = OnInsertEmoji;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-emoji", onEntryInsertEmoji.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }
        
        public EntryMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorCallback;
            }
            set
            {
                onMoveCursorCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryMoveCursor.IsNullPointer())
                    {
                        onEntryMoveCursor = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onEntryMoveCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryPasteClipboardEvent onPasteClipboard
        {
            get
            {
                return onPasteClipboardCallback;
            }
            set
            {
                onPasteClipboardCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryPasteClipboard.IsNullPointer())
                    {
                        onEntryPasteClipboard = OnPasteClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "paste-clipboard", onEntryPasteClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }
        
        public EntryPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupCallback;
            }
            set
            {
                onPopulatePopupCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onEntryPopulatePopup.IsNullPointer())
                    {
                        onEntryPopulatePopup = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onEntryPopulatePopup.ToIntPtr(), out handle.pointer);            
                    }
                }
            }
        }

        public EntryBufferDeletedEvent onDeleted
        {
            get
            {
                return onDeletedCallback;
            }
            set
            {
                onDeletedCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onEntryBufferDeleted.IsNullPointer())
                    {
                        onEntryBufferDeleted = OnDeleted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "deleted-text", onEntryBufferDeleted.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }

        public EntryBufferInsertedEvent onInserted
        {
            get
            {
                return onInsertedCallback;
            }
            set
            {
                onInsertedCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onEntryBufferInserted.IsNullPointer())
                    {
                        onEntryBufferInserted = OnInserted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "inserted-text", onEntryBufferInserted.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }

        public EntryChangedEvent onChanged
        {
            get
            {
                return onChangedCallback;
            }
            set
            {
                onChangedCallback = value;
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