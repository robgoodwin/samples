using Microsoft.Practices.Unity;

using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

using SampleModule.Views;

namespace SampleModule
{
   [Module(ModuleName = "SampleModuleModule")]
   public class SampleModuleModule : IModule
   {
      IRegionManager _regionManager;
      IUnityContainer _unityContainer;

      public SampleModuleModule(IRegionManager regionManager,
                                IUnityContainer unityContainer)
      {
         _regionManager = regionManager;
         _unityContainer = unityContainer;
      }

      public void Initialize()
      {
         _unityContainer.RegisterType<LeftSideView>();
         _unityContainer.RegisterType<RightSideView>();

         _regionManager.RegisterViewWithRegion("LeftContentRegion", () => _unityContainer.Resolve<LeftSideView>());

         // RegisterViewWithRegion works as expected
         //_regionManager.RegisterViewWithRegion("RightContentRegion", () => _unityContainer.Resolve<RightSideView>());
         _unityContainer.RegisterTypeForNavigation<RightSideView>();
      }
   }
}