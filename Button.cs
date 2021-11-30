using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class Button : Widget
    {
        private GtkCallback onButtonClickedNative;
        public event ButtonClickedEvent onClick;

        public Button()
        {
            Gtk.GtkSharpButtonCreate(out handle.pointer, "Button");
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpSignalConnect(out handle.pointer, "clicked", onButtonClickedNative);            
        }

        public Button(string text, int width, int height)
        {
            Gtk.GtkSharpButtonCreate(out handle.pointer, text);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpSignalConnect(out handle.pointer, "clicked", onButtonClickedNative);            
            SetSize(width, height);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpButtonSetText(out handle.pointer, text);
        }

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClick?.Invoke();
        }
    }
}