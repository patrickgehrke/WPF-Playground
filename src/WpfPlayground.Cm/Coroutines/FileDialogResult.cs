using Caliburn.Micro;
using Microsoft.Win32;

namespace WpfPlayground.Cm.Coroutines
{
    public class FileDialogResult : ResultBase
    {
        private string title;
        private string filter;
        public string SelectedFile { get; private set; }

        public FileDialogResult(string title, string filter)
        {
            this.title = title;
            this.filter = filter;
        }

        public override void Execute(CoroutineExecutionContext context)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = this.filter,
                Title = this.title
            };

            if (ofd.ShowDialog() == true)
            {
                this.SelectedFile = ofd.FileName;
                OnCompleted();
            }
            else OnCancelled();
        }
    }
}
