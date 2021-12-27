using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class ToolBar : Container
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

        public bool ShowArrow
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

        public ToolBar()
        {
            handle = NativeToolBar.gtk_toolbar_new();
        }

        public void Insert(ToolItem item, int position)
        {
            if(handle.IsNullPointer)
                return;

            if(item.handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_insert(handle, item.handle, position);
        }

        private GtkToolbarStyle GetStyle()
        {
            if(handle.IsNullPointer)
                return GtkToolbarStyle.Icons;

            return NativeToolBar.gtk_toolbar_get_style(handle);
        }

        private void SetStyle(GtkToolbarStyle style)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_set_style(handle, style);
        }

        public void UnsetStyle()
        {
            if(handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_unset_style(handle);
        }

        private GtkIconSize GetIconSize()
        {
            if(handle.IsNullPointer)
                return GtkIconSize.SmallToolbar;

            return NativeToolBar.gtk_toolbar_get_icon_size(handle);
        }

        private void SetIconSize(GtkIconSize size)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_set_icon_size(handle, size);
        }

        public void UnsetIconSize()
        {
            if(handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_unset_icon_size(handle);
        }

        private GtkReliefStyle GetReliefStyle()
        {
            if(handle.IsNullPointer)
                return GtkReliefStyle.Normal;

            return NativeToolBar.gtk_toolbar_get_relief_style(handle);
        }

        private bool GetShowArrow()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolBar.gtk_toolbar_get_show_arrow(handle);
        }

        private void SetShowArrow(bool show)
        {
            if(handle.IsNullPointer)
                return;

            NativeToolBar.gtk_toolbar_set_show_arrow(handle, show);
        }

        public int GetItemIndex(ToolItem item)
        {
            if(handle.IsNullPointer)
                return -1;
            
            return NativeToolBar.gtk_toolbar_get_item_index(handle, item.handle);
        }

        private int GetItemCount()
        {
            if(handle.IsNullPointer)
                return 0;
            return NativeToolBar.gtk_toolbar_get_n_items(handle);
        }

        public ToolItem GetItemAtIndex(int index)
        {
            if(handle.IsNullPointer)
                return null;

            var w = NativeToolBar.gtk_toolbar_get_nth_item(handle, index);
            
            if(w.IsNullPointer)
                return null;

            ToolItem item = new ToolItem(w);
            return item;
        }
    }
}