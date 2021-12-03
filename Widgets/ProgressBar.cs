using System.Text;
using GtkSharp.Native;

namespace GtkSharp
{
    public class ProgressBar : Widget
    {
        private StringBuilder stringBuilder;
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
                SetText(value);            
            }
        }        

        public ProgressBar(GtkOrientation orientation)
        {
            stringBuilder = new StringBuilder(1024);
            Gtk.GtkSharpProgressBarCreate(out handle.pointer);
        }

        public void Pulse()
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarPulse(out handle.pointer);
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetText(out handle.pointer, text);
            this.text = text;
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            stringBuilder.Clear();

            int length = 0;
            Gtk.GtkSharpProgressBarGetTextLength(out handle.pointer, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = length;
                stringBuilder.EnsureCapacity(length);
            }

            Gtk.GtkSharpProgressBarGetText(out handle.pointer, stringBuilder);

            text = stringBuilder.ToString().Substring(0, length);
            
            return this.text;
        }

        public double GetFraction()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            Gtk.GtkSharpProgressBarGetFraction(out handle.pointer, out value);
            return value;
        }

        public void SetFraction(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetfraction(out handle.pointer, value);
        }

        public double GetPulseStep()
        {
            if(handle.IsNullPointer)
                return 0;

            double value;
            Gtk.GtkSharpProgressBarGetPulsestep(out handle.pointer, out value);
            return value;
        }        

        public void SetPulseStep(double value)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetPulseStep(out handle.pointer, value);
        }

        public bool GetInverted()
        {
            if(handle.IsNullPointer)
                return false;
                            
            bool value;
            Gtk.GtkSharpProgressBarGetInverted(out handle.pointer, out value);
            return value;
        }        

        public void SetInverted(bool inverted)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetInverted(out handle.pointer, inverted);
        }

        public PangoEllipsizeMode GetEllipsize()
        {
            if(handle.IsNullPointer)
                return PangoEllipsizeMode.None;
                            
            PangoEllipsizeMode mode;
            Gtk.GtkSharpProgressBarGetEllipsize(out handle.pointer, out mode);
            return mode;
        }        

        public void SetEllipsize(PangoEllipsizeMode mode)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetEllipsize(out handle.pointer, mode);
        }

        public bool GetShowText()
        {
            if(handle.IsNullPointer)
                return false;

            bool value;
            Gtk.GtkSharpProgressBarGetShowText(out handle.pointer, out value);
            return value;
        }

        public void SetShowText(bool show)
        {
            if(handle.IsNullPointer)
                return;

            Gtk.GtkSharpProgressBarSetShowText(out handle.pointer, show);
        }
    }
}