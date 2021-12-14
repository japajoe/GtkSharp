using System;
using GtkSharp.Utilities;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Label : Widget
    {
        private string text;

        private GEventHandler<LabelActivateCurrentLinkCallback,LabelActivateCurrentLinkEvent> activateCurrentLinkHandler = new GEventHandler<LabelActivateCurrentLinkCallback, LabelActivateCurrentLinkEvent>();
        private GEventHandler<LabelActivateLinkCallback,LabelActivateLinkEvent> activateLinkHandler = new GEventHandler<LabelActivateLinkCallback, LabelActivateLinkEvent>();
        private GEventHandler<LabelCopyClipboardCallback,LabelCopyClipboardEvent> copyClipboardHandler = new GEventHandler<LabelCopyClipboardCallback, LabelCopyClipboardEvent>();
        private GEventHandler<LabelMoveCursorCallback,LabelMoveCursorEvent> moveCursorHandler = new GEventHandler<LabelMoveCursorCallback, LabelMoveCursorEvent>();

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

        public LabelActivateCurrentLinkEvent ActivateCurrentLink
        {
            get
            {
                return activateCurrentLinkHandler.Event;
            }
            set
            {
                activateCurrentLinkHandler.Event = value;
                activateCurrentLinkHandler.SignalConnect(handle.pointer, "activate-current-link", OnActivateCurrentLink, handle.pointer);
            }
        }

        public LabelActivateLinkEvent ActivateLink
        {
            get
            {
                return activateLinkHandler.Event;
            }
            set
            {
                activateLinkHandler.Event = value;
                activateLinkHandler.SignalConnect(handle.pointer, "activate-link", OnActivateLink, handle.pointer);
            }
        }

        public LabelCopyClipboardEvent CopyClipboard
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

        public LabelMoveCursorEvent MoveCursor
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
            ActivateCurrentLink?.Invoke();
        }

        void OnActivateLink(IntPtr widget, IntPtr uri, IntPtr data)
        {
            string u = MarshalHelper.MarshalPtrToString(uri);
            ActivateLink?.Invoke(u);
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            CopyClipboard?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            MoveCursor.Invoke(step, count);
        }
    }
}