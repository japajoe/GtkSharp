using System;
using GtkSharp.Utilities;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Native;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class OpenFileDialog : FileChooserDialog
    {
        public OpenFileDialog(Window parent) : base(parent)
        {
            this.title = "Open File";

            handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                parent.handle,
                                                                GtkFileChooserAction.Open,
                                                                "_Cancel",
                                                                GtkResponseType.Cancel,
                                                                "_Open",
                                                                GtkResponseType.Accept,
                                                                IntPtr.Zero);            
        }

        public override GtkResponseType ShowDialog()
        {
            if(handle.IsNullPointer)
            {
                handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                    parent.handle,
                                                                    GtkFileChooserAction.Open,
                                                                    "_Cancel",
                                                                    GtkResponseType.Cancel,
                                                                    "_Open",
                                                                    GtkResponseType.Accept,
                                                                    IntPtr.Zero);  
            }

            GtkResponseType response = (GtkResponseType)NativeDialog.gtk_dialog_run(handle);
            
            if(response == GtkResponseType.Accept)
            {
                IntPtr ptr = NativeFileChooser.gtk_file_chooser_get_filename(handle);
                fileName = MarshalHelper.MarshalPtrToString(ptr);
                GLibLib.g_free(ptr);
            }
            
            this.Destroy();

            return response;
        }
    }
}