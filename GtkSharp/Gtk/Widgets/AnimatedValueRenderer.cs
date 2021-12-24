using GtkSharp.Gtk.Types;
using GtkSharp.Gtk.Native.Widgets;
using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Utilities;

namespace GtkSharp.Gtk.Widgets
{
    //Still works a bit clumsy but it's a beginning :)
    public class AnimatedValueRenderer : EventBox
    {
        private Image dummy;
        private int spriteIndex = 0;
        private int numSprites;
        private int offset = 0;
        private GtkOrientation orientation;
        private CairoImageSurface surface;
        private float valueMin;
        private float valueMax;
        private float currentValue;

        public float Value
        {
            get
            {
                currentValue = GetValue();
                return currentValue;
            }
            set
            {
                currentValue = value;
                SetValue(currentValue);
            }
        }

        public AnimatedValueRenderer(string filepath, int numSprites, GtkOrientation orientation, float valueMin, float valueMax, float value)
        {
            this.numSprites = numSprites;
            this.orientation = orientation;
            this.valueMin = valueMin;
            this.valueMax = valueMax;

            handle = NativeEventBox.gtk_event_box_new();
            
            surface = new CairoImageSurface(filepath);

            if(orientation == GtkOrientation.Vertical)
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, surface.Width, surface.Height / numSprites));
                offset = surface.Height / numSprites;
            }
            else
            {
                dummy = new Image(new GdkPixbuf(GdkColorspace.RGB, true, 8, surface.Width / numSprites, surface.Height));
                offset = surface.Width / numSprites;
            }

            dummy.Clear(new GdkRGBA(0.0, 0.0, 0.0, 0.0));
            
            this.Add(this.dummy);

            this.Draw += OnDrawSprite;
            this.DestroyEvent += OnDestroyWidget;

            SetValue(value);
        }

        private float GetValue()
        {
            if(handle.IsNullPointer)
                return 0;
            
            float val = (1.0f / (numSprites - 1)) * spriteIndex;
            return valueMin + ((valueMax - valueMin) * val);
        }

        private void SetValue(float value)
        {
            if(handle.IsNullPointer)
                return;

            value = Mathf.Clamp(value, valueMin, valueMax);
            float t = Mathf.InverseLerp(valueMin, valueMax, value);
            int v = (int)Mathf.Ceil(t * (numSprites - 1));
            spriteIndex = v;
            QueueDraw();
        }

        private bool OnDrawSprite(CairoInstance cr)
        {
            int width = surface.Width;
            int height = surface.Height;

            if(orientation == GtkOrientation.Vertical)
                cr.Translate(0, spriteIndex * -offset);
            else
                cr.Translate(spriteIndex * -offset, 0);

            cr.SetSourceSurface(surface, 0, 0);
            cr.Rectangle(0, 0, width, height);
            cr.Fill();
            
            return false;
        }

        private void OnDestroyWidget()
        {
            surface.Destroy();
        }
    }
}