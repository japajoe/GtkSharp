using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class MenuItem : Widget
    {
        private GEventHandler<MenuItemActivateCallback,MenuItemActivateEvent> activateHandler = new GEventHandler<MenuItemActivateCallback, MenuItemActivateEvent>();

        public MenuItemActivateEvent Activate
        {
            get
            {
                return activateHandler.Event;
            }
            set
            {
                activateHandler.Event = value;
                activateHandler.SignalConnect(handle.pointer, "activate", OnActivate, handle.pointer);
            }
        }

        public MenuItem(string label)
        {
            handle = NativeMenuItem.gtk_menu_item_new_with_label(label);
        }

        public void SetSubMenu(Menu menu)
        {
            NativeMenuItem.gtk_menu_item_set_submenu(handle, menu.Handle);
        }

        private void OnActivate(IntPtr widget, IntPtr data)
        {
            Activate?.Invoke();
        }        
    }
}