using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.Models;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Views
{
    [Activity(Label = "@string/myRecipe")]
    public class AddRecipeView : BaseView<AddRecipeViewModel>
    {
        private EditText cocktailName;
        private EditText cocktailIngredient1;
        private EditText cocktailIngredient2;
        private EditText cocktailIngredient3;
        private EditText cocktailIngredient4;
        private EditText cocktailIngredient5;
        private EditText cocktailIngredient6;
        private EditText cocktailNote;
        private Button save;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_add_recipe);
            BindViews();
            List<CocktailModel> x = ViewModel.database.GetItemsAsync().Result;
        }

        private void BindViews()
        {
            cocktailName = (EditText)FindViewById(Resource.Id.cocktailName);
            cocktailIngredient1 = (EditText)FindViewById(Resource.Id.cocktailIngredient1);
            cocktailIngredient2 = (EditText)FindViewById(Resource.Id.cocktailIngredient2);
            cocktailIngredient3 = (EditText)FindViewById(Resource.Id.cocktailIngredient3);
            cocktailIngredient4 = (EditText)FindViewById(Resource.Id.cocktailIngredient4);
            cocktailIngredient5 = (EditText)FindViewById(Resource.Id.cocktailIngredient5);
            cocktailIngredient6 = (EditText)FindViewById(Resource.Id.cocktailIngredient6);
            cocktailNote = (EditText)FindViewById(Resource.Id.cocktailNote);
            save = (Button)FindViewById(Resource.Id.save);
            save.Click += Save_Click;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            ViewModel.database.SaveItemAsync(new Core.Models.CocktailModel()
            {
                CocktailName = cocktailName.Text,
                CocktailDescription = cocktailNote.Text,
                CocktailIngredient1 = cocktailIngredient1.Text,
                CocktailIngredient2 = cocktailIngredient2.Text,
                CocktailIngredient3 = cocktailIngredient3.Text,
                CocktailIngredient4 = cocktailIngredient4.Text,
                CocktailIngredient5 = cocktailIngredient5.Text,
                CocktailIngredient6 = cocktailIngredient6.Text
            });
        }
    }
}