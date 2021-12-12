using System;
using GtkSharp.Native.Utilities;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class OpenFileDialog : FileChooserDialog
    {
        public OpenFileDialog(Window parent) : base(parent)
        {
            this.title = "Open File";
        }

        public override GtkResponseType ShowDialog()
        {
            GtkResponseType response = GtkResponseType.None;

            handle = NativeFileChooserDialog.gtk_file_chooser_dialog_new(title,
                                                                parent.handle,
                                                                GtkFileChooserAction.Open,
                                                                "_Cancel",
                                                                GtkResponseType.Cancel,
                                                                "_Open",
                                                                GtkResponseType.Accept,
                                                                IntPtr.Zero);

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