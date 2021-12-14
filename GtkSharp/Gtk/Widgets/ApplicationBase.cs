using GtkSharp.Gtk.Types;

namespace GtkSharp.Gtk.Widgets
{
    public class ApplicationBase
    {
        public Window window;
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
            GtkLib.gtk_init(args.Length, args);
            window = new Window(GtkWindowType.TopLevel);

            Initialize();

            window.Destroyed += OnClosed;

            window.SetTitle(title);
            window.SetSizeRequest(width, height);
            window.ShowAll();

            GtkLib.gtk_main();
        }

        public virtual void Initialize()
        {

        }

        public void Quit()
        {
            window.Close();
        }

        private bool OnClosed()
        {
            onQuit?.Invoke();
            GtkLib.gtk_main_quit();
            return true;
        }        
    }
}