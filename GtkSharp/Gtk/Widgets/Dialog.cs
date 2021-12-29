using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Dialog : Window
    {
        private GEventHandler<DialogCloseCallback,DialogCloseEvent> closeHandler = new GEventHandler<DialogCloseCallback, DialogCloseEvent>();
        private GEventHandler<DialogResponseCallback,DialogResponseEvent> responseHandler = new GEventHandler<DialogResponseCallback, DialogResponseEvent>();

        public DialogCloseEvent Closing
        {
            get
            {
                return closeHandler.Event;
            }
            set
            {
                closeHandler.Event = value;
                closeHandler.SignalConnect(handle.pointer, "close", OnClosing, handle.pointer);
            }
        }

        public DialogResponseEvent Response
        {
            get
            {
                return responseHandler.Event;
            }
            set
            {
                responseHandler.Event = value;
                responseHandler.SignalConnect(handle.pointer, "response", OnResponse, handle.pointer);
            }
        }        
        
        public Dialog()
        {
            handle = NativeDialog.gtk_dialog_new();
        }

        public Dialog(string title, Window parent, GtkDialogFlags flags, string fbText, GtkResponseType fbResponse, string sbText, GtkResponseType sbResponse)
        {
            handle = NativeDialog.gtk_dialog_new_with_buttons(title, parent.Handle, flags, fbText, fbResponse, sbText, sbResponse);
        }

        private void OnClosing(IntPtr widget, IntPtr data)
        {
            Closing?.Invoke();
        }

        private void OnResponse(IntPtr widget, int responseId, IntPtr data)
        {
            Response?.Invoke(responseId);
        }
    }
}