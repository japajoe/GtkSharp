using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Label : Widget
    {
        private event LabelActivateCurrentLinkEvent onActivateCurrentLinkEvent;
        private event LabelActivateLinkEvent onActivateLinkEvent;
        private event LabelCopyClipboardEvent onCopyClipboardEvent;
        private event LabelMoveCursorEvent onMoveCursorEvent;
        private event LabelPopulatePopupEvent onPopulatePopupEvent;

        private GtkLabelActivateCurrentLinkCallback onLabelActivateCurrentLinkCallback;
        private GtkLabelActivateLinkCallback onLabelActivateLinkCallback;
        private GtkLabelCopyClipboardCallback onLabelCopyClipboardCallback;
        private GtkLabelMoveCursorCallback onLabelMoveCursorCallback;
        private GtkLabelPopulatePopupCallback onLabelPopulatePopupCallback;

        private StringBuilder stringBuilder;
        private string text;

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

        public LabelActivateCurrentLinkEvent onActivateCurrentLink
        {
            get
            {
                return onActivateCurrentLinkEvent;
            }
            set
            {
                onActivateCurrentLinkEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelActivateCurrentLinkCallback.IsNullPointer())
                    {
                        onLabelActivateCurrentLinkCallback = OnActivateCurrentLink;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-current-link", onLabelActivateCurrentLinkCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelActivateLinkEvent onActivateLink
        {
            get
            {
                return onActivateLinkEvent;
            }
            set
            {
                onActivateLinkEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelActivateLinkCallback.IsNullPointer())
                    {
                        onLabelActivateLinkCallback = OnActivateLink;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-link", onLabelActivateLinkCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardEvent;
            }
            set
            {
                onCopyClipboardEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelCopyClipboardCallback.IsNullPointer())
                    {
                        onLabelCopyClipboardCallback = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onLabelCopyClipboardCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorEvent;
            }
            set
            {
                onMoveCursorEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelMoveCursorCallback.IsNullPointer())
                    {
                        onLabelMoveCursorCallback = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onLabelMoveCursorCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupEvent;
            }
            set
            {
                onPopulatePopupEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelPopulatePopupCallback.IsNullPointer())
                    {
                        onLabelPopulatePopupCallback = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onLabelPopulatePopupCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public Label()
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, "Label");
        }

        public Label(string text)
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, text);
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;
            
            int length;

            NativeLabel.GtkSharpLabelGetTextLength(out handle, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }            

            NativeLabel.GtkSharpLabelGetText(out handle, stringBuilder);
            this.text = stringBuilder.ToString().Substring(0, length);
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeLabel.GtkSharpLabelSetText(out handle, text);
            this.text = text;
        }

        void OnActivateCurrentLink(IntPtr widget, IntPtr data)
        {
            onActivateCurrentLinkEvent?.Invoke();
        }

        void OnActivateLink(IntPtr widget, IntPtr uri, IntPtr data)
        {
            string u = MarshalHelper.MarshalPtrToString(uri);
            onActivateLinkEvent?.Invoke(u);
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            onCopyClipboardEvent?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            onMoveCursorEvent.Invoke(step, count);
        }

        void OnPopulatePopup(IntPtr widget, IntPtr menu, IntPtr data)
        {
            Menu m = new Menu(menu);
            onPopulatePopupEvent?.Invoke(m);
        }
    }
}