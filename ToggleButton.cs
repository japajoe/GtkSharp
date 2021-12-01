using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class ToggleButton : Widget
    {
        public event SpinButtonValueChanged onChanged;

        private bool buttonValue;
        private GtkToggleButtonValueChangedCallback onValueChangedNative;

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

        public ToggleButton(bool value, string text)
        {
            Gtk.GtkSharpToggleButtonCreate(out handle.pointer, value, text);
            
            onValueChangedNative = GtkSharpDelegate.Create<GtkToggleButtonValueChangedCallback>(this, "OnValueChanged");

            Gtk.GtkSharpToggleButtonValueChangedCallbackConnect(out handle.pointer, onValueChangedNative);
        }

        public void SetValue(bool value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpToggleButtonSetValue(out handle.pointer, value);
            this.buttonValue = value;
        }

        public bool GetValue()
        {
            if(handle.IsNullPointer)
                return false;
            
            Gtk.GtkSharpToggleButtonGetValue(out handle.pointer, out buttonValue);                      
            return buttonValue;
        }

        private void OnValueChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}