using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class ToggleButton : Widget
    {
        private event ToggleButtonValueChangedEvent onChangedEnter;

        private bool buttonValue;
        private GtkToggleButtonValueChangedCallback onToggleValueChangedCallback;

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
                return onChangedEnter;
            }
            set
            {
                onChangedEnter = value;
                if(!handle.IsNullPointer)
                {
                    if(onToggleValueChangedCallback.IsNullPointer())
                    {
                        onToggleValueChangedCallback = OnValueChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "toggled", onToggleValueChangedCallback.ToIntPtr(), out handle.pointer);
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
            onChangedEnter?.Invoke();
        }
    }
}