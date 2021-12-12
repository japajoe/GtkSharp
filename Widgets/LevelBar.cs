using System;
using GtkSharp.Callbacks;
using GtkSharp.Native;
using GtkSharp.Native.Callbacks;
using GtkSharp.Native.Utilities;
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
                        GLib.g_signal_connect(handle.pointer, "offset-changed", onLevelBarOffsetChangedCallback.ToIntPtr(), handle.pointer);
                    }
                }
            }
        }

        public LevelBar()
        {
            handle = NativeLevelBar.gtk_level_bar_new();
        }

        public LevelBar(double minValue, double maxValue)
        {
            handle = NativeLevelBar.gtk_level_bar_new_for_interval(minValue, maxValue);
        }

        public void AddOffsetValue(double value, string name)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.gtk_level_bar_add_offset_value(handle, name, value);
        }

        public double GetValue()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeLevelBar.gtk_level_bar_get_value(handle);
        }

        public void SetValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.gtk_level_bar_set_value(handle, value);
        }

        public double GetMinValue()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeLevelBar.gtk_level_bar_get_min_value(handle);
        }

        public void SetMinValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.gtk_level_bar_set_min_value(handle, value);
        }

        public double GetMaxValue()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeLevelBar.gtk_level_bar_get_max_value(handle);
        }

        public void SetMaxValue(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.gtk_level_bar_set_max_value(handle, value);
        }

        public GtkLevelBarMode GetMode()
        {
            if(handle.IsNullPointer)
                return GtkLevelBarMode.Continuous;

            return NativeLevelBar.gtk_level_bar_get_mode(handle);
        }

        public void SetMode(GtkLevelBarMode mode)
        {
            if(handle.IsNullPointer)
                return;

            NativeLevelBar.gtk_level_bar_set_mode(handle, mode);
        }

        private void OnOffsetChanged(IntPtr widget, IntPtr name, IntPtr data)
        {
            string n = MarshalHelper.MarshalPtrToString(name);
            onOffsetChangedEvent?.Invoke(n);
        }
    }
}