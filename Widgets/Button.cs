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
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);            
        }

        public Button(string text, int width, int height)
        {
            Gtk.GtkSharpButtonCreate(out handle.pointer, text);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);            
            SetSize(width, height);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpButtonSetText(out handle.pointer, text);
        }

        public void SetImage(Image image)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpButtonSetImage(out handle.pointer, out image.handle.pointer);
        }

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClick?.Invoke();
        }
    }
}