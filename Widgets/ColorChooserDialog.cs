using GtkSharp.Native.Widgets;

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

            handle = NativeColorChooserDialog.gtk_color_chooser_dialog_new(title, parent.handle);

            response = (GtkResponseType)NativeDialog.gtk_dialog_run(handle);            

            if(response == GtkResponseType.Ok)
            {
                NativeColorChooser.gtk_color_chooser_get_rgba(handle, out color);
            }
            
            this.Destroy();            

            return response;
        }
    }
}