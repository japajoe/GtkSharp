# GtkSharp
An object oriented GTK 3 wrapper for dotnetcore.

# Dependencies
See https://github.com/japajoe/gtk

# Example
Please take note that this is a work in progress. I'll try to make it as complete as possible overtime, but for now it's just a proof of concept.

```csharp
using System;
using GtkSharp;

namespace GtkSharpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application("GtkSharpApplication", 512, 512);
            application.Run(args);
        }
    }

    public class Application : ApplicationBase
    {
        private Box box;
        private MenuBar menuBar;
        private ScrolledWindow scrolledWindow;
        private Button button;
        private SourceView sourceView;

        public Application() : base()
        {

        }

        public Application(string title, int width, int height) : base(title, width, height)
        {

        }

        public override void Initialize()
        {
            box = new Box(GtkOrientation.Vertical, 0, false);
            menuBar = new MenuBar();
            scrolledWindow = new ScrolledWindow(GtkOrientation.Vertical, GtkPolicyType.Automatic, GtkPolicyType.Automatic);
            button = new Button("Compile", 100, 20);
            sourceView = new SourceView("c-sharp");
            sourceView.LineNumbers = true;

            button.onClick += OnButtonClicked;

            window.Add(box);
            box.Add(menuBar, false, false, 0);
            box.Add(button, false, false, 0);
            box.Add(scrolledWindow, true, true, 0);

            scrolledWindow.Add(sourceView);

            MenuCreationInfo info = new MenuCreationInfo("File");
            info.AddItem("Open", OnMenuItemOpenClicked);
            info.AddItem("Save", OnMenuItemSaveClicked);
            info.AddItem("Exit", OnMenuItemExitClicked);            

            menuBar.AddMenu(info);

            window.ShowAll();
        }

        private void OnButtonClicked()
        {
            Console.WriteLine(sourceView.Text);
        }

        private void OnMenuItemOpenClicked()
        {
            OpenFileDialog dialog = new OpenFileDialog(window);

            if(dialog.ShowDialog() == GtkResponseType.Accept)
            {
                Console.WriteLine("Selected " + dialog.FileName);
            }
        }

        private void OnMenuItemSaveClicked()
        {
            SaveFileDialog dialog = new SaveFileDialog(window);

            if(dialog.ShowDialog() == GtkResponseType.Accept)
            {
                Console.WriteLine("Selected " + dialog.FileName);
            }
        }        

        private void OnMenuItemExitClicked()
        {
            Quit();
        }
    }
}
```
