using GtkSharp.Native;

namespace GtkSharp
{
    public class LevelBar : Widget
    {
        public double MinValue
        {
            get
            {
                return GetMinValue();
            }
            set
            {
                SetMinValue(value);
            }
        }
        public double MaxValue
        {
            get
            {
                return GetMaxValue();
            }
            set
            {
                SetMaxValue(value);
            }
        }
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

        public GtkLevelBarMode Mode
        {
            get
            {
                return GetMode();
            }
            set
            {
                SetMode(value);
            }
        }

        public LevelBar(GtkOrientation orientation, double minValue, double maxValue)
        {
            Gtk.GtkSharpLevelBarCreate(out handle, minValue, maxValue);
        }

        public void AddOffsetValue(double value, string name)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLevelBarAddOffsetValue(out handle, name, value);
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            Gtk.GtkSharpLevelBarGetValue(out handle, out value);
            return value;
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLevelBarSetValue(out handle, value);
        }

        public double GetMinValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            Gtk.GtkSharpLevelBarGetMinValue(out handle, out value);
            return value;
        }

        public void SetMinValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLevelBarSetMinValue(out handle, value);
        }

        public double GetMaxValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            Gtk.GtkSharpLevelBarGetMaxValue(out handle, out value);
            return value;
        }

        public void SetMaxValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLevelBarSetMaxValue(out handle, value);
        }

        public GtkLevelBarMode GetMode()
        {
            if(handle.IsNullPointer)
                return GtkLevelBarMode.Continuous;

            GtkLevelBarMode mode;
            Gtk.GtkSharpLevelBarGetMode(out handle, out mode);
            return mode;
        }

        public void SetMode(GtkLevelBarMode mode)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpLevelBarSetMode(out handle, mode);
        }        
    }
}