using Core.Database;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Unity;

namespace Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        public CocktailAppDatabase database;

        public BaseViewModel()
        {
            IUnityContainer container = new UnityContainer();
            database = container.Resolve<CocktailAppDatabase>();
        }

        private IMvxNavigationService navigationService;
        public IMvxNavigationService NavigationService => navigationService = navigationService ?? Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        public abstract void onBackPressed();
    }
}
