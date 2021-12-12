using System;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Utilities;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Label : Widget
    {
        private string text;

        private event LabelActivateCurrentLinkEvent onActivateCurrentLinkEvent;
        private event LabelActivateLinkEvent onActivateLinkEvent;
        private event LabelCopyClipboardEvent onCopyClipboardEvent;
        private event LabelMoveCursorEvent onMoveCursorEvent;

        private GtkLabelActivateCurrentLinkCallback onLabelActivateCurrentLinkCallback;
        private GtkLabelActivateLinkCallback onLabelActivateLinkCallback;
        private GtkLabelCopyClipboardCallback onLabelCopyClipboardCallback;
        private GtkLabelMoveCursorCallback onLabelMoveCursorCallback;

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
                        GLib.g_signal_connect(handle.pointer, "activate-current-link", onLabelActivateCurrentLinkCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "activate-link", onLabelActivateLinkCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "copy-clipboard", onLabelCopyClipboardCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "move-cursor", onLabelMoveCursorCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public Label(string text)
        {
            handle = NativeLabel.gtk_label_new(text);            
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            text = NativeLabel.gtk_label_get_text(handle);
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeLabel.gtk_label_set_text(handle, text);
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
    }
}