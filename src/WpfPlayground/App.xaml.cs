using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace WpfPlayground
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            InstallExceptionHandling();
        }

        private void InstallExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");

            DispatcherUnhandledException += (s, e) =>
                LogUnhandledException(e.Exception, "Application.Current.DispatcherUnhandledException");

            TaskScheduler.UnobservedTaskException += (s, e) =>
                LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
        }

        private void LogUnhandledException(Exception exception, string source)
        {
            string msg;

            try
            {
                msg = $"[ERROR] Unhandled exception in {source}";
                AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();
                msg = $"[ERROR] Unhandled exception in {assembly.Name} version: {assembly.Version}";
            }
            catch (Exception ex)
            {
                //Add Log
            }

            //Add Log
        }
    }
}
