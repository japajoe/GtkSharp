using System;
using GtkSharp.Native;

namespace GtkSharp
{
    public class SpinButton : Widget
    {
        private double buttonValue;
        private event SpinButtonValueChangedEvent onChangedCallback;
        private GtkSpinButtonValueChangedCallback onSpinButtonValueChanged;

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

        public SpinButtonValueChangedEvent onChanged
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
                    if(onSpinButtonValueChanged.IsNullPointer())
                    {
                        onSpinButtonValueChanged = OnValueChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "value-changed", onSpinButtonValueChanged.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public SpinButton(double value, double valueMin, double valueMax, double stepSize)
        {
            Gtk.GtkSharpSpinButtonCreate(out handle, value, valueMin, valueMax, stepSize);
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
            onChangedCallback?.Invoke();
        }
    }
}