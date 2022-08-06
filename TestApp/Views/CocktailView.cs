using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Views
{
    [Activity(Label = "@string/recipe")]
    public class CocktailView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_cocktail);
        }
    }
}