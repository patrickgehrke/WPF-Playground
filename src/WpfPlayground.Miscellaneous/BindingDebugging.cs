using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace WpfPlayground.Miscellaneous
{
    public class BindingDebugging
    {
        /*
            Call on startup 
        */
        public void Setup()
        {
            PresentationTraceSources.Refresh();
            PresentationTraceSources.DataBindingSource.Listeners.Add(new DebugTraceListener());
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Critical | SourceLevels.Warning;
        }

        /*
            Tools -> Options -> Debugging -> Output Window -> WPF Trace Settings -> Data Binding
        */
        public class DebugTraceListener : TraceListener
        {
            public override void Write(string message)
            {
            }

            public override void WriteLine(string message)
            {
                Debugger.Break();
            }
        }

        public class DebugDataBindingConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                Debugger.Break();
                return value;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                Debugger.Break();
                return value;
            }
        }
    }
}
