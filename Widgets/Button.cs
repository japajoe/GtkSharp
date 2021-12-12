using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;

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
                        GLib.g_signal_connect(handle.pointer, "activate", onButtonActivateCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "clicked", onButtonClickedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "enter", onButtonEnterCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "leave", onButtonLeaveCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "pressed", onButtonPressedCallback.ToIntPtr(), handle.pointer);
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
                        GLib.g_signal_connect(handle.pointer, "released", onButtonReleasedCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }
        
        public Button()
        {
            handle = NativeButton.gtk_button_new();
        }

        public Button(string text)
        {
            handle = NativeButton.gtk_button_new();
            SetLabel(text);
        }   

        public void SetLabel(string text)
        {
            if(handle.IsNullPointer)
                return;
            NativeButton.gtk_button_set_label(handle, text);
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