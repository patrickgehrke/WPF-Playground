using Caliburn.Micro;
using System;
using System.Windows;
using WpfPlayground.Cm.ViewModels;

namespace WpfPlayground.Cm
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            base.Initialize();
            LogManager.GetLog = (Type t) => this.CaliburnLogging(t);
        }

        /// <summary>
        ///     Logging based on type
        /// </summary>
        /// <param name="t">Caliburn Type</param>
        /// <returns>Logging Instance</returns>
        private ILog CaliburnLogging(Type t)
        {
            ILog log = new DebugLogging();

            switch(t.ToString())
            {
                case nameof(Coroutine):
                    break;
                case nameof(OverrideCancelResultDecorator):
                    break;

                case nameof(ContinueResultDecorator):
                    break;

                case nameof(RescueResultDecorator<Exception>):
                    break;

                case nameof(Screen):
                    break;

                case nameof(Caliburn.Micro.Action):
                    break;

                case nameof(Bind):
                    break;

                case nameof(Parser):
                    break;

                case nameof(View):
                    break;

                case nameof(ViewModelBinder):
                    break;

                case nameof(ActionMessage):
                    break;

                case nameof(ViewLocator):
                    break;

                case nameof(ConventionManager):
                    break;
            }

            return log;
        }
        
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
            this.DisplayRootViewFor<ShellViewModel>();
        }
    }
}