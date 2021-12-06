using GtkSharp.Native;

namespace GtkSharp
{
    public class Label : Widget
    {
        public Label()
        {
            Gtk.GtkSharpLabelCreate(out handle, "Label");
        }

        public Label(string text)
        {
            Gtk.GtkSharpLabelCreate(out handle, text);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLabelSetText(out handle, text);
        }
    }
}