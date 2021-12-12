using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Types;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class SpinButton : Widget
    {
        private Adjustment adjustment;
        private double buttonValue;
        private event SpinButtonValueChangedEvent onChangedEvent;
        private GtkSpinButtonValueChangedCallback onSpinButtonValueChangedCallback;

        public double Value
        {
            get
            {
                return GetValue();
            }
            set
            {
                buttonValue = value;
                SetValue(buttonValue);
            }
        }

        public SpinButtonValueChangedEvent onChanged
        {
            get
            {
                return onChangedEvent;
            }
            set
            {
                onChangedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onSpinButtonValueChangedCallback.IsNullPointer())
                    {
                        onSpinButtonValueChangedCallback = OnValueChanged;
                        GLib.g_signal_connect(handle.pointer, "value-changed", onSpinButtonValueChangedCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public SpinButton(double climbRate, uint digits)
        {
            GtkAdjustmentPointer adj = new GtkAdjustmentPointer();
            handle = NativeSpinButton.gtk_spin_button_new(adj, climbRate, digits);
            adj = NativeSpinButton.gtk_spin_button_get_adjustment(handle);
            adjustment = new Adjustment(adj.pointer);
        }

        public SpinButton(double valueMin, double valueMax, double stepSize)
        {            
            handle = NativeSpinButton.gtk_spin_button_new_with_range(valueMin, valueMax, stepSize);
            GtkAdjustmentPointer adj = NativeSpinButton.gtk_spin_button_get_adjustment(handle);
            adjustment = new Adjustment(adj.pointer);
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinButton.gtk_spin_button_set_value(handle, value);
            this.buttonValue = value;
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            return NativeSpinButton.gtk_spin_button_get_value(handle);
        }

        private void OnValueChanged(IntPtr widget, IntPtr data)
        {
            onChangedEvent?.Invoke();
        }
    }
}