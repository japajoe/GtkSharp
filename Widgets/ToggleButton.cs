using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class ToggleButton : Widget
    {
        private event ToggleButtonValueChangedEvent onChangedCallback;

        private bool buttonValue;
        private GtkToggleButtonValueChangedCallback onToggleValueChanged;

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

        public ToggleButtonValueChangedEvent onChanged
        {
            get
            {
                return onChangedCallback;
            }
            set
            {
                onChangedCallback = value;
                if(!handle.IsNullPointer)
                {
                    if(onToggleValueChanged.IsNullPointer())
                    {
                        onToggleValueChanged = OnValueChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "toggled", onToggleValueChanged.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public ToggleButton(bool value, string text)
        {
            Gtk.GtkSharpToggleButtonCreate(out handle, value, text);
        }

        public void SetValue(bool value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpToggleButtonSetValue(out handle, value);
            this.buttonValue = value;
        }

        public bool GetValue()
        {
            if(handle.IsNullPointer)
                return false;
            
            Gtk.GtkSharpToggleButtonGetValue(out handle, out buttonValue);                      
            return buttonValue;
        }

        private void OnValueChanged(IntPtr widget, IntPtr data)
        {
            onChangedCallback?.Invoke();
        }
    }
}