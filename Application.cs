using GtkSharp.Native;

namespace GtkSharp
{
    public class Application
    {        
        public Window window;
        public event WindowClosingEvent onClosing;
        public event ApplicationQuitEvent onQuit;

        private string title;
        private int width;
        private int height;        

        public Application()
        {
            this.title = "GtkSharpApplication";
            this.width = 512;
            this.height = 512;
        }

        public Application(string title, int width, int height)
        {
            this.title = title;
            this.width = width;
            this.height = height;
        }

        public void Run(string[] args)
        {
            Gtk.GtkSharpInit(args.Length, args);
            window = new Window();

            Initialize();

            window.onClosing += OnClosing;
            window.onClosed += OnClosed;
            window.SetTitle(title);
            window.SetSize(width, height);
            window.Show();
            Gtk.GtkSharpMain();
        }

        public virtual void Initialize()
        {

        }

        private void OnClosing()
        {
            onClosing?.Invoke();
        }

        private void OnClosed()
        {
            onQuit?.Invoke();
            Gtk.GtkSharpMainQuit();
        }
    }
}