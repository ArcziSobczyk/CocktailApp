using Core.Services;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        private DatabaseService? databaseService;
        public DatabaseService DatabaseService
        {
            get { return databaseService; }
            set { databaseService = new DatabaseService(); }
        }

        private IMvxNavigationService? navigationService;
        public IMvxNavigationService NavigationService => navigationService = navigationService ?? Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        public abstract void onBackPressed();
    }
}
