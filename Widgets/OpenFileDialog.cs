using GtkSharp.Native;

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

            Gtk.GtkSharpFileChooserDialogCreate(out handle,
                                                out parent.handle,
                                                title,
                                                GtkFileChooserAction.Open,
                                                "_Cancel",
                                                GtkResponseType.Cancel,
                                                "_Open",
                                                GtkResponseType.Accept);

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