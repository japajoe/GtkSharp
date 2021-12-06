using GtkSharp.Native;

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

            Gtk.GtkSharpFileChooserDialogCreate(out handle,
                                                out parent.handle,
                                                title,
                                                GtkFileChooserAction.Save,
                                                "_Cancel",
                                                GtkResponseType.Cancel,
                                                "_Save",
                                                GtkResponseType.Accept);

            Gtk.GtkSharpFileChooserSetOverwriteConfirmation(out handle, confirmOverwrite);
            Gtk.GtkSharpDialogRun(out handle, out response);

            if(response == GtkResponseType.Accept)
            {
                int length = 0;
                Gtk.GtkSharpFileChooserGetFileNameLength(out handle, out length);

                if(length > 0)
                {
                    if(length > stringBuilder.Capacity)
                    {
                        stringBuilder.Capacity = length;
                        stringBuilder.EnsureCapacity(length);
                    }
                    
                    stringBuilder.Clear();
                    Gtk.GtkSharpFileChooserGetFileName(out handle, stringBuilder);
                    fileName = stringBuilder.ToString().Substring(0, length);
                }
            }
            
            this.Destroy();            

            return response;
        }
    }
}