using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class AboutDialog : Dialog
    {        
        public AboutDialog()
        {
            handle = NativeAboutDialog.gtk_about_dialog_new();
        }
    }
}