using GtkSharp.Native;

namespace GtkSharp
{
    public class Label : Widget
    {
        public Label()
        {
            Gtk.GtkSharpLabelCreate(out handle.pointer, "Label");
        }

        public Label(string text)
        {
            Gtk.GtkSharpLabelCreate(out handle.pointer, text);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLabelSetText(out handle.pointer, text);
        }
    }
}