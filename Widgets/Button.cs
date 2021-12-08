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

        private GtkButtonActivateCallback onButtonActivate;
        private GtkButtonClickedCallback onButtonClicked;
        private GtkButtonEnterCallback onButtonEnter;
        private GtkButtonLeaveCallback onButtonLeave;
        private GtkButtonPressedCallback onButtonPressed;
        private GtkButtonReleasedCallback onButtonReleased;
        
        public event ButtonActivateEvent onActivate;
        public event ButtonClickedEvent onClicked;
        public event ButtonEnterEvent onEnter;
        public event ButtonLeaveEvent onLeave;
        public event ButtonPressedEvent onPressed;
        public event ButtonReleasedEvent onReleased;

        public Button(string text)
        {
            this.text = text;
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreateWithLabel(out handle, text);            

            onButtonActivate = GtkSharpDelegate.Create<GtkButtonActivateCallback>(this, "OnActivate");
            onButtonClicked = GtkSharpDelegate.Create<GtkButtonClickedCallback>(this, "OnClicked");
            onButtonEnter = GtkSharpDelegate.Create<GtkButtonEnterCallback>(this, "OnEnter");
            onButtonLeave = GtkSharpDelegate.Create<GtkButtonLeaveCallback>(this, "OnLeave");
            onButtonPressed = GtkSharpDelegate.Create<GtkButtonPressedCallback>(this, "OnPressed");
            onButtonReleased = GtkSharpDelegate.Create<GtkButtonReleasedCallback>(this, "OnReleased");            
            
            Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onButtonActivate.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "clicked", onButtonClicked.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "enter", onButtonEnter.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "leave", onButtonLeave.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "pressed", onButtonPressed.ToIntPtr(), out handle.pointer);
            Gtk.GtkSharpSignalConnect(out handle.pointer, "released", onButtonReleased.ToIntPtr(), out handle.pointer);            
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

            NativeButton.GtkSharpButtonSetImage(out handle, out image.handle);
        }

        private void OnActivate(IntPtr widget, IntPtr data)
        {
            onActivate?.Invoke();
        }        

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClicked?.Invoke();
        }

        private void OnEnter(IntPtr widget, IntPtr data)
        {
            onEnter?.Invoke();
        }

        private void OnLeave(IntPtr widget, IntPtr data)
        {
            onLeave?.Invoke();
        }        

        private void OnPressed(IntPtr widget, IntPtr data)
        {
            onPressed?.Invoke();
        }

        private void OnReleased(IntPtr widget, IntPtr data)
        {
            onReleased?.Invoke();
        }        
    }
}