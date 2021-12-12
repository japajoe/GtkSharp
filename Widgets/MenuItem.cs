using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class MenuItem : Widget
    {
        private event MenuItemActivateEvent onActivateEvent;
        private GtkMenuItemActivateCallback onMenuItemActivateCallback;

        public MenuItemActivateEvent onActivate
        {
            get
            {
                return onActivateEvent;
            }
            set
            {
                onActivateEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onMenuItemActivateCallback.IsNullPointer())
                    {
                        onMenuItemActivateCallback = OnActivate;
                        GLib.g_signal_connect(handle.pointer, "activate", onMenuItemActivateCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public MenuItem(string label)
        {
            handle = NativeMenuItem.gtk_menu_item_new_with_label(label);
        }

        public void SetSubMenu(Menu menu)
        {
            NativeMenuItem.gtk_menu_item_set_submenu(handle, menu.handle);
        }

        private void OnActivate(IntPtr widget, IntPtr data)
        {
            onActivate?.Invoke();
        }        
    }
}