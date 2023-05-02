using Android.App;
using Android.OS;
using CocktailApp;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace TestApp.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme",  MainLauncher = true)]
    public class MainMenuView : MvxActivity<MainMenuViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_menu);
        }
    }
}