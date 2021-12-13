using System;
using GtkSharp.Callbacks;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public abstract class ToggleButtonBase : Widget
    {
        private GEventHandler<ToggleButtonToggledCallback,ToggleButtonToggledEvent> toggledHandler = new GEventHandler<ToggleButtonToggledCallback, ToggleButtonToggledEvent>();

        public bool Value
        {
            get
            {
                return GetValue();
            }
            set
            {
                SetValue(value);
            }
        }

        public ToggleButtonToggledEvent Toggled
        {
            get
            {
                return toggledHandler.Event;
            }
            set
            {
                toggledHandler.Event = value;
                toggledHandler.SignalConnect(handle.pointer, "toggled", OnToggled, handle.pointer);
            }
        }

        public bool GetValue()
        {
            if(handle.IsNullPointer)
                return false;
            
            return NativeToggleButton.gtk_toggle_button_get_active(handle);
        }        

        public void SetValue(bool value)
        {
            if(handle.IsNullPointer)
                return;

            NativeToggleButton.gtk_toggle_button_set_active(handle, value);
        }

        private void OnToggled(IntPtr widget, IntPtr data)
        {
            Toggled?.Invoke();
        }
    }
}