using GtkSharp.Gdk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class ColorChooserDialog : Dialog
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
            handle = NativeColorChooserDialog.gtk_color_chooser_dialog_new(title, parent.Handle);
        }

        public GtkResponseType ShowDialog()
        {
            if(handle.IsNullPointer)
                handle = NativeColorChooserDialog.gtk_color_chooser_dialog_new(title, parent.Handle);

            GtkResponseType response = (GtkResponseType)NativeDialog.gtk_dialog_run(handle);            

            if(response == GtkResponseType.Ok)
            {
                NativeColorChooser.gtk_color_chooser_get_rgba(handle, out color);
            }
            
            this.Destroy();            

            return response;
        }
    }
}