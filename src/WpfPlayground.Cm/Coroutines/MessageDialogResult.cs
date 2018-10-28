using Caliburn.Micro;
using System.Windows;

namespace WpfPlayground.Cm.Coroutines
{
    public class MessageDialogResult : ResultBase
    {
        private readonly string content;
        private readonly string title;

        public MessageDialogResult(string content, string title)
        {
            this.content = content;
            this.title = title;
        }

        public override void Execute(CoroutineExecutionContext context)
        {
            MessageBox.Show(content, title, MessageBoxButton.OK);
            OnCompleted(new ResultCompletionEventArgs());
        }
    }
}