using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class SpinButton : Widget
    {
        public event SpinButtonValueChangedEvent onChanged;

        private double buttonValue;
        private GtkSpinButtonValueChangedCallback onValueChangedNative;

        public double Value
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

        public SpinButton(double value, double valueMin, double valueMax, double stepSize)
        {
            Gtk.GtkSharpSpinButtonCreate(out handle, value, valueMin, valueMax, stepSize);
            
            RegisterCallbacks();
        }

        protected override void RegisterCallbacks()
        {
            onValueChangedNative = OnValueChanged;
            Gtk.GtkSharpSignalConnect(out handle.pointer, "value-changed", onValueChangedNative.ToIntPtr(), out handle.pointer);
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinButtonSetValue(out handle, value);
            this.buttonValue = value;
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            Gtk.GtkSharpSpinButtonGetValue(out handle, out buttonValue);                      
            return buttonValue;
        }

        private void OnValueChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}