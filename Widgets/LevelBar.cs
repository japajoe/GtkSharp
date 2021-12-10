using System;
using GtkSharp.Native;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class LevelBar : Widget
    {
        private event LevelBarOffsetChangedEvent onOffsetChangedEvent;

        private GtkLevelBarOffsetChangedCallback onLevelBarOffsetChangedCallback;

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

        public LevelBarOffsetChangedEvent onOffsetChanged
        {
            get
            {
                return onOffsetChangedEvent;
            }
            set
            {
                onOffsetChangedEvent = value;
                if(!handle.IsNullPointer)
                {
                    if(onLevelBarOffsetChangedCallback.IsNullPointer())
                    {
                        onLevelBarOffsetChangedCallback = OnOffsetChanged;
                        Gtk.GtkSharpSignalConnect(out handle.pointer, "offset-changed", onLevelBarOffsetChangedCallback.ToIntPtr(), out handle.pointer);
                    }
                }
            }
        }

        public LevelBar(GtkOrientation orientation, double minValue, double maxValue)
        {
            NativeLevelBar.GtkSharpLevelBarCreate(out handle, minValue, maxValue);
        }

        public void AddOffsetValue(double value, string name)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.GtkSharpLevelBarAddOffsetValue(out handle, name, value);
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            NativeLevelBar.GtkSharpLevelBarGetValue(out handle, out value);
            return value;
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.GtkSharpLevelBarSetValue(out handle, value);
        }

        public double GetMinValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            NativeLevelBar.GtkSharpLevelBarGetMinValue(out handle, out value);
            return value;
        }

        public void SetMinValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.GtkSharpLevelBarSetMinValue(out handle, value);
        }

        public double GetMaxValue()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            NativeLevelBar.GtkSharpLevelBarGetMaxValue(out handle, out value);
            return value;
        }

        public void SetMaxValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.GtkSharpLevelBarSetMaxValue(out handle, value);
        }

        public GtkLevelBarMode GetMode()
        {
            if(handle.IsNullPointer)
                return GtkLevelBarMode.Continuous;

            GtkLevelBarMode mode;
            NativeLevelBar.GtkSharpLevelBarGetMode(out handle, out mode);
            return mode;
        }

        public void SetMode(GtkLevelBarMode mode)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.GtkSharpLevelBarSetMode(out handle, mode);
        }

        private void OnOffsetChanged(IntPtr widget, IntPtr name, IntPtr data)
        {
            string n = MarshalHelper.MarshalPtrToString(name);
            onOffsetChangedEvent?.Invoke(n);
        }
    }
}