using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using WpfDataGridExample.Views;

namespace WpfDataGridExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ExampleView>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Container.Resolve<IRegionManager>().RequestNavigate("ContentRegion", "ExampleView");
        }
    }
}
