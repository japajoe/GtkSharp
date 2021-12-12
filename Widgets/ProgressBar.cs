using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class ProgressBar : Widget
    {
        private string text;

        public double Fraction
        {
            get
            {
                return GetFraction();
            }
            set
            {
                SetFraction(value);
            }
        }

        public double PulseStep
        {
            get
            {
                return GetPulseStep();
            }
            set
            {
                SetPulseStep(value);
            }
        }

        public bool Inverted
        {
            get
            {
                return GetInverted();
            }
            set
            {
                SetInverted(value);
            }            
        }

        public PangoEllipsizeMode EllipsizeMode
        {
            get
            {
                return GetEllipsize();
            }
            set
            {
                SetEllipsize(value);
            }            
        }

        public bool ShowText
        {
            get
            {
                return GetShowText();
            }
            set
            {
                SetShowText(value);
            }            
        }           

        public string Text
        {
            get
            {
                return GetText();
            }
            set
            {
                text = value;
                SetText(text);
            }
        }   

        public ProgressBar()
        {
            handle = NativeProgressBar.gtk_progress_bar_new();
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            text = NativeProgressBar.gtk_progress_bar_get_text(handle);
            return text;            
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_text(handle, text);
            this.text = text;
        }

        public bool GetShowText()
        {
            if(handle.IsNullPointer)
                return false;

            return NativeProgressBar.gtk_progress_bar_get_show_text(handle);
        }

        public void SetShowText(bool show)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_show_text(handle, show);
        }        

        public double GetFraction()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeProgressBar.gtk_progress_bar_get_fraction(handle);
        }

        public void SetFraction(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_fraction(handle, value);
        }

        public double GetPulseStep()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeProgressBar.gtk_progress_bar_get_pulse_step(handle);
        }        

        public void SetPulseStep(double value)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_pulse_step(handle, value);
        }

        public bool GetInverted()
        {
            if(handle.IsNullPointer)
                return false;
                            
            return NativeProgressBar.gtk_progress_bar_get_inverted(handle);
        }        

        public void SetInverted(bool inverted)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_inverted(handle, inverted);
        }

        public PangoEllipsizeMode GetEllipsize()
        {
            if(handle.IsNullPointer)
                return PangoEllipsizeMode.None;
                            
            return NativeProgressBar.gtk_progress_bar_get_ellipsize(handle);
        }        

        public void SetEllipsize(PangoEllipsizeMode mode)
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_set_ellipsize(handle, mode);
        }

        public void Pulse()
        {
            if(handle.IsNullPointer)
                return;

            NativeProgressBar.gtk_progress_bar_pulse(handle);
        }        
    }
}