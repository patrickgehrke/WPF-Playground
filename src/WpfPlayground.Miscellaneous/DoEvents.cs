using System.Threading;
using System.Windows.Threading;

namespace WpfPlayground.Miscellaneous
{
    public class DoEvents
    {
        /*
         https://kent-boogaart.com/blog/wpf-splash-screens
        */
        public void Do(DispatcherPriority dispatcherPriority = DispatcherPriority.Loaded)
        {
            var dispatcherFrame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke((ThreadStart)(() => dispatcherFrame.Continue = false), dispatcherPriority);
            Dispatcher.PushFrame(dispatcherFrame);
        }
    }
}
