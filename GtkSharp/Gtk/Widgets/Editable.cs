using System;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class Editable : Widget
    {
        private GEventHandler<EditableChangedCallback,EditableChangedEvent> changedHandler = new GEventHandler<EditableChangedCallback, EditableChangedEvent>();

        public EditableChangedEvent Changed
        {
            get
            {
                return changedHandler.Event;
            }
            set
            {
                changedHandler.Event = value;
                changedHandler.SignalConnect(handle.pointer, "changed", OnChanged, handle.pointer);
            }
        }

        void OnChanged(IntPtr widget, IntPtr data)
        {
            Changed?.Invoke();
        }
    }
}