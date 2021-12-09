using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Label : Widget
    {
        public event LabelActivateCurrentLinkEvent onActivateCurrentLink;
        public event LabelActivateLinkEvent onActivateLink;
        public event LabelCopyClipboardEvent onCopyClipboard;
        public event LabelMoveCursorEvent onMoveCursor;
        public event LabelPopulatePopupEvent onPopulatePopup;

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

        public Label()
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, "Label");

            RegisterCallbacks();
        }

        public Label(string text)
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, text);

            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {
            onLabelActivateCurrentLink = OnActivateCurrentLink;
            onLabelActivateLink = OnActivateLink;
            onLabelCopyClipboard = OnCopyClipboard;
            onLabelMoveCursor = OnMoveCursor;
            onLabelPopulatePopup = OnPopulatePopup;

            Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-current-link", onLabelActivateCurrentLink.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "activate-link", onLabelActivateLink.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "copy-clipboard", onLabelCopyClipboard.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "move-cursor", onLabelMoveCursor.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "populate-popup", onLabelPopulatePopup.ToIntPtr(), out handle.pointer);
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
            onActivateCurrentLink?.Invoke();
        }

        void OnActivateLink(IntPtr widget, IntPtr uri, IntPtr data)
        {
            string u = MarshalHelper.MarshalPtrToString(uri);
            onActivateLink?.Invoke(u);
        }

        void OnCopyClipboard(IntPtr widget, IntPtr data)
        {
            onCopyClipboard?.Invoke();
        }

        void OnMoveCursor(IntPtr widget, GtkMovementStep step, int count, bool extendSelection, IntPtr data)
        {
            onMoveCursor.Invoke(step, count);
        }

        void OnPopulatePopup(IntPtr widget, IntPtr menu, IntPtr data)
        {
            Menu m = new Menu(menu);
            onPopulatePopup?.Invoke(m);
        }
    }
}