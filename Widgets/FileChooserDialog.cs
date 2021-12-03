using System.Text;

namespace GtkSharp
{
    public abstract class FileChooserDialog : Widget
    {
        protected Window parent;
        protected StringBuilder stringBuilder;
        protected string fileName;
        protected string title;

        public string FileName
        {
            get { return fileName; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public FileChooserDialog(Window parent)
        {
            this.parent = parent;
            this.stringBuilder = new StringBuilder(1024);
        }

        public virtual GtkResponseType ShowDialog()
        {
            return GtkResponseType.None;            
        }
    }
}