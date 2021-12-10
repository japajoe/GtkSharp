using System.Collections.Generic;
using GtkSharp.Native;

namespace GtkSharp
{
    public class MenuBar : Widget
    {
        private class MenuDefinition
        {
            public Menu menu;
            public MenuItem item;
            public List<MenuItem> items;

            public MenuDefinition(Menu menu, MenuItem item, List<MenuItem> items)
            {
                this.menu = menu;
                this.item = item;
                this.items = items;
            }
        }        
        
        private List<MenuDefinition> menus = new List<MenuDefinition>();

        public MenuBar()
        {
            Gtk.GtkSharpMenuBarCreate(out handle);
        }

        public void AddMenu(string name, List<MenuItem> items)
        {
            if(handle.IsNullPointer)
                return;
            
            Menu menu = new Menu();
            MenuItem item = new MenuItem(name);
            item.SetSubMenu(menu);
            ShellAppend(item);

            for(int i = 0; i < items.Count; i++)
            {
                menu.ShellAppend(items[i]);
            }

            MenuDefinition definition = new MenuDefinition(menu, item, items);
            menus.Add(definition);
        }

        public void ShellAppend(MenuItem menuItem)
        {
            if(handle.IsNullPointer)
                return;
                
            Gtk.GtkSharpMenuShellAppend(out handle.pointer, out menuItem.handle.pointer);
        }
    } 
}