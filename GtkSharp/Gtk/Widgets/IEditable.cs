using System;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public interface IEditable
    {
        EditableChangedEvent Changed
        {
            get;
            set;
        }

        private void OnChanged(IntPtr widget, IntPtr data)
        {

        }
    }
}