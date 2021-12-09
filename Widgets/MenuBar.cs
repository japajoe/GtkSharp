using System;
using System.Collections.Generic;
using GtkSharp.Native;

namespace GtkSharp
{
    public class MenuBar : Widget
    {
        private GtkMenuItemActivateCallback onMenuItemActivateCallback;
        private List<MenuCreationInfo> menuInfo = new List<MenuCreationInfo>();
        private Dictionary<IntPtr,MenuItemActivateEvent> callbacks = new Dictionary<IntPtr, MenuItemActivateEvent>();

        public MenuBar()
        {
            Gtk.GtkSharpMenuBarCreate(out handle);
            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {
            onMenuItemActivateCallback = OnMenuItemClicked;
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
                Gtk.GtkSharpSignalConnect(out item.handle.pointer, "activate", onMenuItemActivateCallback.ToIntPtr(), out item.handle.pointer);
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

    public class MenuCreationInfo
    {    
        public string name;
        public List<string> items = new List<string>();
        public List<MenuItemActivateEvent> callbacks = new List<MenuItemActivateEvent>();

        public MenuCreationInfo(string name)
        {
            this.name = name;
        }

        public void AddItem(string itemName, MenuItemActivateEvent callback)
        {
            items.Add(itemName);
            callbacks.Add(callback);
        }
    };    
}