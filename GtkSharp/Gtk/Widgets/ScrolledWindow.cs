using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class ScrolledWindow : Bin
    {
        private GtkAdjustmentPointer hAdjustment;
        private GtkAdjustmentPointer vAdjustment;

        public ScrolledWindow()
        {
            
        }
        
        public ScrolledWindow(GtkPolicyType horizontalPolicy, GtkPolicyType verticalPolicy)
        {            
            handle = NativeScrolledWindow.gtk_scrolled_window_new(hAdjustment, hAdjustment);
            NativeScrolledWindow.gtk_scrolled_window_set_policy(handle, horizontalPolicy, verticalPolicy);
             
            hAdjustment = NativeScrolledWindow.gtk_scrolled_window_get_hadjustment(handle);
            vAdjustment = NativeScrolledWindow.gtk_scrolled_window_get_vadjustment(handle);
        }       
    }
}