using System;
using System.Text;
using System.Runtime.InteropServices;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class TextView : Widget
    {
        private event TextViewBackspaceEvent onBackspaceEvent;
        private event TextViewCopyClipboardEvent onCopyClipboardEvent;
        private event TextViewCutClipboardEvent onCutClipboardEvent;
        private event TextViewDeleteFromCursorEvent onDeleteFromCursorEvent;
        private event TextViewExtendSelectionEvent onExtendSelectionEvent;
        private event TextViewInsertAtCursorEvent onInsertAtCursorEvent;
        private event TextViewInsertEmojiEvent onInsertEmojiEvent;
        private event TextViewMoveCursorEvent onMoveCursorEvent;
        private event TextViewMoveViewportEvent onMoveViewportEvent;
        private event TextViewPasteClipboardEvent onPasteClipboardEvent;
        private event TextViewPopulatePopupEvent onPopulatePopupEvent;
        private event TextViewPreeditChangedEvent onPreeditChangedEvent;

        private event TextBufferApplyTagEvent onApplyTagEvent;
        private event TextBufferBeginUserActionEvent onBeginUserActionEvent;
        private event TextBufferChangedEvent onChangedEvent;
        private event TextBufferDeleteRangeEvent onDeleteRangeEvent;
        private event TextBufferEndUserActionEvent onEndUserActionEvent;
        private event TextBufferInsertChildAnchorEvent onInsertChildAnchorEvent;
        private event TextBufferInsertPixbufEvent onInsertPixbufEvent;
        private event TextBufferInsertTextEvent onInsertTextEvent;
        private event TextBufferMarkDeletedEvent onMarkDeletedEvent;
        private event TextBufferMarkSetEvent onMarkSetEvent;
        private event TextBufferModifiedChangedEvent onModifiedChangedEvent;
        private event TextBufferPasteDoneEvent onPasteDoneEvent;
        private event TextBufferRemoveTagEvent onRemoveTagEvent;

        private GtkTextViewBackspaceCallback onTextViewBackspaceCallback;
        private GtkTextViewCopyClipboardCallback onTextViewCopyClipboardCallback;
        private GtkTextViewCutClipboardCallback onTextViewCutClipboardCallback;
        private GtkTextViewDeleteFromCursorCallback onTextViewDeleteFromCursorCallback;
        private GtkTextViewExtendSelectionCallback onTextViewExtendSelectionCallback;
        private GtkTextViewInsertAtCursorCallback onTextViewInsertAtCursorCallback;
        private GtkTextViewInsertEmojiCallback onTextViewInsertEmojiCallback;
        private GtkTextViewMoveCursorCallback onTextViewMoveCursorCallback;
        private GtkTextViewMoveViewportCallback onTextViewMoveViewportCallback;
        private GtkTextViewPasteClipboardCallback onTextViewPasteClipboardCallback;
        private GtkTextViewPopulatePopupCallback onTextViewPopulatePopupCallback;
        private GtkTextViewPreeditChangedCallback onTextViewPreeditChangedCallback;

        private GtkTextBufferApplyTagCallback onTextBufferApplyTagCallback;
        private GtkTextBufferBeginUserActionCallback onTextBufferBeginUserActionCallback;
        private GtkTextBufferChangedCallback onTextBufferChangedCallback;
        private GtkTextBufferDeleteRangeCallback onTextBufferDeleteRangeCallback;
        private GtkTextBufferEndUserActionCallback onTextBufferEndUserActionCallback;
        private GtkTextBufferInsertChildAnchorCallback onTextBufferInsertChildAnchorCallback;
        private GtkTextBufferInsertPixbufCallback onTextBufferInsertPixbufCallback;
        private GtkTextBufferInsertTextCallback onTextBufferInsertTextCallback;
        private GtkTextBufferMarkDeletedCallback onTextBufferMarkDeletedCallback;
        private GtkTextBufferMarkSetCallback onTextBufferMarkSetCallback;
        private GtkTextBufferModifiedChangedCallback onTextBufferModifiedChangedCallback;
        private GtkTextBufferPasteDoneCallback onTextBufferPasteDoneCallback;
        private GtkTextBufferRemoveTagCallback onTextBufferRemoveTagCallback;

        private GtkTextBufferPointer buffer;
        private StringBuilder stringBuilder;
        private string text;


        public TextViewBackspaceEvent onBackspace
        {
            get
            {
                return onBackspaceEvent;
            }
            set
            {
                onBackspace = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewBackspaceCallback.IsNullPointer())
                    {
                        onTextViewBackspaceCallback = OnBackspace;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "backspace", onTextViewBackspaceCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardEvent;
            }
            set
            {
                onCopyClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewCopyClipboardCallback.IsNullPointer())
                    {
                        onTextViewCopyClipboardCallback = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onTextViewCopyClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewCutClipboardEvent onCutClipboard
        {
            get
            {
                return onCutClipboardEvent;
            }
            set
            {
                onCutClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewCutClipboardCallback.IsNullPointer())
                    {
                        onTextViewCutClipboardCallback = OnCutClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "cut-clipboard", onTextViewCutClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewDeleteFromCursorEvent onDeleteFromCursor
        {
            get
            {
                return onDeleteFromCursorEvent;
            }
            set
            {
                onDeleteFromCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewDeleteFromCursorCallback.IsNullPointer())
                    {
                        onTextViewDeleteFromCursorCallback = OnDeleteFromCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "delete-from-cursor", onTextViewDeleteFromCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewExtendSelectionEvent onExtendSelection
        {
            get
            {
                return onExtendSelectionEvent;
            }
            set
            {
                onExtendSelection = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewExtendSelectionCallback.IsNullPointer())
                    {
                        onTextViewExtendSelectionCallback = OnExtendSelection;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "extend-selection", onTextViewExtendSelectionCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewInsertAtCursorEvent onInsertAtCursor
        {
            get
            {
                return onInsertAtCursorEvent;
            }
            set
            {
                onInsertAtCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewInsertAtCursorCallback.IsNullPointer())
                    {
                        onTextViewInsertAtCursorCallback = OnInsertAtCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-at-cursor", onTextViewInsertAtCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewInsertEmojiEvent onInsertEmoji
        {
            get
            {
                return onInsertEmojiEvent;
            }
            set
            {
                onInsertEmoji = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewInsertEmojiCallback.IsNullPointer())
                    {
                        onTextViewInsertEmojiCallback = OnInsertEmoji;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-emoji", onTextViewInsertEmojiCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorEvent;
            }
            set
            {
                onMoveCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewMoveCursorCallback.IsNullPointer())
                    {
                        onTextViewMoveCursorCallback = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onTextViewMoveCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewMoveViewportEvent onMoveViewport
        {
            get
            {
                return onMoveViewportEvent;
            }
            set
            {
                onMoveViewport = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewMoveViewportCallback.IsNullPointer())
                    {
                        onTextViewMoveViewportCallback = OnMoveViewport;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-viewport", onTextViewMoveViewportCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPasteClipboardEvent onPasteClipboard
        {
            get
            {
                return onPasteClipboardEvent;
            }
            set
            {
                onPasteClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPasteClipboardCallback.IsNullPointer())
                    {
                        onTextViewPasteClipboardCallback = OnPasteClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "paste-clipboard", onTextViewPasteClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupEvent;
            }
            set
            {
                onPopulatePopup = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPopulatePopupCallback.IsNullPointer())
                    {
                        onTextViewPopulatePopupCallback = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onTextViewPopulatePopupCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPreeditChangedEvent onPreeditChanged
        {
            get
            {
                return onPreeditChangedEvent;
            }
            set
            {
                onPreeditChanged = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPreeditChangedCallback.IsNullPointer())
                    {
                        onTextViewPreeditChangedCallback = OnPreeditChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "preedit-changed", onTextViewPreeditChangedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextBufferApplyTagEvent onApplyTag
        {
            get
            {
                return onApplyTagEvent;
            }
            set
            {
                onApplyTagEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferApplyTagCallback.IsNullPointer())
                    {
                        onTextBufferApplyTagCallback = OnApplyTag;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "apply-tag", onTextBufferApplyTagCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferBeginUserActionEvent onBeginUserAction
        {
            get
            {
                return onBeginUserActionEvent;
            }
            set
            {
                onBeginUserActionEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferBeginUserActionCallback.IsNullPointer())
                    {
                        onTextBufferBeginUserActionCallback = OnBeginUserAction;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "begin-user-action", onTextBufferBeginUserActionCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferChangedEvent onChanged
        {
            get
            {
                return onChangedEvent;
            }
            set
            {
                onChangedEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferChangedCallback.IsNullPointer())
                    {
                        onTextBufferChangedCallback = OnChanged;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "changed", onTextBufferChangedCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferDeleteRangeEvent onDeleteRange
        {
            get
            {
                return onDeleteRangeEvent;
            }
            set
            {
                onDeleteRangeEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferDeleteRangeCallback.IsNullPointer())
                    {
                        onTextBufferDeleteRangeCallback = OnDeleteRange;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "delete-range", onTextBufferDeleteRangeCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferEndUserActionEvent onEndUserAction
        {
            get
            {
                return onEndUserActionEvent;
            }
            set
            {
                onEndUserActionEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferEndUserActionCallback.IsNullPointer())
                    {
                        onTextBufferEndUserActionCallback = OnEndUserAction;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "end-user-action", onTextBufferEndUserActionCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertChildAnchorEvent onInsertChildAnchor
        {
            get
            {
                return onInsertChildAnchorEvent;
            }
            set
            {
                onInsertChildAnchorEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertChildAnchorCallback.IsNullPointer())
                    {
                        onTextBufferInsertChildAnchorCallback = OnInsertChildAnchor;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-child-anchor", onTextBufferInsertChildAnchorCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertPixbufEvent onInsertPixbuf
        {
            get
            {
                return onInsertPixbufEvent;
            }
            set
            {
                onInsertPixbufEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertPixbufCallback.IsNullPointer())
                    {
                        onTextBufferInsertPixbufCallback = OnInsertPixbuf;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-pixbuf", onTextBufferInsertPixbufCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertTextEvent onInsertText
        {
            get
            {
                return onInsertTextEvent;
            }
            set
            {
                onInsertTextEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertTextCallback.IsNullPointer())
                    {
                        onTextBufferInsertTextCallback = OnInsertText;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-text", onTextBufferInsertTextCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferMarkDeletedEvent onMarkDeleted
        {
            get
            {
                return onMarkDeletedEvent;
            }
            set
            {
                onMarkDeletedEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferMarkDeletedCallback.IsNullPointer())
                    {
                        onTextBufferMarkDeletedCallback = OnMarkDeleted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "mark-deleted", onTextBufferMarkDeletedCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferMarkSetEvent onMarkSet
        {
            get
            {
                return onMarkSetEvent;
            }
            set
            {
                onMarkSetEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferMarkSetCallback.IsNullPointer())
                    {
                        onTextBufferMarkSetCallback = OnMarkSet;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "mark-set", onTextBufferMarkSetCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferModifiedChangedEvent onModifiedChanged
        {
            get
            {
                return onModifiedChangedEvent;
            }
            set
            {
                onModifiedChangedEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferModifiedChangedCallback.IsNullPointer())
                    {
                        onTextBufferModifiedChangedCallback = OnModifiedChanged;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "modified-changed", onTextBufferModifiedChangedCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferPasteDoneEvent onPasteDone
        {
            get
            {
                return onPasteDoneEvent;
            }
            set
            {
                onPasteDoneEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferPasteDoneCallback.IsNullPointer())
                    {
                        onTextBufferPasteDoneCallback = OnPasteDone;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "paste-done", onTextBufferPasteDoneCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferRemoveTagEvent onRemoveTag
        {
            get
            {
                return onRemoveTagEvent;
            }
            set
            {
                onRemoveTagEvent = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferRemoveTagCallback.IsNullPointer())
                    {
                        onTextBufferRemoveTagCallback = OnRemoveTag;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "remove-tag", onTextBufferRemoveTagCallback.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }

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
            
            NativeTextView.GtkSharpTextViewCreateWithBuffer(out handle, out buffer);
            NativeTextView.GtkSharpTextViewGetBuffer(out handle, out buffer);
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

        bool OnExtendSelection(IntPtr widget, GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            if(onExtendSelection != null)
            {
                return onExtendSelection(granularity, location, start, end);
            }
            return false;
        }

        void OnInsertAtCursor(IntPtr widget, IntPtr str, IntPtr data)
        {
            if(onInsertAtCursor != null)
            {
                string text = MarshalHelper.MarshalPtrToString(str);
                onInsertAtCursor(text);
            }            
        }

        void OnInsertEmoji(IntPtr widget, IntPtr data)
        {
            onInsertEmoji?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            onMoveCursor?.Invoke(step, count, extendSelection);
        }

        void OnMoveViewport(IntPtr widget, IntPtr scrollStep, int count, IntPtr data)
        {
            if(onMoveViewport != null)
            {
                int s = Marshal.ReadInt32(scrollStep);
                onMoveViewport((GtkScrollStep)s, count);
            }            
        }

        void OnPasteClipboard(IntPtr widget, IntPtr data)
        {
            onPasteClipboard?.Invoke();
        }

        void OnPopulatePopup(IntPtr widget, IntPtr popup, IntPtr data)
        {
            onPopulatePopup?.Invoke();
        }

        void OnPreeditChanged(IntPtr widget, IntPtr str, IntPtr data)
        {
            if(onPreeditChanged != null)
            {
                string text = MarshalHelper.MarshalPtrToString(str);
                onPreeditChanged(text);
            }
        }

        void OnApplyTag(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onApplyTag?.Invoke(tag, start, end);
        }

        void OnBeginUserAction(GtkTextBufferPointer buffer, IntPtr data)
        {
            onBeginUserAction?.Invoke();
        }

        void OnChanged(GtkTextBufferPointer buffer, IntPtr data)
        {
            onChanged?.Invoke();
        }

        void OnDeleteRange(GtkTextBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onDeleteRange?.Invoke(start, end);
        }

        void OnEndUserAction(GtkTextBufferPointer buffer, IntPtr data)
        {
            onEndUserAction?.Invoke();
        }

        void OnInsertChildAnchor(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data)
        {
            onInsertChildAnchor?.Invoke(location, anchor);
        }

        void OnInsertPixbuf(GtkTextBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data)
        {
            onInsertPixbuf?.Invoke(location, pixbuf);
        }

        void OnInsertText(GtkTextBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data)
        {
            if(onInsertText != null)
            {
                string t = MarshalHelper.MarshalPtrToString(text);
                onInsertText?.Invoke(location, t, length);
            }
        }

        void OnMarkDeleted(GtkTextBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data)
        {
            onMarkDeleted?.Invoke(mark);
        }

        void OnMarkSet(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data)
        {
            onMarkSet?.Invoke(location, mark);
        }

        void OnModifiedChanged(GtkTextBufferPointer buffer, IntPtr data)
        {
            onModifiedChanged?.Invoke();
        }

        void OnPasteDone(GtkTextBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data)
        {
            onPasteDone?.Invoke(clipboard);
        }

        void OnRemoveTag(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onRemoveTag?.Invoke(tag, start, end);
        }
    }
}