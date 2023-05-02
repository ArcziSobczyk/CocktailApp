using Android.App;
using Android.OS;
using CocktailApp;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace TestApp.Views
{
    [Activity(Label = "@string/ownRecipies")]
    public class OwnRecipiesView : MvxActivity<OwnRecipiesViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_own_recipies);
        }
    }
}