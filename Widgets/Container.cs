using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Container : Widget
    {
        public void Add(Widget widget)
        {
            if(handle.IsNullPointer)
                return;
            NativeContainer.gtk_container_add(handle, widget.handle);
        }

        public void Remove(Widget widget)
        {
            if(handle.IsNullPointer)
                return;
            NativeContainer.gtk_container_remove(handle, widget.handle);
        }
    }
}