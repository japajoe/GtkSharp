using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Label : Widget
    {
        private event LabelActivateCurrentLinkEvent onActivateCurrentLinkCallback;
        private event LabelActivateLinkEvent onActivateLinkCallback;
        private event LabelCopyClipboardEvent onCopyClipboardCallback;
        private event LabelMoveCursorEvent onMoveCursorCallback;
        private event LabelPopulatePopupEvent onPopulatePopupCallback;

        private GtkLabelActivateCurrentLinkCallback onLabelActivateCurrentLink;
        private GtkLabelActivateLinkCallback onLabelActivateLink;
        private GtkLabelCopyClipboardCallback onLabelCopyClipboard;
        private GtkLabelMoveCursorCallback onLabelMoveCursor;
        private GtkLabelPopulatePopupCallback onLabelPopulatePopup;

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
                return onActivateCurrentLinkCallback;
            }
            set
            {
                onActivateCurrentLinkCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelActivateCurrentLink.IsNullPointer())
                    {
                        onLabelActivateCurrentLink = OnActivateCurrentLink;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-current-link", onLabelActivateCurrentLink.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelActivateLinkEvent onActivateLink
        {
            get
            {
                return onActivateLinkCallback;
            }
            set
            {
                onActivateLinkCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelActivateLink.IsNullPointer())
                    {
                        onLabelActivateLink = OnActivateLink;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-link", onLabelActivateLink.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelCopyClipboardEvent onCopyClipboard
        {
            get
            {
                return onCopyClipboardCallback;
            }
            set
            {
                onCopyClipboardCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelCopyClipboard.IsNullPointer())
                    {
                        onLabelCopyClipboard = OnCopyClipboard;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onLabelCopyClipboard.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelMoveCursorEvent onMoveCursor
        {
            get
            {
                return onMoveCursorCallback;
            }
            set
            {
                onMoveCursorCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelMoveCursor.IsNullPointer())
                    {
                        onLabelMoveCursor = OnMoveCursor;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onLabelMoveCursor.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LabelPopulatePopupEvent onPopulatePopup
        {
            get
            {
                return onPopulatePopupCallback;
            }
            set
            {
                onPopulatePopupCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onLabelPopulatePopup.IsNullPointer())
                    {
                        onLabelPopulatePopup = OnPopulatePopup;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onLabelPopulatePopup.ToIntPtr(), out handle.pointer);
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
            onActivateCurrentLinkCallback?.Invoke();
        }

        void OnActivateLink(IntPtr widget, IntPtr uri, IntPtr data)
        {
            string u = MarshalHelper.MarshalPtrToString(uri);
            onActivateLinkCallback?.Invoke(u);
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            onCopyClipboardCallback?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            onMoveCursorCallback.Invoke(step, count);
        }

        void OnPopulatePopup(IntPtr widget, IntPtr menu, IntPtr data)
        {
            Menu m = new Menu(menu);
            onPopulatePopupCallback?.Invoke(m);
        }
    }
}