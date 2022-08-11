using Core.Models;
using MvvmCross;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class CocktailViewModel : BaseViewModel<CocktailParameter>
    {
        #region Main
        public override void Prepare(CocktailParameter parameter)
        {
            CocktailModel = new CocktailModel()
            {
                CocktailName = parameter.CocktailName,
                CocktailDescription = parameter.CocktailDescription,
                CocktailRecipe = parameter.CocktailRecipe,
                CocktailIngredient1 = parameter.CocktailIngredient1,
                CocktailIngredient2 = parameter.CocktailIngredient2,
                CocktailIngredient3 = parameter.CocktailIngredient3,
                CocktailIngredient4 = parameter.CocktailIngredient4,
                CocktailIngredient5 = parameter.CocktailIngredient5,
                CocktailIngredient6 = parameter.CocktailIngredient6,
            };

            if (CocktailModel.CocktailIngredient4 is null)
                IngredientFour = false;
            else
                IngredientFour = true;


            if (CocktailModel.CocktailIngredient5 is null)
                IngredientFive = false;
            else
                IngredientFive = true;


            if (CocktailModel.CocktailIngredient6 is null)
                IngredientSix = false;
            else
                IngredientSix = true;
        }

        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }
        #endregion

        #region PROP
        private bool ingredientFour;
        private bool ingredientFive;
        private bool ingredientSix;

        public CocktailModel CocktailModel { get; set; }
        public bool IngredientFour 
        { 
            get { return ingredientFour; }
            set
            {
                ingredientFour = value;
                RaisePropertyChanged(() => IngredientFour);
            }
        }
        public bool IngredientFive
        {
            get { return ingredientFive; }
            set
            {
                ingredientFive = value;
                RaisePropertyChanged(() => IngredientFive);
            }
        }
        public bool IngredientSix
        {
            get { return ingredientSix; }
            set
            {
                ingredientSix = value;
                RaisePropertyChanged(() => IngredientSix);
            }
        }

        #endregion
    }
}
