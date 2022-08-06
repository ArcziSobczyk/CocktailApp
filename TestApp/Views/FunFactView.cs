using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace TestApp.Views
{
    [Activity(Label = "@string/funFact")]
    public class FunFactView : MvxActivity<FunFactViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_fun_fact);
            LoadButtons();
        }

        private void LoadButtons()
        {
            var bartenderCocktailStuff = FindViewById(Resource.Id.bartenderCocktailStuff);
            bartenderCocktailStuff.Click += BartenderCocktailStuff_Click;

            var bartenderStuff = FindViewById(Resource.Id.mustHaveStuff);
            bartenderStuff.Click += BartenderStuff_Click;

            var mostImportantRecipies = FindViewById(Resource.Id.mostImportantIngredients);
            mostImportantRecipies.Click += MostImportantRecipies_Click;
        }

        private async void BartenderCocktailStuff_Click(object sender, EventArgs e)
        {
            string uri = "https://tarascobar.pl/niezbednik-barmana-skladniki/";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }


        private async void BartenderStuff_Click(object sender, EventArgs e)
        {
            string uri = "https://dariuszowczarek.pl/zestaw-barmanski-niezbednik-profesjonalnego-barmana/";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async void MostImportantRecipies_Click(object sender, EventArgs e)
        {
            string uri = "https://www.absolutdrinks.com/pl/drinks/collection/classic-cocktails/";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}