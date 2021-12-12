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
                        GLib.g_signal_connect(handle.pointer, "backspace", onTextViewBackspaceCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "copy-clipboard", onTextViewCopyClipboardCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "cut-clipboard", onTextViewCutClipboardCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "delete-from-cursor", onTextViewDeleteFromCursorCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "extend-selection", onTextViewExtendSelectionCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "insert-at-cursor", onTextViewInsertAtCursorCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "insert-emoji", onTextViewInsertEmojiCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "move-cursor", onTextViewMoveCursorCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "move-viewport", onTextViewMoveViewportCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "paste-clipboard", onTextViewPasteClipboardCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "populate-popup", onTextViewPopulatePopupCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "preedit-changed", onTextViewPreeditChangedCallback.ToIntPtr(), handle.pointer);
                    }
                }
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
    }
}