using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : Widget
    {
        private event ButtonActivateEvent onActivateCallback;
        private event ButtonClickedEvent onClickedCallback;
        private event ButtonEnterEvent onEnterCallback;
        private event ButtonLeaveEvent onLeaveCallback;
        private event ButtonPressedEvent onPressedCallback;
        private event ButtonReleasedEvent onReleasedCallback;

        private StringBuilder stringBuilder;
        private string text = string.Empty;
        private GtkButtonActivateCallback onButtonActivate;
        private GtkButtonClickedCallback onButtonClicked;
        private GtkButtonEnterCallback onButtonEnter;
        private GtkButtonLeaveCallback onButtonLeave;
        private GtkButtonPressedCallback onButtonPressed;
        private GtkButtonReleasedCallback onButtonReleased;

        public ButtonActivateEvent onActivate
        {
            get
            {
                return onActivateCallback;
            }
            set
            {
                onActivateCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonActivate.IsNullPointer())
                    {
                        onButtonActivate = OnActivate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onButtonActivate.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonClickedEvent onClicked
        {
            get
            {
                return onClickedCallback;
            }
            set
            {
                onClickedCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonClicked.IsNullPointer())
                    {
                        onButtonClicked = OnClicked;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "clicked", onButtonClicked.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonEnterEvent onEnter
        {
            get
            {
                return onEnterCallback;
            }
            set
            {
                onEnterCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonEnter.IsNullPointer())
                    {
                        onButtonEnter = OnEnter;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "enter", onButtonEnter.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonLeaveEvent onLeave
        {
            get
            {
                return onLeaveCallback;
            }
            set
            {
                onLeaveCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonLeave.IsNullPointer())
                    {
                        onButtonLeave = OnLeave;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "leave", onButtonLeave.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonPressedEvent onPressed
        {
            get
            {
                return onPressedCallback;
            }
            set
            {
                onPressedCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonPressed.IsNullPointer())
                    {
                        onButtonPressed = OnPressed;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "pressed", onButtonPressed.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonReleasedEvent onReleased
        {
            get
            {
                return onReleasedCallback;
            }
            set
            {
                onReleasedCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonReleased.IsNullPointer())
                    {
                        onButtonReleased = OnReleased;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "released", onButtonReleased.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public Button(string text)
        {
            this.text = text;
            stringBuilder = new StringBuilder(1024);
            NativeButton.GtkSharpButtonCreateWithLabel(out handle, text);
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
            onActivateCallback?.Invoke();
        }        

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClickedCallback?.Invoke();
        }

        private void OnEnter(IntPtr widget, IntPtr data)
        {
            onEnterCallback?.Invoke();
        }

        private void OnLeave(IntPtr widget, IntPtr data)
        {
            onLeaveCallback?.Invoke();
        }        

        private void OnPressed(IntPtr widget, IntPtr data)
        {
            onPressedCallback?.Invoke();
        }

        private void OnReleased(IntPtr widget, IntPtr data)
        {
            onReleasedCallback?.Invoke();
        }        
    }
}