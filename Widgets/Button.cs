using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : Widget
    {
        private StringBuilder stringBuilder;        
        private GtkCallback onButtonClickedNative;
        public event ButtonClickedEvent onClick;

        public Button()
        {
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreate(out handle.pointer);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);            
        }

        public Button(string text)
        {
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreateWithLabel(out handle.pointer, text);
            onButtonClickedNative = GtkSharpDelegate.Create<GtkCallback>(this, "OnClicked");
            Gtk.GtkSharpCallbackConnect(out handle.pointer, "clicked", onButtonClickedNative, out handle.pointer);
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            stringBuilder.Clear();

            int length = 0;
            NativeButton.GtkSharpButtonGetLabelLength(out handle.pointer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }

            NativeButton.GtkSharpButtonGetLabel(out handle.pointer, stringBuilder);

            string text = stringBuilder.ToString().Substring(0, (int)length);
            
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeButton.GtkSharpButtonSetLabel(out handle.pointer, text);
        }

        public void SetImage(Image image)
        {
            if(handle.IsNullPointer)
                return;

            if(image.handle.IsNullPointer)
                return;                

            NativeButton.GtkSharpButtonSetImage(out handle.pointer, out image.handle.pointer);
        }

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClick?.Invoke();
        }
    }
}