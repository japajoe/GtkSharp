using GtkSharp.Glib.Native.Types;
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

        public ToolItem(GObjectPointer handle)
        {
            this.handle = handle;
        }

        private bool GetHomogeneous()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolItem.gtk_tool_item_get_homogeneous(handle);
        }

        private void SetHomogeneous(bool homogeneous)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeToolItem.gtk_tool_item_set_homogeneous(handle, homogeneous);
        }

        private bool GetExpand()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToolItem.gtk_tool_item_get_expand(handle);
        }

        private void SetExpand(bool expand)
        {
            if(handle.IsNullPointer)
                return;
            
            NativeToolItem.gtk_tool_item_set_expand(handle, expand);
        }

        private void SetToolTipText(string text)
        {
            if(handle.IsNullPointer)
                return;

            tooltipText = text;
            NativeToolItem.gtk_tool_item_set_tooltip_text(handle, text);
        }        
    }
}