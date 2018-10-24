namespace WpfPlayground.Cm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public App()
        {
            this.Resources.Add("Bootstrapper", new Bootstrapper());
        }
    }
}