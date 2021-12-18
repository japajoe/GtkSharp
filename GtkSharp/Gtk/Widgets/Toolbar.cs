using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Toolbar : Container
    {
        public GtkToolbarStyle Style
        {
            get
            {
                return GetStyle();
            }
            set
            {
                SetStyle(value);
            }
        }

        public GtkIconSize IconSize
        {
            get
            {
                return GetIconSize();
            }
            set
            {
                SetIconSize(value);
            }
        }

        public GtkReliefStyle ReliefStyle
        {
            get
            {
                return GetReliefStyle();
            }
        }

        public bool show_arrow
        {
            get
            {
                return GetShowArrow();
            }
            set
            {
                SetShowArrow(value);
            }
        }

        public int ItemCount
        {
            get
            {
                return GetItemCount();
            }
        }

        public Toolbar()
        {
            handle = NativeToolbar.gtk_toolbar_new();
        }

        public void Insert(ToolItem item, int position)
        {
            if(handle.IsNullPointer)
                return;

            if(item.handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_insert(handle, item.handle, position);
        }

        public GtkToolbarStyle GetStyle()
        {
            if(handle.IsNullPointer)
                return GtkToolbarStyle.Icons;

            return NativeToolbar.gtk_toolbar_get_style(handle);
        }

        public void SetStyle(GtkToolbarStyle style)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_set_style(handle, style);
        }

        public void UnsetStyle()
        {
            if(handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_unset_style(handle);
        }

        public GtkIconSize GetIconSize()
        {
            if(handle.IsNullPointer)
                return GtkIconSize.SmallToolbar;

            return NativeToolbar.gtk_toolbar_get_icon_size(handle);
        }

        public void SetIconSize(GtkIconSize size)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_set_icon_size(handle, size);
        }

        public void UnsetIconSize()
        {
            if(handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_unset_icon_size(handle);
        }

        public GtkReliefStyle GetReliefStyle()
        {
            if(handle.IsNullPointer)
                return GtkReliefStyle.Normal;

            return NativeToolbar.gtk_toolbar_get_relief_style(handle);
        }

        public bool GetShowArrow()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolbar.gtk_toolbar_get_show_arrow(handle);
        }

        public void SetShowArrow(bool show)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolbar.gtk_toolbar_set_show_arrow(handle, show);
        }

        public int GetItemIndex(ToolItem item)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeToolbar.gtk_toolbar_get_item_index(handle, item.handle);
        }

        public int GetItemCount()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeToolbar.gtk_toolbar_get_n_items(handle);
        }

        public ToolItem GetItemAtIndex(int index)
        {
            if(handle.IsNullPointer)
                return null;

            GtkWidgetPointer w = NativeToolbar.gtk_toolbar_get_nth_item(handle, index);
            
            if(w.IsNullPointer)
                return null;

            ToolItem item = new ToolItem(w);
            return item;
        }
    }
}