using GtkSharp.Native;

namespace GtkSharp
{
    public class ColorChooserDialog : Widget
    {
        private Window parent;
        private GdkRGBA color;
        private string title;

        public GdkRGBA Color
        {
            get { return color; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public ColorChooserDialog(Window parent)
        {
            this.parent = parent;
        }

        public GtkResponseType ShowDialog()
        {
            GtkResponseType response = GtkResponseType.None;

            Gtk.GtkSharpColorChooserDialogCreate(out handle,
                                                out parent.handle.pointer,
                                                title);

            Gtk.GtkSharpDialogRun(out handle, out response);

            if(response == GtkResponseType.Ok)
            {
                Gtk.GtkSharpColorChooserGetRGBA(out handle, out color);
            }
            
            this.Destroy();            

            return response;
        }
    }
}