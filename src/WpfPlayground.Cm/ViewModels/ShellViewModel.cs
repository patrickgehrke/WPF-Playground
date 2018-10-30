using Caliburn.Micro;
using System.Collections.Generic;
using WpfPlayground.Cm.Coroutines;

namespace WpfPlayground.Cm.ViewModels
{
    public class ShellViewModel : Screen
    {
        public IEnumerable<IResult> Execute()
        {
            FileDialogResult fds = new FileDialogResult("This was executed from a custom IResult, FileDialogResult.", "All files (*.*)|*.*");
            yield return fds;

            yield return new MessageDialogResult($"The selected file is {fds.SelectedFile}", "IResult Coroutines");
        }
    }
}
