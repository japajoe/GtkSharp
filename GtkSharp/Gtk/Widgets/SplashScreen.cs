using GtkSharp.Cairo.Types;
using GtkSharp.Gdk.Types;
using GtkSharp.GLib;
using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public delegate void SplashScreenClose();

    public class SplashScreen
    {
        public event SplashScreenClose closing;

        private Window splashScreen;
        private Timer timer;
        private GdkPixbuf pixbuf;
        private int width;
        private int height;

        public SplashScreen(string splashLogoPath, int width, int height, uint durationMilliseconds = 5000)
        {
            pixbuf = new GdkPixbuf(splashLogoPath);
            this.width = width;
            this.height = height;
            timer = new Timer(durationMilliseconds);
        }
                
        public void Show()
        {
            Box box = new Box();
            DrawingArea drawingArea = new DrawingArea();

            splashScreen = new Window(GtkWindowType.PopUp);            
            splashScreen.Add(box);
            box.Add(drawingArea, true, true, 0);
            
            splashScreen.Destroyed += OnDestroy;            
            drawingArea.Draw += OnDraw;

            splashScreen.SetPosition(GtkWindowPosition.Center);
            splashScreen.SetSizeRequest(width, height);
            splashScreen.ShowAll();
            
            timer.onTick += OnTimerTick;
        }

        bool OnDestroy()
        {
            closing?.Invoke();
            return false;
        }

        bool OnTimerTick()
        {
            splashScreen.Close();
            return false;
        }

        bool OnDraw(CairoInstance cr)
        {
            cr.SetSourcePixbuf(pixbuf, 0, 0);
            cr.Paint();
            return false;
        }
    }


}