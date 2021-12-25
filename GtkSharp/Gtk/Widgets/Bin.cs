using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public abstract class Bin : Container
    {
        public Widget GetChild()
        {
            var w = NativeBin.gtk_bin_get_child(handle);
            
            if(w.IsNullPointer)
                return null;
                
            return new Widget(w.pointer);
        }
    }
}