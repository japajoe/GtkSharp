using System;
using GtkSharp.Native;
using GtkSharp.Native.Utilities;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class SaveFileDialog : FileChooserDialog
    {
        private bool confirmOverwrite = true;       

        public bool ConfirmOverwrite
        {
            get { return confirmOverwrite; }
            set { confirmOverwrite = value; }
        }

        public SaveFileDialog(Window parent) : base(parent)
        {
            this.title = "Save File";
        }

        public override GtkResponseType ShowDialog()
        {
            GtkResponseType response = GtkResponseType.None;

            handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                parent.handle,
                                                                GtkFileChooserAction.Save,
                                                                "_Cancel",
                                                                GtkResponseType.Cancel,
                                                                "_Save",
                                                                GtkResponseType.Accept,
                                                                IntPtr.Zero);

            NativeFileChooser.gtk_file_chooser_set_do_overwrite_confirmation(handle, confirmOverwrite);

            
            response = (GtkResponseType)NativeDialog.gtk_dialog_run(handle);

            if(response == GtkResponseType.Accept)
            {
                IntPtr ptr = NativeFileChooser.gtk_file_chooser_get_filename(handle);
                fileName = MarshalHelper.MarshalPtrToString(ptr);
                GLib.g_free(ptr);
            }
            
            this.Destroy();            

            return response;
        }
    }
}