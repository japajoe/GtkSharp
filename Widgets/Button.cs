using System;
using System.Text;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Button : Widget
    {
        private event ButtonActivateEvent onActivateEvent;
        private event ButtonClickedEvent onClickedEvent;
        private event ButtonEnterEvent onEnterEvent;
        private event ButtonLeaveEvent onLeaveCallEvent;
        private event ButtonPressedEvent onPressedEvent;
        private event ButtonReleasedEvent onReleasedEvent;

        private StringBuilder stringBuilder;
        private string text = string.Empty;
        private GtkButtonActivateCallback onButtonActivateCallback;
        private GtkButtonClickedCallback onButtonClickedCallback;
        private GtkButtonEnterCallback onButtonEnterCallback;
        private GtkButtonLeaveCallback onButtonLeaveCallback;
        private GtkButtonPressedCallback onButtonPressedCallback;
        private GtkButtonReleasedCallback onButtonReleasedCallback;

        public ButtonActivateEvent onActivate
        {
            get
            {
                return onActivateEvent;
            }
            set
            {
                onActivateEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonActivateCallback.IsNullPointer())
                    {
                        onButtonActivateCallback = OnActivate;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "activate", onButtonActivateCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonClickedEvent onClicked
        {
            get
            {
                return onClickedEvent;
            }
            set
            {
                onClickedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonClickedCallback.IsNullPointer())
                    {
                        onButtonClickedCallback = OnClicked;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "clicked", onButtonClickedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonEnterEvent onEnter
        {
            get
            {
                return onEnterEvent;
            }
            set
            {
                onEnterEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonEnterCallback.IsNullPointer())
                    {
                        onButtonEnterCallback = OnEnter;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "enter", onButtonEnterCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonLeaveEvent onLeave
        {
            get
            {
                return onLeaveCallEvent;
            }
            set
            {
                onLeaveCallEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonLeaveCallback.IsNullPointer())
                    {
                        onButtonLeaveCallback = OnLeave;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "leave", onButtonLeaveCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonPressedEvent onPressed
        {
            get
            {
                return onPressedEvent;
            }
            set
            {
                onPressedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonPressedCallback.IsNullPointer())
                    {
                        onButtonPressedCallback = OnPressed;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "pressed", onButtonPressedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ButtonReleasedEvent onReleased
        {
            get
            {
                return onReleasedEvent;
            }
            set
            {
                onReleasedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onButtonReleasedCallback.IsNullPointer())
                    {
                        onButtonReleasedCallback = OnReleased;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "released", onButtonReleasedCallback.ToIntPtr(), out handle.pointer);
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
            onActivateEvent?.Invoke();
        }        

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            onClickedEvent?.Invoke();
        }

        private void OnEnter(IntPtr widget, IntPtr data)
        {
            onEnterEvent?.Invoke();
        }

        private void OnLeave(IntPtr widget, IntPtr data)
        {
            onLeaveCallEvent?.Invoke();
        }        

        private void OnPressed(IntPtr widget, IntPtr data)
        {
            onPressedEvent?.Invoke();
        }

        private void OnReleased(IntPtr widget, IntPtr data)
        {
            onReleasedEvent?.Invoke();
        }        
    }
}