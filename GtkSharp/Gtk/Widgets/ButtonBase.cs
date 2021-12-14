using System;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Types;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public abstract class ButtonBase : Bin
    {
        private GEventHandler<ButtonActivateCallback, ButtonActivateEvent> activateHandler = new GEventHandler<ButtonActivateCallback, ButtonActivateEvent>();
        private GEventHandler<ButtonClickedCallback, ButtonClickedEvent> clickedHandler = new GEventHandler<ButtonClickedCallback, ButtonClickedEvent>();
        private GEventHandler<ButtonEnterCallback, ButtonEnterEvent> enterHandler = new GEventHandler<ButtonEnterCallback, ButtonEnterEvent>();
        private GEventHandler<ButtonLeaveCallback, ButtonLeaveEvent> leaveHandler = new GEventHandler<ButtonLeaveCallback, ButtonLeaveEvent>();
        private GEventHandler<ButtonPressedCallback, ButtonPressedEvent> pressedHandler = new GEventHandler<ButtonPressedCallback, ButtonPressedEvent>();
        private GEventHandler<ButtonReleasedCallback, ButtonReleasedEvent> releasedHandler = new GEventHandler<ButtonReleasedCallback, ButtonReleasedEvent>();

        public string Text
        {
            get
            {
                return GetLabel();
            }
            set
            {
                SetLabel(value);
            }
        }

        public Image Image
        {
            get
            {
                return GetImage();
            }
            set
            {
                SetImage(value);
            }
        }

        public ButtonActivateEvent Activate
        {
            get
            {
                return activateHandler.Event;
            }
            set
            {
                activateHandler.Event = value;
                activateHandler.SignalConnect(handle.pointer, "activate", OnActivate, handle.pointer);
            }
        }

        public ButtonClickedEvent Clicked
        {
            get
            {
                return clickedHandler.Event;
            }
            set
            {
                clickedHandler.Event = value;
                clickedHandler.SignalConnect(handle.pointer, "clicked", OnClicked, handle.pointer);
            }
        }

        public ButtonEnterEvent Enter
        {
            get
            {
                return enterHandler.Event;
            }
            set
            {
                enterHandler.Event = value;
                enterHandler.SignalConnect(handle.pointer, "enter", OnEnter, handle.pointer);
            }
        }

        public ButtonLeaveEvent Leave
        {
            get
            {
                return leaveHandler.Event;
            }
            set
            {
                leaveHandler.Event = value;
                leaveHandler.SignalConnect(handle.pointer, "leave", OnLeave, handle.pointer);
            }
        }

        public ButtonPressedEvent Pressed
        {
            get
            {
                return pressedHandler.Event;
            }
            set
            {
                pressedHandler.Event = value;
                pressedHandler.SignalConnect(handle.pointer, "pressed", OnPressed, handle.pointer);
            }
        }

        public ButtonReleasedEvent Released
        {
            get
            {
                return releasedHandler.Event;
            }
            set
            {
                releasedHandler.Event = value;
                releasedHandler.SignalConnect(handle.pointer, "released", OnReleased, handle.pointer);
            }
        }

        public Image GetImage()
        {
            if(handle.IsNullPointer)
                return null;

            GtkWidgetPointer w = NativeButton.gtk_button_get_image(handle);

            if(w.IsNullPointer)
                return null;

            return new Image(w);
        }

        public void SetImage(Image image)
        {
            if(handle.IsNullPointer)
                return;
            if(image.handle.IsNullPointer)
                return;

            NativeButton.gtk_button_set_image(handle, image.handle);
        }

        public string GetLabel()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            return NativeButton.gtk_button_get_label(handle);
        }

        public void SetLabel(string text)
        {
            if(handle.IsNullPointer)
                return;
            NativeButton.gtk_button_set_label(handle, text);
        }

        private void OnActivate(IntPtr widget, IntPtr data)
        {
            Activate?.Invoke();
        }        

        private void OnClicked(IntPtr widget, IntPtr data)
        {
            Clicked?.Invoke();
        }

        private void OnEnter(IntPtr widget, IntPtr data)
        {
            Enter?.Invoke();
        }

        private void OnLeave(IntPtr widget, IntPtr data)
        {
            Leave?.Invoke();
        }        

        private void OnPressed(IntPtr widget, IntPtr data)
        {
            Pressed?.Invoke();
        }

        private void OnReleased(IntPtr widget, IntPtr data)
        {
            Released?.Invoke();
        } 
    }
}