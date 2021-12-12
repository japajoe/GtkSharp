using System;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
using GtkSharp.Native.Utilities;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class TextBufferBase : Widget
    {
        protected TextTagTable tagTable;
        private string text;

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

        public TextBufferApplyTagEvent onApplyTag
        {
            get
            {
                return onApplyTagEvent;
            }
            set
            {
                onApplyTagEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferApplyTagCallback.IsNullPointer())
                    {
                        onTextBufferApplyTagCallback = OnApplyTag;
                        GLib.g_signal_connect(handle.pointer, "apply-tag", onTextBufferApplyTagCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferBeginUserActionCallback.IsNullPointer())
                    {
                        onTextBufferBeginUserActionCallback = OnBeginUserAction;
                        GLib.g_signal_connect(handle.pointer, "begin-user-action", onTextBufferBeginUserActionCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferChangedCallback.IsNullPointer())
                    {
                        onTextBufferChangedCallback = OnChanged;
                        GLib.g_signal_connect(handle.pointer, "changed", onTextBufferChangedCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferDeleteRangeCallback.IsNullPointer())
                    {
                        onTextBufferDeleteRangeCallback = OnDeleteRange;
                        GLib.g_signal_connect(handle.pointer, "delete-range", onTextBufferDeleteRangeCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferEndUserActionCallback.IsNullPointer())
                    {
                        onTextBufferEndUserActionCallback = OnEndUserAction;
                        GLib.g_signal_connect(handle.pointer, "end-user-action", onTextBufferEndUserActionCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferInsertChildAnchorCallback.IsNullPointer())
                    {
                        onTextBufferInsertChildAnchorCallback = OnInsertChildAnchor;
                        GLib.g_signal_connect(handle.pointer, "insert-child-anchor", onTextBufferInsertChildAnchorCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferInsertPixbufCallback.IsNullPointer())
                    {
                        onTextBufferInsertPixbufCallback = OnInsertPixbuf;
                        GLib.g_signal_connect(handle.pointer, "insert-pixbuf", onTextBufferInsertPixbufCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferInsertTextCallback.IsNullPointer())
                    {
                        onTextBufferInsertTextCallback = OnInsertText;
                        GLib.g_signal_connect(handle.pointer, "insert-text", onTextBufferInsertTextCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferMarkDeletedCallback.IsNullPointer())
                    {
                        onTextBufferMarkDeletedCallback = OnMarkDeleted;
                        GLib.g_signal_connect(handle.pointer, "mark-deleted", onTextBufferMarkDeletedCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferMarkSetCallback.IsNullPointer())
                    {
                        onTextBufferMarkSetCallback = OnMarkSet;
                        GLib.g_signal_connect(handle.pointer, "mark-set", onTextBufferMarkSetCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferModifiedChangedCallback.IsNullPointer())
                    {
                        onTextBufferModifiedChangedCallback = OnModifiedChanged;
                        GLib.g_signal_connect(handle.pointer, "modified-changed", onTextBufferModifiedChangedCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferPasteDoneCallback.IsNullPointer())
                    {
                        onTextBufferPasteDoneCallback = OnPasteDone;
                        GLib.g_signal_connect(handle.pointer, "paste-done", onTextBufferPasteDoneCallback.ToIntPtr(), handle.pointer);
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
                if(!handle.IsNullPointer)
                {
                    if(onTextBufferRemoveTagCallback.IsNullPointer())
                    {
                        onTextBufferRemoveTagCallback = OnRemoveTag;
                        GLib.g_signal_connect(handle.pointer, "remove-tag", onTextBufferRemoveTagCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;
            
            GtkTextIter iterStart;
            GtkTextIter iterEnd;

            NativeTextBuffer.gtk_text_buffer_get_bounds(handle, out iterStart, out iterEnd);
            IntPtr ptr = NativeTextBuffer.gtk_text_buffer_get_text(handle, ref iterStart, ref iterEnd, true);            
            text = MarshalHelper.MarshalPtrToString(ptr);            
            GLib.g_free(ptr);
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeTextBuffer.gtk_text_buffer_set_text(handle, text, text.Length);
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;

            GtkTextIter iterStart;
            GtkTextIter iterEnd;

            NativeTextBuffer.gtk_text_buffer_get_bounds(handle, out iterStart, out iterEnd);
            NativeTextBuffer.gtk_text_buffer_delete(handle, ref iterStart, ref iterEnd);
            

            this.text = string.Empty;
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