using System.Text;
using GtkSharp.Native.Widgets;

namespace GtkSharp
{
    public class Label : Widget
    {
        private StringBuilder stringBuilder;
        private string text;

        public string Text
        {
            get
            {
                return GetText();
            }
            set
            {
                SetText(value);
            }
        }

        public Label()
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, "Label");
        }

        public Label(string text)
        {
            stringBuilder = new StringBuilder(1024);
            NativeLabel.GtkSharpLabelCreate(out handle, text);
        }

        public string GetText()
        {
            if(handle.IsNullPointer)
                return string.Empty;
            
            int length;

            NativeLabel.GtkSharpLabelGetTextLength(out handle, out length);

            if(length > stringBuilder.Capacity)
            {
                stringBuilder.Capacity = (int)length;
                stringBuilder.EnsureCapacity((int)length);
            }

            NativeLabel.GtkSharpLabelGetText(out handle, stringBuilder);
            this.text = stringBuilder.ToString().Substring(0, length);
            return text;
        }

        public void SetText(string text)
        {
            if(handle.IsNullPointer)
                return;

            NativeLabel.GtkSharpLabelSetText(out handle, text);
            this.text = text;
        }
    }
}