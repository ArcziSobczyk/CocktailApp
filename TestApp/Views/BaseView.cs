using Android.OS;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using Xamarin.Essentials;

namespace TestApp.Views
{
    public abstract class BaseView<TViewModel> : MvxActivity where TViewModel : BaseViewModel, IMvxViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Platform.Init(this, bundle);
        }
    }
}