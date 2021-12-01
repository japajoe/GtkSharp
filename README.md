# GtkSharp
An object oriented GTK 3 wrapper for dotnetcore.

# Dependencies
See https://github.com/japajoe/gtk

# Example
Please take note that this is a work in progress. I'll try to make it as complete as possible overtime, but for now it's just a proof of concept.

```csharp
﻿using System;
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
        private ScrolledWindow scrolledWindow;
        private Button button1;
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
            scrolledWindow = new ScrolledWindow(GtkOrientation.Vertical, GtkPolicyType.Automatic, GtkPolicyType.Automatic);
            button1 = new Button("Compile", 100, 20);
            sourceView = new SourceView(SourceLanguage.CSharp);
            sourceView.ToggleLineNumbers(true);

            button1.onClick += OnButton1Clicked;

            window.Add(box);
            box.Add(button1, false, false, 0);
            box.Add(scrolledWindow, true, true, 0);

            scrolledWindow.Add(sourceView);

            box.Show();
            button1.Show();
            scrolledWindow.Show();
            sourceView.Show();            
        }

        private void OnButton1Clicked()
        {
            string text = sourceView.GetText();
            System.Console.WriteLine(text);
        }
    }
}
```
