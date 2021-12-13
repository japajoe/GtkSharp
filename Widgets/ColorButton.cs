using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class ColorButton : ButtonBase
    {
        private string title;

        public GdkColor RGB
        {
            get
            {
                return GetRGB();
            }
            set
            {
                SetRGB(value);
            }
        }

        public GdkRGBA RGBA
        {
            get
            {
                return GetRGBA();
            }
            set
            {
                SetRGBA(value);
            }
        }

        public bool UseAlpha
        {
            get
            {
                return GetUseAlpha();
            }
            set
            {
                SetUseAlpha(value);
            }
        }

        public ushort Alpha
        {
            get
            {
                return GetAlpha();
            }
            set
            {
                SetAlpha(value);
            }
        }

        public string Title
        {
            get
            {
                return GetTitle();
            }
            set
            {
                title = value;
                SetTitle(title);
            }
        }

        public ColorButton()
        {
            handle = NativeColorButton.gtk_color_button_new();
        }

        public ColorButton(GdkColor color)
        {
            handle = NativeColorButton.gtk_color_button_new_with_color(ref color);            
        }

        public ColorButton(GdkRGBA color)
        {
            handle = NativeColorButton.gtk_color_button_new_with_rgba(ref color);
        }

        public GdkColor GetRGB()
        {
            if(handle.IsNullPointer)
                return new GdkColor();

            GdkColor color;
            NativeColorButton.gtk_color_button_get_color(handle, out color);
            return color;
        }

        public void SetRGB(GdkColor color)
        {
            if(handle.IsNullPointer)
                return;

            NativeColorButton.gtk_color_button_set_color(handle, ref color);
        } 

        public GdkRGBA GetRGBA()
        {
            if(handle.IsNullPointer)
                return new GdkRGBA();

            GdkRGBA color;
            NativeColorButton.gtk_color_button_get_rgba(handle, out color);
            return color;
        }

        public void SetRGBA(GdkRGBA color)
        {
            if(handle.IsNullPointer)
                return;

            NativeColorButton.gtk_color_button_set_rgba(handle, ref color);            
        }

        public bool GetUseAlpha()
        {
            if(handle.IsNullPointer)
                return false;

            return NativeColorButton.gtk_color_button_get_use_alpha(handle);
        }

        public void SetUseAlpha(bool useAlpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeColorButton.gtk_color_button_set_use_alpha(handle, useAlpha);
        }

        public ushort GetAlpha()
        {
            if(handle.IsNullPointer)
                return 0;

            return NativeColorButton.gtk_color_button_get_alpha(handle);
        }

        public void SetAlpha(ushort alpha)
        {
            if(handle.IsNullPointer)
                return;

            NativeColorButton.gtk_color_button_set_alpha(handle, alpha);
        }

        public string GetTitle()
        {
            if(handle.IsNullPointer)
                return string.Empty;

            title = NativeColorButton.gtk_color_button_get_title(handle);
            return title;
        }

        public void SetTitle(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeColorButton.gtk_color_button_set_title(handle, text);
            this.title = text;
        }
    }
}