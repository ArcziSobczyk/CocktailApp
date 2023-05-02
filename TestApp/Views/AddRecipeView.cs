using Android.App;
using Android.OS;
using CocktailApp;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace TestApp.Views
{
    [Activity(Label = "@string/myNote")]
    public class AddRecipeView : MvxActivity<AddRecipeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_add_recipe);
        }
    }
}