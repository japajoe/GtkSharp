using GtkSharp.Gdk.Types;
using GtkSharp.Cairo.Types;
using GtkSharp.Utilities;
using GtkSharp.Gtk.Native.Widgets;

namespace GtkSharp.Gtk.Widgets
{
    public class SplineControl : EventBox
    {
        public enum MouseButtonState
        {
            Down,
            Up
        }

        private Spline spline;
        private MouseButtonState mouseButtonState = MouseButtonState.Up;
        private int currentIndex = -1;
        private Vector2 mousePosition = Vector2.zero;

        public Spline Spline
        {
            get
            {
                return spline;
            }
            set
            {
                spline = value;
            }
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public GdkRGBA BackgroundColor
        {
            get;
            set;
        }

        public GdkRGBA Color
        {
            get;
            set;
        }

        public GdkRGBA ControlPointColor
        {
            get;
            set;
        }

        public SplineControl(int numPoints)
        {
            handle = NativeEventBox.gtk_event_box_new();

            Width = 128;
            Height = 64;

            BackgroundColor = new GdkRGBA(0.0, 0.0, 0.0, 1.0);
            ControlPointColor = new GdkRGBA(1.0, 0.0, 0.0, 1.0);
            Color = new GdkRGBA(1.0, 1.0, 1.0, 1.0);

            spline = new Spline(numPoints, Spline.BezierType.Quadratic);
            spline.SetControlPointPosition(0, new Vector2(0, 32));
            spline.SetControlPointPosition(1, new Vector2(32, 32));
            spline.SetControlPointPosition(2, new Vector2(64, 32));
            spline.Generate();

            this.AddEvents(GdkEventMask.PointerMotion | GdkEventMask.ButtonPress | GdkEventMask.ButtonRelease | GdkEventMask.Scroll);
            this.ButtonPress += OnButtonPress;
            this.ButtonRelease += OnButtonRelease;
            this.MotionNotify += OnMotionNotify;
            this.Draw += OnDrawSpline;
        }

        private bool OnDrawSpline(CairoInstance cr)
        {
            cr.SetSourceRGBA(BackgroundColor);
            cr.Rectangle(0, 0, Width, Height);
            cr.Fill();

            cr.SetSourceRGBA(ControlPointColor);
            cr.Rectangle(spline.controlPoints[0].x, spline.controlPoints[0].y, 5, 5);
            cr.Rectangle(spline.controlPoints[1].x, spline.controlPoints[1].y, 5, 5);
            cr.Rectangle(spline.controlPoints[2].x, spline.controlPoints[2].y, 5, 5);
            cr.Fill();

            cr.SetSourceRGBA(Color);

            for(int i = 0; i < spline.points.Count; i++)
            {
                if(i == 0)
                    cr.MoveTo(spline.points[i].x, spline.points[i].y);
                else
                    cr.LineTo(spline.points[i].x, spline.points[i].y);
            }

            cr.Stroke();
            
            return false;
        }

        public bool OnButtonPress(GdkEventButton eventButton)
        {
            mouseButtonState = MouseButtonState.Down;
            return false;
        }

        public bool OnButtonRelease(GdkEventButton eventButton)
        {
            mouseButtonState = MouseButtonState.Up;
            currentIndex = -1;
            return false;
        }

        public bool OnMotionNotify(GdkEventMotion eventMotion)
        {
            if(mouseButtonState == MouseButtonState.Down)
            {
                mousePosition = new Vector2((float)eventMotion.x, (float)eventMotion.y);


                if(spline.MouseNearControlPoint(mousePosition, 10.0f, out int index))
                {
                    if(currentIndex == -1)
                        currentIndex = index;
                }

                if(currentIndex >= 0)
                {
                    spline.SetControlPointPosition(currentIndex, mousePosition);
                    spline.Generate();
                    QueueDraw();
                }
            }
            return false;
        }       
    }
}