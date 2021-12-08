using GtkSharp.Native;

namespace GtkSharp
{
    public class ScrolledWindow : Widget
    {
        private GtkAdjustmentPointer hAdjustment;
        private GtkAdjustmentPointer vAdjustment;

        public ScrolledWindow(GtkOrientation orientation, GtkPolicyType horizontalPolicy, GtkPolicyType verticalPolicy)
        {
            Gtk.GtkSharpScrolledWindowCreate(out handle, out hAdjustment.pointer, out vAdjustment.pointer, horizontalPolicy, verticalPolicy);
        }

        public void Add(Widget child)
        {
            if(handle.IsNullPointer)
                return;

            if(child.handle.IsNullPointer)
                return;

            Gtk.GtkSharpScrolledWindowAdd(out handle, out child.handle.pointer);            
        }

        public void GetScrollPosition(out double x, out double y)
        {
            double X, Y;
            Gtk.GtkSharpScrolledWindowGetScrollPosition(out handle, out hAdjustment.pointer, out vAdjustment.pointer, out X, out Y);
            x = X;
            y = Y;
        }
    }
}