using System;
using System.Text;
using System.Runtime.InteropServices;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class TextView : Widget
    {
        private event TextViewBackspaceEvent onBackspaceCallback;
        private event TextViewCopyClipboardEvent onCopyClipboardCallback;
        private event TextViewCutClipboardEvent onCutClipboardCallback;
        private event TextViewDeleteFromCursorEvent onDeleteFromCursorCallback;
        private event TextViewExtendSelectionEvent onExtendSelectionCallback;
        private event TextViewInsertAtCursorEvent onInsertAtCursorCallback;
        private event TextViewInsertEmojiEvent onInsertEmojiCallback;
        private event TextViewMoveCursorEvent onMoveCursorCallback;
        private event TextViewMoveViewportEvent onMoveViewportCallback;
        private event TextViewPasteClipboardEvent onPasteClipboardCallback;
        private event TextViewPopulatePopupEvent onPopulatePopupCallback;
        private event TextViewPreeditChangedEvent onPreeditChangedCallback;

        private event TextBufferApplyTagEvent onApplyTagCallback;
        private event TextBufferBeginUserActionEvent onBeginUserActionCallback;
        private event TextBufferChangedEvent onChangedCallback;
        private event TextBufferDeleteRangeEvent onDeleteRangeCallback;
        private event TextBufferEndUserActionEvent onEndUserActionCallback;
        private event TextBufferInsertChildAnchorEvent onInsertChildAnchorCallback;
        private event TextBufferInsertPixbufEvent onInsertPixbufCallback;
        private event TextBufferInsertTextEvent onInsertTextCallback;
        private event TextBufferMarkDeletedEvent onMarkDeletedCallback;
        private event TextBufferMarkSetEvent onMarkSetCallback;
        private event TextBufferModifiedChangedEvent onModifiedChangedCallback;
        private event TextBufferPasteDoneEvent onPasteDoneCallback;
        private event TextBufferRemoveTagEvent onRemoveTagCallback;

        private GtkTextViewBackspaceCallback onTextViewBackspace;
        private GtkTextViewCopyClipboardCallback onTextViewCopyClipboard;
        private GtkTextViewCutClipboardCallback onTextViewCutClipboard;
        private GtkTextViewDeleteFromCursorCallback onTextViewDeleteFromCursor;
        private GtkTextViewExtendSelectionCallback onTextViewExtendSelection;
        private GtkTextViewInsertAtCursorCallback onTextViewInsertAtCursor;
        private GtkTextViewInsertEmojiCallback onTextViewInsertEmoji;
        private GtkTextViewMoveCursorCallback onTextViewMoveCursor;
        private GtkTextViewMoveViewportCallback onTextViewMoveViewport;
        private GtkTextViewPasteClipboardCallback onTextViewPasteClipboard;
        private GtkTextViewPopulatePopupCallback onTextViewPopulatePopup;
        private GtkTextViewPreeditChangedCallback onTextViewPreeditChanged;

        private GtkTextBufferApplyTagCallback onTextBufferApplyTag;
        private GtkTextBufferBeginUserActionCallback onTextBufferBeginUserAction;
        private GtkTextBufferChangedCallback onTextBufferChanged;
        private GtkTextBufferDeleteRangeCallback onTextBufferDeleteRange;
        private GtkTextBufferEndUserActionCallback onTextBufferEndUserAction;
        private GtkTextBufferInsertChildAnchorCallback onTextBufferInsertChildAnchor;
        private GtkTextBufferInsertPixbufCallback onTextBufferInsertPixbuf;
        private GtkTextBufferInsertTextCallback onTextBufferInsertText;
        private GtkTextBufferMarkDeletedCallback onTextBufferMarkDeleted;
        private GtkTextBufferMarkSetCallback onTextBufferMarkSet;
        private GtkTextBufferModifiedChangedCallback onTextBufferModifiedChanged;
        private GtkTextBufferPasteDoneCallback onTextBufferPasteDone;
        private GtkTextBufferRemoveTagCallback onTextBufferRemoveTag;

        private GtkTextBufferPointer buffer;
        private StringBuilder stringBuilder;
        private string text;


        public TextViewBackspaceEvent onBackspace
        {
            get
            {
                return onBackspaceCallback;
            }
            set
            {
                onBackspace = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewBackspace.IsNullPointer())
                    {
                        onTextViewBackspace = OnBackspace;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "backspace", onTextViewBackspace.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardCallback;
            }
            set
            {
                onCopyClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewCopyClipboard.IsNullPointer())
                    {
                        onTextViewCopyClipboard = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onTextViewCopyClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewCutClipboardEvent onCutClipboard
        {
            get
            {
                return onCutClipboardCallback;
            }
            set
            {
                onCutClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewCutClipboard.IsNullPointer())
                    {
                        onTextViewCutClipboard = OnCutClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "cut-clipboard", onTextViewCutClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewDeleteFromCursorEvent onDeleteFromCursor
        {
            get
            {
                return onDeleteFromCursorCallback;
            }
            set
            {
                onDeleteFromCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewDeleteFromCursor.IsNullPointer())
                    {
                        onTextViewDeleteFromCursor = OnDeleteFromCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "delete-from-cursor", onTextViewDeleteFromCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewExtendSelectionEvent onExtendSelection
        {
            get
            {
                return onExtendSelectionCallback;
            }
            set
            {
                onExtendSelection = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewExtendSelection.IsNullPointer())
                    {
                        onTextViewExtendSelection = OnExtendSelection;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "extend-selection", onTextViewExtendSelection.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewInsertAtCursorEvent onInsertAtCursor
        {
            get
            {
                return onInsertAtCursorCallback;
            }
            set
            {
                onInsertAtCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewInsertAtCursor.IsNullPointer())
                    {
                        onTextViewInsertAtCursor = OnInsertAtCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-at-cursor", onTextViewInsertAtCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewInsertEmojiEvent onInsertEmoji
        {
            get
            {
                return onInsertEmojiCallback;
            }
            set
            {
                onInsertEmoji = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewInsertEmoji.IsNullPointer())
                    {
                        onTextViewInsertEmoji = OnInsertEmoji;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "insert-emoji", onTextViewInsertEmoji.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorCallback;
            }
            set
            {
                onMoveCursor = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewMoveCursor.IsNullPointer())
                    {
                        onTextViewMoveCursor = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onTextViewMoveCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewMoveViewportEvent onMoveViewport
        {
            get
            {
                return onMoveViewportCallback;
            }
            set
            {
                onMoveViewport = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewMoveViewport.IsNullPointer())
                    {
                        onTextViewMoveViewport = OnMoveViewport;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-viewport", onTextViewMoveViewport.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPasteClipboardEvent onPasteClipboard
        {
            get
            {
                return onPasteClipboardCallback;
            }
            set
            {
                onPasteClipboard = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPasteClipboard.IsNullPointer())
                    {
                        onTextViewPasteClipboard = OnPasteClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "paste-clipboard", onTextViewPasteClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupCallback;
            }
            set
            {
                onPopulatePopup = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPopulatePopup.IsNullPointer())
                    {
                        onTextViewPopulatePopup = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onTextViewPopulatePopup.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextViewPreeditChangedEvent onPreeditChanged
        {
            get
            {
                return onPreeditChangedCallback;
            }
            set
            {
                onPreeditChanged = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextViewPreeditChanged.IsNullPointer())
                    {
                        onTextViewPreeditChanged = OnPreeditChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "preedit-changed", onTextViewPreeditChanged.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public TextBufferApplyTagEvent onApplyTag
        {
            get
            {
                return onApplyTagCallback;
            }
            set
            {
                onApplyTagCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferApplyTag.IsNullPointer())
                    {
                        onTextBufferApplyTag = OnApplyTag;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "apply-tag", onTextBufferApplyTag.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferBeginUserActionEvent onBeginUserAction
        {
            get
            {
                return onBeginUserActionCallback;
            }
            set
            {
                onBeginUserActionCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferBeginUserAction.IsNullPointer())
                    {
                        onTextBufferBeginUserAction = OnBeginUserAction;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "begin-user-action", onTextBufferBeginUserAction.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferChangedEvent onChanged
        {
            get
            {
                return onChangedCallback;
            }
            set
            {
                onChangedCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferChanged.IsNullPointer())
                    {
                        onTextBufferChanged = OnChanged;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "changed", onTextBufferChanged.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferDeleteRangeEvent onDeleteRange
        {
            get
            {
                return onDeleteRangeCallback;
            }
            set
            {
                onDeleteRangeCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferDeleteRange.IsNullPointer())
                    {
                        onTextBufferDeleteRange = OnDeleteRange;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "delete-range", onTextBufferDeleteRange.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferEndUserActionEvent onEndUserAction
        {
            get
            {
                return onEndUserActionCallback;
            }
            set
            {
                onEndUserActionCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferEndUserAction.IsNullPointer())
                    {
                        onTextBufferEndUserAction = OnEndUserAction;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "end-user-action", onTextBufferEndUserAction.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertChildAnchorEvent onInsertChildAnchor
        {
            get
            {
                return onInsertChildAnchorCallback;
            }
            set
            {
                onInsertChildAnchorCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertChildAnchor.IsNullPointer())
                    {
                        onTextBufferInsertChildAnchor = OnInsertChildAnchor;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-child-anchor", onTextBufferInsertChildAnchor.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertPixbufEvent onInsertPixbuf
        {
            get
            {
                return onInsertPixbufCallback;
            }
            set
            {
                onInsertPixbufCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertPixbuf.IsNullPointer())
                    {
                        onTextBufferInsertPixbuf = OnInsertPixbuf;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-pixbuf", onTextBufferInsertPixbuf.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferInsertTextEvent onInsertText
        {
            get
            {
                return onInsertTextCallback;
            }
            set
            {
                onInsertTextCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferInsertText.IsNullPointer())
                    {
                        onTextBufferInsertText = OnInsertText;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "insert-text", onTextBufferInsertText.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferMarkDeletedEvent onMarkDeleted
        {
            get
            {
                return onMarkDeletedCallback;
            }
            set
            {
                onMarkDeletedCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferMarkDeleted.IsNullPointer())
                    {
                        onTextBufferMarkDeleted = OnMarkDeleted;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "mark-deleted", onTextBufferMarkDeleted.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferMarkSetEvent onMarkSet
        {
            get
            {
                return onMarkSetCallback;
            }
            set
            {
                onMarkSetCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferMarkSet.IsNullPointer())
                    {
                        onTextBufferMarkSet = OnMarkSet;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "mark-set", onTextBufferMarkSet.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferModifiedChangedEvent onModifiedChanged
        {
            get
            {
                return onModifiedChangedCallback;
            }
            set
            {
                onModifiedChangedCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferModifiedChanged.IsNullPointer())
                    {
                        onTextBufferModifiedChanged = OnModifiedChanged;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "modified-changed", onTextBufferModifiedChanged.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferPasteDoneEvent onPasteDone
        {
            get
            {
                return onPasteDoneCallback;
            }
            set
            {
                onPasteDoneCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferPasteDone.IsNullPointer())
                    {
                        onTextBufferPasteDone = OnPasteDone;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "paste-done", onTextBufferPasteDone.ToIntPtr(), out buffer.pointer);
                    }
                }
            }
        }
        public TextBufferRemoveTagEvent onRemoveTag
        {
            get
            {
                return onRemoveTagCallback;
            }
            set
            {
                onRemoveTagCallback = value;
                if(!buffer.IsNullPointer)
                {
                    if(onTextBufferRemoveTag.IsNullPointer())
                    {
                        onTextBufferRemoveTag = OnRemoveTag;
                        Gtk.GtkSharpSignalConnect(out buffer.pointer, "remove-tag", onTextBufferRemoveTag.ToIntPtr(), out buffer.pointer);
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

            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {

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