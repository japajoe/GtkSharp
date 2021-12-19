using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gtk.Native.Types;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class SpinButton : Editable
    {
        private GtkAdjustment adjustment;
        private double buttonValue;

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

        public SpinButton(double climbRate, uint digits)
        {
            GtkAdjustmentPointer adj = new GtkAdjustmentPointer();
            handle = NativeSpinButton.gtk_spin_button_new(adj, climbRate, digits);
            adj = NativeSpinButton.gtk_spin_button_get_adjustment(handle);
            adjustment = new GtkAdjustment(adj.pointer);
        }

        public SpinButton(double valueMin, double valueMax, double stepSize)
        {            
            handle = NativeSpinButton.gtk_spin_button_new_with_range(valueMin, valueMax, stepSize);
            GtkAdjustmentPointer adj = NativeSpinButton.gtk_spin_button_get_adjustment(handle);
            adjustment = new GtkAdjustment(adj.pointer);
        }

        private void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeSpinButton.gtk_spin_button_set_value(handle, value);
            this.buttonValue = value;
        }

        private double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            return NativeSpinButton.gtk_spin_button_get_value(handle);
        }
    }
}