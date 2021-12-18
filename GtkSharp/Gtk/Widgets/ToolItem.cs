using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class ToolItem : Bin
    {
        private string tooltipText;

        public bool Homogeneous
        {
            get
            {
                return GetHomogeneous();
            }
            set
            {
                SetHomogeneous(value);
            }
        }

        public bool Expand
        {
            get
            {
                return GetExpand();
            }
            set
            {
                SetExpand(value);
            }
        }

        public string TooltipText
        {
            get
            {
                return tooltipText;
            }
            set
            {
                tooltipText = value;
                SetToolTipText(tooltipText);
            }
        }

        public ToolItem()
        {
            handle = NativeToolItem.gtk_tool_item_new();
        }

        public ToolItem(Widget widget)
        {
            handle = NativeToolItem.gtk_tool_item_new();
            Add(widget);
        }

        internal ToolItem(GtkWidgetPointer handle)
        {
            this.handle = handle;
        }

        public bool GetHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolItem.gtk_tool_item_get_homogeneous(handle);
        }

        public void SetHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeToolItem.gtk_tool_item_set_homogeneous(handle, homogeneous);
        }

        public bool GetExpand()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolItem.gtk_tool_item_get_expand(handle);
        }

        public void SetExpand(bool expand)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeToolItem.gtk_tool_item_set_expand(handle, expand);
        }

        public void SetToolTipText(string text)
        {
            if(handle.IsNullPointer)
                return;

            tooltipText = text;
            NativeToolItem.gtk_tool_item_set_tooltip_text(handle, text);
        }        
    }
}