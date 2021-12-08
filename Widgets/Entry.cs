using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Entry : Widget
    {
        public event EntryActivateEvent onActivate;
        public event EntryBackspaceEvent onBackspace;
        public event EntryCopyClipboardEvent onCopyClipboard;
        public event EntryCutClipboardEvent onCutClipboard;
        public event EntryDeleteFromCursorEvent onDeleteFromCursor;
        public event EntryIconPressEvent onIconPress;
        public event EntryIconReleaseEvent onIconRelease;
        public event EntryInsertAtCursorEvent onInsertAtCursor;
        public event EntryInsertEmojiEvent onInsertEmoji;
        public event EntryMoveCursorEvent onMoveCursor;
        public event EntryPasteClipboardEvent onPasteClipboard;
        public event EntryPopulatePopupEvent onPopulatePopup;
        public event EntryChangedEvent onChanged;

        private GtkEntryActivateCallback onActivateCallback;
        private GtkEntryBackspaceCallback onBackspaceCallback;
        private GtkEntryCopyClipboardCallback onCopyClipboardCallback;
        private GtkEntryCutClipboardCallback onCutClipboardCallback;
        private GtkEntryDeleteFromCursorCallback onDeleteFromCursorCallback;
        private GtkEntryIconPressCallback onIconPressCallback;
        private GtkEntryIconReleaseCallback onIconReleaseCallback;
        private GtkEntryInsertAtCursorCallback onInsertAtCursorCallback;
        private GtkEntryInsertEmojiCallback onInsertEmojiCallback;
        private GtkEntryMoveCursorCallback onMoveCursorCallback;
        private GtkEntryPasteClipboardCallback onPasteClipboardCallback;
        private GtkEntryPopulatePopupCallback onPopulatePopupCallback;
        private GtkEntryBufferDeletedCallback onBufferDeletedCallback;
        private GtkEntryBufferInsertedCallback onBufferInsertedCallback;
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

            onActivateCallback = OnActivate;
            onBackspaceCallback = OnBackspace;
            onCopyClipboardCallback = OnCopyClipboard;
            onCutClipboardCallback = OnCutClipboard;
            onDeleteFromCursorCallback = OnDeleteFromCursor;
            onIconPressCallback = OnIconPress;
            onIconReleaseCallback = OnIconRelease;
            onInsertAtCursorCallback = OnInsertAtCursor;
            onInsertEmojiCallback = OnInsertEmoji;
            onMoveCursorCallback = OnMoveCursor;
            onPasteClipboardCallback = OnPasteClipboard;
            onPopulatePopupCallback = OnPopulatePopup;
            onBufferDeletedCallback = OnDeleted;
            onBufferInsertedCallback = OnInserted;

            Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onActivateCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "backspace", onBackspaceCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onCopyClipboardCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "cut-clipboard", onCutClipboardCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "delete-from-cursor", onDeleteFromCursorCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-press", onIconPressCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "icon-release", onIconReleaseCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-at-cursor", onInsertAtCursorCallback.ToIntPtr(), out handle.pointer);
            
            
            if(GtkVersion.IsSupportedFeature(3, 22, 27))
            {
                //Only available as of 3.22.27
                Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-emoji", onInsertEmojiCallback.ToIntPtr(), out handle.pointer);
            }
            
            Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onMoveCursorCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "paste-clipboard", onPasteClipboardCallback.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onPopulatePopupCallback.ToIntPtr(), out handle.pointer);            
            Gtk.GtkSharpSignalConnect(out buffer.pointer, "deleted-text", onBufferDeletedCallback.ToIntPtr(), out buffer.pointer);
            Gtk.GtkSharpSignalConnect(out buffer.pointer, "inserted-text", onBufferInsertedCallback.ToIntPtr(), out buffer.pointer);
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
            onChanged?.Invoke();
        }

        private void OnInserted(IntPtr textbuffer, uint position, IntPtr chars, uint n_chars, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}