using Android.App;
using Android.OS;
using CocktailApp;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using System;
using Xamarin.Essentials;

namespace TestApp.Views
{
    [Activity(Label = "@string/funFact")]
    public class FunFactView : MvxActivity<FunFactViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(CocktailApp.Resource.Layout.layout_fun_fact);
            LoadButtons();
        }

        private void LoadButtons()
        {
            var bartenderCocktailStuff = FindViewById(CocktailApp.Resource.Id.bartenderCocktailStuff);
            bartenderCocktailStuff.Click += BartenderCocktailStuff_Click;

            var bartenderStuff = FindViewById(CocktailApp.Resource.Id.mustHaveStuff);
            bartenderStuff.Click += BartenderStuff_Click;

            var mostImportantRecipies = FindViewById(CocktailApp.Resource.Id.mostImportantIngredients);
            mostImportantRecipies.Click += MostImportantRecipies_Click;

            var instagramInspiration = FindViewById(CocktailApp.Resource.Id.instagramInspiration);
            instagramInspiration.Click += InstagramInspiration_Click;
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

        private async void InstagramInspiration_Click(object sender, EventArgs e)
        {
            string uri = "https://www.instagram.com/notjustabartender/";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}