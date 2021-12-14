using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : ButtonBase
    {        
        public Button()
        {
            handle = NativeButton.gtk_button_new();
        }

        public Button(string stockId)
        {
            handle = NativeButton.gtk_button_new_from_stock(stockId);
        }

        public Button(string iconName, GtkIconSize size)
        {
            handle = NativeButton.gtk_button_new_from_icon_name(iconName, size);
        }
    }
}