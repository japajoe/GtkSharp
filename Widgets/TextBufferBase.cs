using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
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

        private GEventHandler<TextBufferApplyTagCallback,TextBufferApplyTagEvent> applyTagHandler = new GEventHandler<TextBufferApplyTagCallback, TextBufferApplyTagEvent>();
        private GEventHandler<TextBufferBeginUserActionCallback,TextBufferBeginUserActionEvent> beginUserActionHandler = new GEventHandler<TextBufferBeginUserActionCallback, TextBufferBeginUserActionEvent>();
        private GEventHandler<TextBufferChangedCallback,TextBufferChangedEvent> changedHandler = new GEventHandler<TextBufferChangedCallback, TextBufferChangedEvent>();
        private GEventHandler<TextBufferDeleteRangeCallback,TextBufferDeleteRangeEvent> deleteRangeHandler = new GEventHandler<TextBufferDeleteRangeCallback, TextBufferDeleteRangeEvent>();
        private GEventHandler<TextBufferEndUserActionCallback,TextBufferEndUserActionEvent> endUserActionHandler = new GEventHandler<TextBufferEndUserActionCallback, TextBufferEndUserActionEvent>();
        private GEventHandler<TextBufferInsertChildAnchorCallback,TextBufferInsertChildAnchorEvent> insertChildAnchorHandler = new GEventHandler<TextBufferInsertChildAnchorCallback, TextBufferInsertChildAnchorEvent>();
        private GEventHandler<TextBufferInsertPixbufCallback,TextBufferInsertPixbufEvent> insertPixbufHandler = new GEventHandler<TextBufferInsertPixbufCallback, TextBufferInsertPixbufEvent>();
        private GEventHandler<TextBufferInsertTextCallback,TextBufferInsertTextEvent> insertTextHandler = new GEventHandler<TextBufferInsertTextCallback, TextBufferInsertTextEvent>();
        private GEventHandler<TextBufferMarkDeletedCallback,TextBufferMarkDeletedEvent> markDeletedHandler = new GEventHandler<TextBufferMarkDeletedCallback, TextBufferMarkDeletedEvent>();
        private GEventHandler<TextBufferMarkSetCallback,TextBufferMarkSetEvent> markSetHandler = new GEventHandler<TextBufferMarkSetCallback, TextBufferMarkSetEvent>();
        private GEventHandler<TextBufferModifiedChangedCallback,TextBufferModifiedChangedEvent> modifiedChangedHandler = new GEventHandler<TextBufferModifiedChangedCallback, TextBufferModifiedChangedEvent>();
        private GEventHandler<TextBufferPasteDoneCallback,TextBufferPasteDoneEvent> pasteDoneHandler = new GEventHandler<TextBufferPasteDoneCallback, TextBufferPasteDoneEvent>();
        private GEventHandler<TextBufferRemoveTagCallback,TextBufferRemoveTagEvent> removeTagHandler = new GEventHandler<TextBufferRemoveTagCallback, TextBufferRemoveTagEvent>();

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

        public TextBufferApplyTagEvent ApplyTag
        {
            get
            {
                return applyTagHandler.Event;
            }
            set
            {
                applyTagHandler.Event = value;
                applyTagHandler.SignalConnect(handle.pointer, "apply-tag", OnApplyTag, handle.pointer);
            }
        }

        public TextBufferBeginUserActionEvent BeginUserAction
        {
            get
            {
                return beginUserActionHandler.Event;
            }
            set
            {
                beginUserActionHandler.Event = value;
                beginUserActionHandler.SignalConnect(handle.pointer, "begin-user-action", OnBeginUserAction, handle.pointer);
            }
        }

        public TextBufferChangedEvent Changed
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

        public TextBufferDeleteRangeEvent DeleteRange
        {
            get
            {
                return deleteRangeHandler.Event;
            }
            set
            {
                deleteRangeHandler.Event = value;
                deleteRangeHandler.SignalConnect(handle.pointer, "delete-range", OnDeleteRange, handle.pointer);
            }
        }

        public TextBufferEndUserActionEvent EndUserAction
        {
            get
            {
                return endUserActionHandler.Event;
            }
            set
            {
                endUserActionHandler.Event = value;
                endUserActionHandler.SignalConnect(handle.pointer, "end-user-action", OnEndUserAction, handle.pointer);
            }
        }

        public TextBufferInsertChildAnchorEvent InsertChildAnchor
        {
            get
            {
                return insertChildAnchorHandler.Event;
            }
            set
            {
                insertChildAnchorHandler.Event = value;
                insertChildAnchorHandler.SignalConnect(handle.pointer, "insert-child-anchor", OnInsertChildAnchor, handle.pointer);
            }
        }

        public TextBufferInsertPixbufEvent InsertPixbuf
        {
            get
            {
                return insertPixbufHandler.Event;
            }
            set
            {
                insertPixbufHandler.Event = value;
                insertPixbufHandler.SignalConnect(handle.pointer, "insert-pixbuf", OnInsertPixbuf, handle.pointer);
            }
        }

        public TextBufferInsertTextEvent InsertText
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

        public TextBufferMarkDeletedEvent MarkDeleted
        {
            get
            {
                return markDeletedHandler.Event;
            }
            set
            {
                markDeletedHandler.Event = value;
                markDeletedHandler.SignalConnect(handle.pointer, "mark-deleted", OnMarkDeleted, handle.pointer);
            }
        }

        public TextBufferMarkSetEvent MarkSet
        {
            get
            {
                return markSetHandler.Event;
            }
            set
            {
                markSetHandler.Event = value;
                markSetHandler.SignalConnect(handle.pointer, "mark-set", OnMarkSet, handle.pointer);
            }
        }

        public TextBufferModifiedChangedEvent ModifiedChanged
        {
            get
            {
                return modifiedChangedHandler.Event;
            }
            set
            {
                modifiedChangedHandler.Event = value;
                modifiedChangedHandler.SignalConnect(handle.pointer, "modified-changed", OnModifiedChanged, handle.pointer);
            }
        }

        public TextBufferPasteDoneEvent PasteDone
        {
            get
            {
                return pasteDoneHandler.Event;
            }
            set
            {
                pasteDoneHandler.Event = value;
                pasteDoneHandler.SignalConnect(handle.pointer, "paste-done", OnPasteDone, handle.pointer);
            }
        }

        public TextBufferRemoveTagEvent RemoveTag
        {
            get
            {
                return removeTagHandler.Event;
            }
            set
            {
                removeTagHandler.Event = value;
                removeTagHandler.SignalConnect(handle.pointer, "remove-tag", OnRemoveTag, handle.pointer);
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
            ApplyTag?.Invoke(tag, start, end);
        }

        void OnBeginUserAction(GtkTextBufferPointer buffer, IntPtr data)
        {
            BeginUserAction?.Invoke();
        }

        void OnChanged(GtkTextBufferPointer buffer, IntPtr data)
        {
            Changed?.Invoke();
        }

        void OnDeleteRange(GtkTextBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            DeleteRange?.Invoke(start, end);
        }

        void OnEndUserAction(GtkTextBufferPointer buffer, IntPtr data)
        {
            EndUserAction?.Invoke();
        }

        void OnInsertChildAnchor(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data)
        {
            InsertChildAnchor?.Invoke(location, anchor);
        }

        void OnInsertPixbuf(GtkTextBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data)
        {
            InsertPixbuf?.Invoke(location, pixbuf);
        }

        void OnInsertText(GtkTextBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data)
        {
            if(InsertText != null)
            {
                string t = MarshalHelper.MarshalPtrToString(text);
                InsertText?.Invoke(location, t, length);
            }
        }

        void OnMarkDeleted(GtkTextBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data)
        {
            MarkDeleted?.Invoke(mark);
        }

        void OnMarkSet(GtkTextBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data)
        {
            MarkSet?.Invoke(location, mark);
        }

        void OnModifiedChanged(GtkTextBufferPointer buffer, IntPtr data)
        {
            ModifiedChanged?.Invoke();
        }

        void OnPasteDone(GtkTextBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data)
        {
            PasteDone?.Invoke(clipboard);
        }

        void OnRemoveTag(GtkTextBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            RemoveTag?.Invoke(tag, start, end);
        }        
    }
}