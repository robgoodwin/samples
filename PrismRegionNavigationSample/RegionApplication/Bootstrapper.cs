using Microsoft.Practices.Unity;
using Prism.Unity;
using RegionApplication.Views;
using System.Windows;
using Prism.Modularity;

namespace RegionApplication
{
   class Bootstrapper : UnityBootstrapper
   {
      protected override DependencyObject CreateShell()
      {
         return Container.Resolve<MainWindow>();
      }

      protected override IModuleCatalog CreateModuleCatalog()
      {
         return new DirectoryModuleCatalog() { ModulePath = "." };
      }
      protected override void InitializeShell()
      {
         Application.Current.MainWindow.Show();
      }
   }
}
