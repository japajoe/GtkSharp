using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public abstract class Bin : Container
    {
        public Widget GetChild()
        {
            GtkWidgetPointer w = NativeBin.gtk_bin_get_child(handle);
            
            if(w.IsNullPointer)
                return null;
                
            return new Widget(w.pointer);
        }
    }
}