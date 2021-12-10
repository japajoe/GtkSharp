using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class SourceView : Widget
    {        
        private GtkSourceBufferPointer buffer;
        private GtkSourceLanguageManagerPointer sourceLanguageManager;
        private GtkSourceLanguagePointer sourceLanguage;
        private StringBuilder stringBuilder;
        private string text;

        private event SourceBufferApplyTagEvent onApplyTagEvent;
        private event SourceBufferBeginUserActionEvent onBeginUserActionEvent;
        private event SourceBufferChangedEvent onChangedEvent;
        private event SourceBufferDeleteRangeEvent onDeleteRangeEvent;
        private event SourceBufferEndUserActionEvent onEndUserActionEvent;
        private event SourceBufferInsertChildAnchorEvent onInsertChildAnchorEvent;
        private event SourceBufferInsertPixbufEvent onInsertPixbufEvent;
        private event SourceBufferInsertTextEvent onInsertTextEvent;
        private event SourceBufferMarkDeletedEvent onMarkDeletedEvent;
        private event SourceBufferMarkSetEvent onMarkSetEvent;
        private event SourceBufferModifiedChangedEvent onModifiedChangedEvent;
        private event SourceBufferPasteDoneEvent onPasteDoneEvent;
        private event SourceBufferRemoveTagEvent onRemoveTagEvent;

        private GtkSourceBufferApplyTagCallback onTextBufferApplyTagCallback;
        private GtkSourceBufferBeginUserActionCallback onTextBufferBeginUserActionCallback;
        private GtkSourceBufferChangedCallback onTextBufferChangedCallback;
        private GtkSourceBufferDeleteRangeCallback onTextBufferDeleteRangeCallback;
        private GtkSourceBufferEndUserActionCallback onTextBufferEndUserActionCallback;
        private GtkSourceBufferInsertChildAnchorCallback onTextBufferInsertChildAnchorCallback;
        private GtkSourceBufferInsertPixbufCallback onTextBufferInsertPixbufCallback;
        private GtkSourceBufferInsertTextCallback onTextBufferInsertTextCallback;
        private GtkSourceBufferMarkDeletedCallback onTextBufferMarkDeletedCallback;
        private GtkSourceBufferMarkSetCallback onTextBufferMarkSetCallback;
        private GtkSourceBufferModifiedChangedCallback onTextBufferModifiedChangedCallback;
        private GtkSourceBufferPasteDoneCallback onTextBufferPasteDoneCallback;
        private GtkSourceBufferRemoveTagCallback onTextBufferRemoveTagCallback;

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

        public bool LineNumbers
        {
            get
            {
                return GetShowLineNumbers();
            }
            set
            {
                SetShowLineNumbers(value);
            }
        }

        public int TabWidth
        {
            get
            {
                return GetTabWidth();
            }
            set
            {
                SetTabWidth(value);
            }
        }

        public SourceBufferApplyTagEvent onApplyTag
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
        public SourceBufferBeginUserActionEvent onBeginUserAction
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
        public SourceBufferChangedEvent onChanged
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
        public SourceBufferDeleteRangeEvent onDeleteRange
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
        public SourceBufferEndUserActionEvent onEndUserAction
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
        public SourceBufferInsertChildAnchorEvent onInsertChildAnchor
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
        public SourceBufferInsertPixbufEvent onInsertPixbuf
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
        public SourceBufferInsertTextEvent onInsertText
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
        public SourceBufferMarkDeletedEvent onMarkDeleted
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
        public SourceBufferMarkSetEvent onMarkSet
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
        public SourceBufferModifiedChangedEvent onModifiedChanged
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
        public SourceBufferPasteDoneEvent onPasteDone
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
        public SourceBufferRemoveTagEvent onRemoveTag
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

        public SourceView(string languageString)
        {            
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);

            NativeSourceView.GtkSharpSourceLanguageManagerGetDefault(out sourceLanguageManager);
            NativeSourceView.GtkSharpSourceLanguageManagerGetLanguage(out sourceLanguageManager, out sourceLanguage, languageString);
            NativeSourceView.GtkSharpSourceBufferCreateWithLanguage(out buffer, out sourceLanguage);
            NativeSourceView.GtkSharpSourceViewCreateWithBuffer(out handle, out buffer);
            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle, 4);
        }

        public void SetText(string text)
        {
            if(buffer.IsNullPointer)
                return;

            NativeSourceBuffer.GtkSharpTextBufferSetText(out buffer, text, text.Length);
            
            this.text = text;
        }

        public string GetText()
        {
            if(buffer.IsNullPointer)
                return string.Empty;            

            stringBuilder.Clear();

            int length = 0;

            NativeSourceBuffer.GtkSharpTextBufferGetCharCount(out buffer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;
            
            NativeSourceBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextBufferGetText(out buffer, out iterStart, out iterEnd, true, stringBuilder);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterStart);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterEnd);            
            
            text = stringBuilder.ToString().Substring(0, length);
            
            return text;
        }

        public void Clear()
        {
            if(buffer.IsNullPointer)
                return;

            GtkTextIterPointer iterStart;
            GtkTextIterPointer iterEnd;

            NativeSourceBuffer.GtkSharpTextBufferGetBounds(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextBufferDelete(out buffer, out iterStart, out iterEnd);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterStart);
            NativeSourceBuffer.GtkSharpTextIterFree(out iterEnd);             

            this.text = string.Empty;
        }

        public bool GetShowLineNumbers()
        {
            if(handle.IsNullPointer)
                return false;
            
            bool visible;
            NativeSourceView.GtkSharpSourceViewGetShowLineNumbers(out handle, out visible);
            return visible;
        }

       public void SetShowLineNumbers(bool visible)
        {
            if(handle.IsNullPointer)
                return;
                
            NativeSourceView.GtkSharpSourceViewSetShowLineNumbers(out handle, visible);
        }

        public void SetTabWidth(int width)
        {
            if(handle.IsNullPointer)
                return;

            if(width < 1)
                width = 1;

            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle, width);
        }

        public int GetTabWidth()
        {
            if(handle.IsNullPointer)
                return 1;
            
            int width;
            NativeSourceView.GtkSharpSourceViewGetTabWidth(out handle, out width);
            return width;
        }

        void OnApplyTag(GtkSourceBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onApplyTag?.Invoke(tag, start, end);
        }

        void OnBeginUserAction(GtkSourceBufferPointer buffer, IntPtr data)
        {
            onBeginUserAction?.Invoke();
        }

        void OnChanged(GtkSourceBufferPointer buffer, IntPtr data)
        {
            onChanged?.Invoke();
        }

        void OnDeleteRange(GtkSourceBufferPointer buffer, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onDeleteRange?.Invoke(start, end);
        }

        void OnEndUserAction(GtkSourceBufferPointer buffer, IntPtr data)
        {
            onEndUserAction?.Invoke();
        }

        void OnInsertChildAnchor(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GtkTextChildAnchorPointer anchor, IntPtr data)
        {
            onInsertChildAnchor?.Invoke(location, anchor);
        }

        void OnInsertPixbuf(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GdkPixbufPointer pixbuf, IntPtr data)
        {
            onInsertPixbuf?.Invoke(location, pixbuf);
        }

        void OnInsertText(GtkSourceBufferPointer buffer, GtkTextIterPointer location, IntPtr text, int length, IntPtr data)
        {
            if(onInsertText != null)
            {
                string t = MarshalHelper.MarshalPtrToString(text);
                onInsertText?.Invoke(location, t, length);
            }
        }

        void OnMarkDeleted(GtkSourceBufferPointer buffer, GtkTextMarkPointer mark, IntPtr data)
        {
            onMarkDeleted?.Invoke(mark);
        }

        void OnMarkSet(GtkSourceBufferPointer buffer, GtkTextIterPointer location, GtkTextMarkPointer mark, IntPtr data)
        {
            onMarkSet?.Invoke(location, mark);
        }

        void OnModifiedChanged(GtkSourceBufferPointer buffer, IntPtr data)
        {
            onModifiedChanged?.Invoke();
        }

        void OnPasteDone(GtkSourceBufferPointer buffer, GtkClipboardPointer clipboard, IntPtr data)
        {
            onPasteDone?.Invoke(clipboard);
        }

        void OnRemoveTag(GtkSourceBufferPointer buffer, GtkTextTagPointer tag, GtkTextIterPointer start, GtkTextIterPointer end, IntPtr data)
        {
            onRemoveTag?.Invoke(tag, start, end);
        }      
    }
}