using System;
using System.Runtime.InteropServices;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
using GtkSharp.Native.Utilities;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class TextView : Widget
    {
        private TextBuffer buffer;
        private string text;

        private GEventHandler<TextViewBackspaceCallback,TextViewBackspaceEvent> backspaceHandler = new GEventHandler<TextViewBackspaceCallback, TextViewBackspaceEvent>();
        private GEventHandler<TextViewCopyClipboardCallback,TextViewCopyClipboardEvent> copyClipboardHandler = new GEventHandler<TextViewCopyClipboardCallback, TextViewCopyClipboardEvent>();
        private GEventHandler<TextViewCutClipboardCallback,TextViewCutClipboardEvent> cutClipboardHandler = new GEventHandler<TextViewCutClipboardCallback, TextViewCutClipboardEvent>();
        private GEventHandler<TextViewDeleteFromCursorCallback,TextViewDeleteFromCursorEvent> deleteFromCursorHandler = new GEventHandler<TextViewDeleteFromCursorCallback, TextViewDeleteFromCursorEvent>();
        private GEventHandler<TextViewExtendSelectionCallback,TextViewExtendSelectionEvent> extendSelectionHandler = new GEventHandler<TextViewExtendSelectionCallback, TextViewExtendSelectionEvent>();
        private GEventHandler<TextViewInsertAtCursorCallback,TextViewInsertAtCursorEvent> insertAtCursorHandler = new GEventHandler<TextViewInsertAtCursorCallback, TextViewInsertAtCursorEvent>();
        private GEventHandler<TextViewInsertEmojiCallback,TextViewInsertEmojiEvent> insertEmojiHandler = new GEventHandler<TextViewInsertEmojiCallback, TextViewInsertEmojiEvent>();
        private GEventHandler<TextViewMoveCursorCallback,TextViewMoveCursorEvent> moveCursorHandler = new GEventHandler<TextViewMoveCursorCallback, TextViewMoveCursorEvent>();
        private GEventHandler<TextViewMoveViewportCallback,TextViewMoveViewportEvent> moveViewportHandler = new GEventHandler<TextViewMoveViewportCallback, TextViewMoveViewportEvent>();
        private GEventHandler<TextViewPasteClipboardCallback,TextViewPasteClipboardEvent> pasteClipboardHandler = new GEventHandler<TextViewPasteClipboardCallback, TextViewPasteClipboardEvent>();
        private GEventHandler<TextViewPopulatePopupCallback,TextViewPopulatePopupEvent> populatePopupHandler = new GEventHandler<TextViewPopulatePopupCallback, TextViewPopulatePopupEvent>();
        private GEventHandler<TextViewPreEditChangedCallback,TextViewPreEditChangedEvent> preEditChangedHandler = new GEventHandler<TextViewPreEditChangedCallback, TextViewPreEditChangedEvent>();

        public string Text
        {
            get
            {
                text = buffer.Text;
                return text;
            }
            set
            {
                text = value;
                buffer.Text = text;
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

        public TextViewBackspaceEvent Backspace
        {
            get
            {
                return backspaceHandler.Event;
            }
            set
            {
                backspaceHandler.Event = value;
                backspaceHandler.SignalConnect(handle.pointer, "backspace", OnBackspace, handle.pointer);
            }
        }

        public TextViewCopyClipboardEvent CopyClipboard
        {
            get
            {
                return copyClipboardHandler.Event;
            }
            set
            {
                copyClipboardHandler.Event = value;
                copyClipboardHandler.SignalConnect(handle.pointer, "copy-clipboard", OnCopyClipboard, handle.pointer);
            }
        }

        public TextViewCutClipboardEvent CutClipboard
        {
            get
            {
                return cutClipboardHandler.Event;
            }
            set
            {
                cutClipboardHandler.Event = value;
                cutClipboardHandler.SignalConnect(handle.pointer, "cut-clipboard", OnCutClipboard, handle.pointer);
            }
        }

        public TextViewDeleteFromCursorEvent DeleteFromCursor
        {
            get
            {
                return deleteFromCursorHandler.Event;
            }
            set
            {
                deleteFromCursorHandler.Event = value;
                deleteFromCursorHandler.SignalConnect(handle.pointer, "delete-from-cursor", OnDeleteFromCursor, handle.pointer);
            }
        }

        public TextViewExtendSelectionEvent ExtendSelection
        {
            get
            {
                return extendSelectionHandler.Event;
            }
            set
            {
                extendSelectionHandler.Event = value;
                extendSelectionHandler.SignalConnect(handle.pointer, "extend-selection", OnExtendSelection, handle.pointer);
            }
        }

        public TextViewInsertAtCursorEvent InsertAtCursor
        {
            get
            {
                return insertAtCursorHandler.Event;
            }
            set
            {
                insertAtCursorHandler.Event = value;
                insertAtCursorHandler.SignalConnect(handle.pointer, "insert-at-cursor", OnInsertAtCursor, handle.pointer);
            }
        }

        public TextViewInsertEmojiEvent InsertEmoji
        {
            get
            {
                return insertEmojiHandler.Event;
            }
            set
            {
                insertEmojiHandler.Event = value;
                insertEmojiHandler.SignalConnect(handle.pointer, "insert-emoji", OnInsertEmoji, handle.pointer);
            }
        }

        public TextViewMoveCursorEvent MoveCursor
        {
            get
            {
                return moveCursorHandler.Event;
            }
            set
            {
                moveCursorHandler.Event = value;
                moveCursorHandler.SignalConnect(handle.pointer, "move-cursor", OnMoveCursor, handle.pointer);
            }
        }

        public TextViewMoveViewportEvent MoveViewport
        {
            get
            {
                return moveViewportHandler.Event;
            }
            set
            {
                moveViewportHandler.Event = value;
                moveViewportHandler.SignalConnect(handle.pointer, "move-viewport", OnMoveViewport, handle.pointer);
            }
        }

        public TextViewPasteClipboardEvent PasteClipboard
        {
            get
            {
                return pasteClipboardHandler.Event;
            }
            set
            {
                pasteClipboardHandler.Event = value;
                pasteClipboardHandler.SignalConnect(handle.pointer, "paste-clipboard", OnPasteClipboard, handle.pointer);
            }
        }

        public TextViewPopulatePopupEvent PopulatePopup
        {
            get
            {
                return populatePopupHandler.Event;
            }
            set
            {
                populatePopupHandler.Event = value;
                populatePopupHandler.SignalConnect(handle.pointer, "populate-popup", OnPopulatePopup, handle.pointer);
            }
        }

        public TextViewPreEditChangedEvent PreEditChanged
        {
            get
            {
                return preEditChangedHandler.Event;
            }
            set
            {
                preEditChangedHandler.Event = value;
                preEditChangedHandler.SignalConnect(handle.pointer, "preedit-changed", OnPreEditChanged, handle.pointer);
            }
        }
        
        public TextView()
        {            
            handle = NativeTextView.gtk_text_view_new();
            GtkTextBufferPointer bufferPointer = NativeTextView.gtk_text_view_get_buffer(handle);
            buffer = new TextBuffer(bufferPointer);
        }

        public TextView(TextBuffer buffer)
        {
            this.buffer = buffer;
            handle = NativeTextView.gtk_text_view_new_with_buffer(buffer.handle);
        }

        public bool GetReadOnly()
        {
            if(handle.IsNullPointer)
                return false;
            
            //Invert value because true means 'editable' which means readonly is false
            return !NativeTextView.gtk_text_view_get_editable(handle);            
        }

        public void SetReadOnly(bool readOnly)
        {
            if(handle.IsNullPointer)
                return;

            //Invert value because true means 'editable' which means readonly is false
            NativeTextView.gtk_text_view_set_editable(handle, !readOnly);
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            buffer.Clear();
            text = string.Empty;
        }

        void OnBackspace(IntPtr widget, IntPtr data)
        {
            Backspace?.Invoke();
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            CopyClipboard?.Invoke();
        }

        void OnCutClipboard(IntPtr widget, IntPtr data)
        {
            CutClipboard?.Invoke();
        }

        void OnDeleteFromCursor(IntPtr widget, GtkDeleteType type, int count, IntPtr data)
        {
            DeleteFromCursor?.Invoke(type, count);
        }

        bool OnExtendSelection(IntPtr widget, GtkTextExtendSelection granularity, GtkTextIterPointer location, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            if(ExtendSelection != null)
            {
                return ExtendSelection(granularity, location, start, end);
            }
            return false;
        }

        void OnInsertAtCursor(IntPtr widget, IntPtr str, IntPtr data)
        {
            if(InsertAtCursor != null)
            {
                string text = MarshalHelper.MarshalPtrToString(str);
                InsertAtCursor(text);
            }            
        }

        void OnInsertEmoji(IntPtr widget, IntPtr data)
        {
            InsertEmoji?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            MoveCursor?.Invoke(step, count, extendSelection);
        }

        void OnMoveViewport(IntPtr widget, IntPtr scrollStep, int count, IntPtr data)
        {
            if(MoveViewport != null)
            {
                int s = Marshal.ReadInt32(scrollStep);
                MoveViewport((GtkScrollStep)s, count);
            }            
        }

        void OnPasteClipboard(IntPtr widget, IntPtr data)
        {
            PasteClipboard?.Invoke();
        }

        void OnPopulatePopup(IntPtr widget, IntPtr popup, IntPtr data)
        {
            PopulatePopup?.Invoke();
        }

        void OnPreEditChanged(IntPtr widget, IntPtr str, IntPtr data)
        {
            if(PreEditChanged != null)
            {
                string text = MarshalHelper.MarshalPtrToString(str);
                PreEditChanged(text);
            }
        }
    }
}