using System;
using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.GLib.Types;
using GtkSharp.Gtk.Native.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class SpinButton : Widget
    {
        private Adjustment adjustment;
        private double buttonValue;

        private GEventHandler<SpinButtonValueChangedCallback,SpinButtonValueChangedEvent> changedHandler = new GEventHandler<SpinButtonValueChangedCallback, SpinButtonValueChangedEvent>();

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

        public SpinButtonValueChangedEvent Changed
        {
            get
            {
                return changedHandler.Event;
            }
            set
            {
                changedHandler.Event = value;
                changedHandler.SignalConnect(handle.pointer, "value-changed", OnValueChanged, handle.pointer);
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
            Changed?.Invoke();
        }
    }
}