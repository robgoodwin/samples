using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace SampleModule.ViewModels
{
   class LeftSideViewModel : BindableBase
   {
      private readonly IRegionManager mRegionManager = null;
      public DelegateCommand NavigateCommand { get; private set; }
      public LeftSideViewModel(IRegionManager regionManager)
      {
         mRegionManager = regionManager;
         NavigateCommand = new DelegateCommand(Navigate);
      }

      protected void Navigate()
      {
         mRegionManager.RequestNavigate("RightContentRegion", "RightSideView");
      }
   }
}
