using Caliburn.Micro;
using System.Windows;
using WpfPlayground.Cm.ViewModels;

namespace WpfPlayground.Cm
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            base.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
            this.DisplayRootViewFor<ShellViewModel>();
        }
    }
}