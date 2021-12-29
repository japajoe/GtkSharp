using System;
using GtkSharp.Gdk.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Types
{
    public class GtkClipboard : GObject
    {
        private GEventHandler<ClipboardTextReceivedCallback,ClipboardTextReceivedEvent> textReceivedHandler = new GEventHandler<ClipboardTextReceivedCallback, ClipboardTextReceivedEvent>();
        private GdkDisplay display;

        public ClipboardTextReceivedEvent TextReceived
        {
            get
            {
                return textReceivedHandler.Event;
            }
            set
            {
                textReceivedHandler.Event = value;
            }
        }

        public GtkClipboard()
        {
            display = new GdkDisplay();            
            handle = NativeClipboard.gtk_clipboard_get_default(display.Handle);
            textReceivedHandler.Callback = OnTextReceived;
        }

        public GtkClipboard(GdkDisplay display)
        {
            this.display = display;
            handle = NativeClipboard.gtk_clipboard_get_default(display.Handle);
            textReceivedHandler.Callback = OnTextReceived;
        }

        public void RequestText()
        {
            if(handle.IsNullPointer)
                return;
            
            NativeClipboard.gtk_clipboard_request_text(handle, textReceivedHandler.Callback.ToIntPtr(), handle.pointer);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeClipboard.gtk_clipboard_set_text(handle, text, text.Length);
        }

        public void Clear()
        {
            if(handle.IsNullPointer)
                return;
            
            NativeClipboard.gtk_clipboard_clear(handle);
        }

        private void OnTextReceived(IntPtr clipboard, string text, IntPtr data)
        {
            TextReceived?.Invoke(text);
        }
    }
}