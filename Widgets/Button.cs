using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : Widget
    {
        private StringBuilder stringBuilder;
        private string text = string.Empty;
        private GtkCallback onButtonClickedNative;
        public event ButtonClickedEvent onClick;

        public Button()
        {
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreate(out handle);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);            
        }

        public Button(string text)
        {
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreateWithLabel(out handle, text);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return this.text;

            stringBuilder.Clear();

            int length = 0;
            NativeButton.GtkSharpButtonGetLabelLength(out handle, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }

            NativeButton.GtkSharpButtonGetLabel(out handle, stringBuilder);

            this.text = stringBuilder.ToString().Substring(0, (int)length);
            
            return this.text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            this.text = text;
            NativeButton.GtkSharpButtonSetLabel(out handle, text);
        }

        public void SetImage(Image image)
        {
            if(handle.IsNullPointer)
                return;

            if(image.handle.IsNullPointer)
                return;                

            NativeButton.GtkSharpButtonSetImage(out handle, out image.handle.pointer);
        }

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClick?.Invoke();
        }
    }
}