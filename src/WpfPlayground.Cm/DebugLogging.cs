using System;
using System.Diagnostics;
using Caliburn.Micro;

namespace WpfPlayground.Cm
{
    public class DebugLogging : ILog
    {
        public void Error(Exception exception)
        {
            Debug.WriteLine("[ERROR] " + exception.Message);
        }

        public void Info(string format, params object[] args)
        {
            Debug.WriteLine("[INFO] " + String.Format(format, args));
        }

        public void Warn(string format, params object[] args)
        {
            Debug.WriteLine("[WARN] " + String.Format(format, args));
        }
    }
}
