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
            Gtk.GtkSharpSpinButtonCreate(out handle.pointer, value, valueMin, valueMax, stepSize);
            
            onValueChangedNative = GtkSharpDelegate.Create<GtkSpinButtonValueChangedCallback>(this, "OnValueChanged");

            Gtk.GtkSharpSpinButtonValueChangedCallbackConnect(out handle.pointer, onValueChangedNative);
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpSpinButtonSetValue(out handle.pointer, value);
            this.buttonValue = value;
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            Gtk.GtkSharpSpinButtonGetValue(out handle.pointer, out buttonValue);                      
            return buttonValue;
        }

        private void OnValueChanged(IntPtr widget, IntPtr data)
        {
            onChanged?.Invoke();
        }
    }
}