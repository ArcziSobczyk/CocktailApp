using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        private IMvxNavigationService navigationService;
        public IMvxNavigationService NavigationService => navigationService = navigationService ?? Mvx.IoCProvider.Resolve<IMvxNavigationService>();
        public abstract void onBackPressed();
    }
}
