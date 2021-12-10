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

        private event SourceBufferApplyTagEvent onApplyTagCallback;
        private event SourceBufferBeginUserActionEvent onBeginUserActionCallback;
        private event SourceBufferChangedEvent onChangedCallback;
        private event SourceBufferDeleteRangeEvent onDeleteRangeCallback;
        private event SourceBufferEndUserActionEvent onEndUserActionCallback;
        private event SourceBufferInsertChildAnchorEvent onInsertChildAnchorCallback;
        private event SourceBufferInsertPixbufEvent onInsertPixbufCallback;
        private event SourceBufferInsertTextEvent onInsertTextCallback;
        private event SourceBufferMarkDeletedEvent onMarkDeletedCallback;
        private event SourceBufferMarkSetEvent onMarkSetCallback;
        private event SourceBufferModifiedChangedEvent onModifiedChangedCallback;
        private event SourceBufferPasteDoneEvent onPasteDoneCallback;
        private event SourceBufferRemoveTagEvent onRemoveTagCallback;

        private GtkSourceBufferApplyTagCallback onTextBufferApplyTag;
        private GtkSourceBufferBeginUserActionCallback onTextBufferBeginUserAction;
        private GtkSourceBufferChangedCallback onTextBufferChanged;
        private GtkSourceBufferDeleteRangeCallback onTextBufferDeleteRange;
        private GtkSourceBufferEndUserActionCallback onTextBufferEndUserAction;
        private GtkSourceBufferInsertChildAnchorCallback onTextBufferInsertChildAnchor;
        private GtkSourceBufferInsertPixbufCallback onTextBufferInsertPixbuf;
        private GtkSourceBufferInsertTextCallback onTextBufferInsertText;
        private GtkSourceBufferMarkDeletedCallback onTextBufferMarkDeleted;
        private GtkSourceBufferMarkSetCallback onTextBufferMarkSet;
        private GtkSourceBufferModifiedChangedCallback onTextBufferModifiedChanged;
        private GtkSourceBufferPasteDoneCallback onTextBufferPasteDone;
        private GtkSourceBufferRemoveTagCallback onTextBufferRemoveTag;

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
        public SourceBufferBeginUserActionEvent onBeginUserAction
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
        public SourceBufferChangedEvent onChanged
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
        public SourceBufferDeleteRangeEvent onDeleteRange
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
        public SourceBufferEndUserActionEvent onEndUserAction
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
        public SourceBufferInsertChildAnchorEvent onInsertChildAnchor
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
        public SourceBufferInsertPixbufEvent onInsertPixbuf
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
        public SourceBufferInsertTextEvent onInsertText
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
        public SourceBufferMarkDeletedEvent onMarkDeleted
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
        public SourceBufferMarkSetEvent onMarkSet
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
        public SourceBufferModifiedChangedEvent onModifiedChanged
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
        public SourceBufferPasteDoneEvent onPasteDone
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
        public SourceBufferRemoveTagEvent onRemoveTag
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

        public SourceView(string languageString)
        {            
            this.text = string.Empty;
            this.stringBuilder = new StringBuilder(4096);

            NativeSourceView.GtkSharpSourceLanguageManagerGetDefault(out sourceLanguageManager);
            NativeSourceView.GtkSharpSourceLanguageManagerGetLanguage(out sourceLanguageManager, out sourceLanguage, languageString);
            NativeSourceView.GtkSharpSourceBufferCreateWithLanguage(out buffer, out sourceLanguage);
            NativeSourceView.GtkSharpSourceViewCreateWithBuffer(out handle, out buffer);
            NativeSourceView.GtkSharpSourceViewSetTabWidth(out handle, 4);

            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {

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