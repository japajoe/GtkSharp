using System;
using GtkSharp.Native;

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
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onMenuItemActivateCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public MenuItem(string label)
        {
            Gtk.GtkSharpMenuItemCreateWithlabel(out handle, label);
        }

        public void SetSubMenu(Menu menu)
        {
            Gtk.GtkSharpMenuItemSetSubMenu(out handle.pointer, out menu.handle.pointer);
        }

        private void OnActivate(IntPtr widget, IntPtr data)
        {
            onActivate?.Invoke();
        }        
    }
}