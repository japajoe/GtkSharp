using GtkSharp.Native;

namespace GtkSharp
{
    public class ApplicationBase
    {        
        public Window window;
        public event WindowClosingEvent onClosing;
        public event ApplicationQuitEvent onQuit;

        private string title;
        private int width;
        private int height;

        public ApplicationBase()
        {
            this.title = "GtkSharpApplication";
            this.width = 128;
            this.height = 128;            
        }

        public ApplicationBase(string title, int width, int height)
        {
            this.title = title;
            this.width = width;
            this.height = height;
        }

        public void Run(string[] args)
        {
            Gtk.GtkSharpInit(args.Length, args);
            window = new Window(GtkWindowType.TopLevel);

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

        public void GetVersion()
        {

        }

        public void Quit()
        {
            window.Close();
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