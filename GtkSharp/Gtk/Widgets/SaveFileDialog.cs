using System;
using GtkSharp.Utilities;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Native;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class SaveFileDialog : FileChooserDialog
    {
        public bool ConfirmToOverwrite
        {
            get 
            { 
                return GetDoOverwriteConfirmation();
            }
            set 
            { 
                SetDoOverwriteConfirmation(value);
            }
        }

        public SaveFileDialog(Window parent) : base(parent)
        {
            this.title = "Save File";

            handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                parent.handle,
                                                                GtkFileChooserAction.Save,
                                                                "_Cancel",
                                                                GtkResponseType.Cancel,
                                                                "_Save",
                                                                GtkResponseType.Accept,
                                                                IntPtr.Zero);

            NativeFileChooser.gtk_file_chooser_set_do_overwrite_confirmation(handle, true);
        }

        private bool GetDoOverwriteConfirmation()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeFileChooser.gtk_file_chooser_get_do_overwrite_confirmation(handle);
        }

        private void SetDoOverwriteConfirmation(bool confirm)
        {
            if(handle.IsNullPointer)
                return;

            NativeFileChooser.gtk_file_chooser_set_do_overwrite_confirmation(handle, confirm);
        }

        public override GtkResponseType ShowDialog()
        {
            if(handle.IsNullPointer)
            {
                handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                    parent.handle,
                                                                    GtkFileChooserAction.Save,
                                                                    "_Cancel",
                                                                    GtkResponseType.Cancel,
                                                                    "_Save",
                                                                    GtkResponseType.Accept,
                                                                    IntPtr.Zero);

                NativeFileChooser.gtk_file_chooser_set_do_overwrite_confirmation(handle, true);
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