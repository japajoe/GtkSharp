# GtkSharp
An object oriented GTK 3 wrapper for dotnetcore.

# Dependencies
- libgtk-3-dev
- libglib2.0-dev
- libgtksourceview-3.0-dev

# Disclaimer
Please take note that this is a work in progress. I'll try to make it as complete as possible overtime, but for now it's just a proof of concept.

# Example

![](GtkSharpExample.png)

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
        private Fixed fixedPanel;
        private Paned paned;
        private Button buttonExecute;
        private ScrolledWindow scrolledSource;
        private ScrolledWindow scrolledLog;
        private SourceView sourceView;
        private TextView textViewLog;

        public Application() : base()
        {
            
        }

        public Application(string title, int width, int height) : base(title, width, height)
        {
            
        }

        public override void Initialize()
        {
            box = new Box(GtkOrientation.Vertical, 0);
            menuBar = new MenuBar();
            fixedPanel = new Fixed();
            paned = new Paned(GtkOrientation.Vertical);
            scrolledSource = new ScrolledWindow(GtkPolicyType.Automatic, GtkPolicyType.Automatic);
            scrolledLog = new ScrolledWindow(GtkPolicyType.Automatic, GtkPolicyType.Automatic);
            buttonExecute = new Button("Execute");
            sourceView = new SourceView("c-sharp");
            textViewLog = new TextView();

            box.SetMargins(5, 5, 5, 5);
            sourceView.LineNumbers = true;
            buttonExecute.Clicked += Execute;

            window.Add(box);
            box.Add(menuBar, false, false, 0);
            box.Add(fixedPanel, false, false, 0);
            fixedPanel.Add(buttonExecute, 10, 10);
            box.Add(paned, true, true, 0);
            paned.Add(scrolledSource, 0, false, false);
            paned.Add(scrolledLog, 1, false, false);
            
            scrolledSource.Add(sourceView);
            scrolledLog.Add(textViewLog);

            textViewLog.ReadOnly = true;

            MenuCreationInfo infoFile = new MenuCreationInfo("File");
            infoFile.AddItem("Open", OnMenuItemOpenClicked);
            infoFile.AddItem("Save", OnMenuItemSaveClicked);
            infoFile.AddItem("Exit", OnMenuItemExitClicked);

            MenuCreationInfo infoEdit = new MenuCreationInfo("Edit");
            infoEdit.AddItem("Clear Log", OnMenuItemClearLogClicked);

            menuBar.AddMenu(infoFile);
            menuBar.AddMenu(infoEdit);

            window.ShowAll();
        }

        private void Execute()
        {
            textviewLog.Text = sourceView.Text;
        }

        private void OnMenuItemOpenClicked()
        {
            OpenFileDialog dialog = new OpenFileDialog(window);

            if(dialog.ShowDialog() == GtkResponseType.Accept)
            {
                if(File.Exists(dialog.FileName))
                {
                    string text = File.ReadAllText(dialog.FileName);
                    sourceView.Text = text;
                }
            }
        }

        private void OnMenuItemSaveClicked()
        {
            string text = sourceView.Text;

            if(text.Length == 0)
            {
                textViewLog.Text = "Nothing to save...";
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog(window);

            if(dialog.ShowDialog() == GtkResponseType.Accept)
            {
                string filename = dialog.FileName;
                if(!filename.EndsWith(".cs"))
                {
                    filename += ".cs";
                }

                File.WriteAllText(filename, text);
                textViewLog.Text = "File saved as " + filename;
            }
        }        

        private void OnMenuItemExitClicked()
        {
            Quit();
        }

        private void OnMenuItemClearLogClicked()
        {
            textViewLog.Clear();
        }
    }
}
```
