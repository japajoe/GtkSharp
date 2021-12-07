using System;
using System.Collections.Generic;
using GtkSharp.Native;

namespace GtkSharp
{
    public class MenuBar : Widget
    {
        private GtkCallback onMenuItemClickedNative;
        private List<MenuCreationInfo> menuInfo = new List<MenuCreationInfo>();
        private Dictionary<IntPtr,MenuItemClickedEvent> callbacks = new Dictionary<IntPtr, MenuItemClickedEvent>();

        public MenuBar()
        {
            Gtk.GtkSharpMenuBarCreate(out handle);
            onMenuItemClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnMenuItemClicked");
        }
        
        public void AddMenu(MenuCreationInfo info)
        {
            if(handle.IsNullPointer)
                return;

            menuInfo.Add(info);
            int currentIndex = menuInfo.Count - 1;

            Menu menuWidget = new Menu();
            MenuItem menuItem = new MenuItem(info.name);

            menuItem.SetSubMenu(menuWidget);
            this.ShellAppend(menuItem);
            
            for(int i = 0; i < menuInfo[currentIndex].items.Count; i++)
            {
                int index = i;
                MenuItem item = new MenuItem(menuInfo[currentIndex].items[i]);
                menuWidget.ShellAppend(item);
                callbacks.Add(item.handle.pointer, menuInfo[currentIndex].callbacks[index]);
                Gtk.GtkSharpSignalConnect(out item.handle.pointer, "activate", onMenuItemClickedNative.ToIntPtr(), out item.handle.pointer);
            }
        }

        public void ShellAppend(MenuItem menuItem)
        {
            Gtk.GtkSharpMenuShellAppend(out handle.pointer, out menuItem.handle.pointer);
        }

        private void OnMenuItemClicked(IntPtr widget, IntPtr data)
        {
            if(callbacks.ContainsKey(data))
            {
                callbacks[data]?.Invoke();
            }
        }
    }

    public class Menu : Widget
    {
        public Menu()
        {
            Gtk.GtkSharpMenuCreate(out handle);
        }

        public void ShellAppend(MenuItem menuItem)
        {
            Gtk.GtkSharpMenuShellAppend(out handle.pointer, out menuItem.handle.pointer);
        }
    }

    public class MenuItem : Widget
    {
        public MenuItem(string label)
        {
            Gtk.GtkSharpMenuItemCreateWithlabel(out handle, label);
        }

        public void SetSubMenu(Menu menu)
        {
            Gtk.GtkSharpMenuItemSetSubMenu(out handle.pointer, out menu.handle.pointer);
        }
    }

    public class MenuCreationInfo
    {    
        public string name;
        public List<string> items = new List<string>();
        public List<MenuItemClickedEvent> callbacks = new List<MenuItemClickedEvent>();

        public MenuCreationInfo(string name)
        {
            this.name = name;
        }

        public void AddItem(string itemName, MenuItemClickedEvent callback)
        {
            items.Add(itemName);
            callbacks.Add(callback);
        }
    };    
}