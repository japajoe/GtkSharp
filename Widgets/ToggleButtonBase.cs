using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public abstract class ToggleButtonBase : Widget
    {
        private event ToggleButtonToggledEvent onToggled;
        private GtkToggleButtonToggledCallback onToggleButtonToggledCallback;

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

        public ToggleButtonToggledEvent onChanged
        {
            get
            {
                return onToggled;
            }
            set
            {
                onToggled = value;
                if(!handle.IsNullPointer)
                {
                    if(onToggleButtonToggledCallback.IsNullPointer())
                    {
                        onToggleButtonToggledCallback = OnToggled;
                        GLib.g_signal_connect(handle.pointer, "toggled", onToggleButtonToggledCallback.ToIntPtr(), handle.pointer);
                    }
                }
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
            onToggled?.Invoke();
        }
    }
}