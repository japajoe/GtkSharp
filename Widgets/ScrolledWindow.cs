

using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class ScrolledWindow : Container
    {
        private GtkAdjustmentPointer hAdjustment;
        private GtkAdjustmentPointer vAdjustment;
        
        public ScrolledWindow(GtkPolicyType horizontalPolicy, GtkPolicyType verticalPolicy)
        {            
            handle = NativeScrolledWindow.gtk_scrolled_window_new(hAdjustment, hAdjustment);
            NativeScrolledWindow.gtk_scrolled_window_set_policy(handle, horizontalPolicy, verticalPolicy);
             
            hAdjustment = NativeScrolledWindow.gtk_scrolled_window_get_hadjustment(handle);
            vAdjustment = NativeScrolledWindow.gtk_scrolled_window_get_vadjustment(handle);
        }       
    }
}