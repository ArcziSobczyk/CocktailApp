using Core.Models;
using Core.Resources;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class RecipiesViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        #region Commands
        private IMvxCommand backPressedCommand;
        private IMvxAsyncCommand margharitaCommand;
        private IMvxAsyncCommand mohitoCommand;
        private IMvxAsyncCommand cubaLibreCommand;
        private IMvxAsyncCommand pinaColadaCommand;
        private IMvxAsyncCommand whiskySourCommand;
        private IMvxAsyncCommand cosmopolitanCommand;
        private IMvxAsyncCommand pornstarMartiniCommand;
        private IMvxAsyncCommand negroniCommand;
        private IMvxAsyncCommand espressoMartiniCommand;
        private IMvxAsyncCommand moscowMuleCommand;
        private IMvxAsyncCommand manhattanCommand;
        private IMvxAsyncCommand daiquiriCommand;
        private IMvxAsyncCommand oldFashionedCommand;
        private IMvxAsyncCommand blackWhiteRussian;
        private IMvxAsyncCommand sexOnTheBeach;

        public IMvxCommand BackPressedCommand => backPressedCommand = backPressedCommand ?? new MvxCommand(onBackPressed);
        public IMvxAsyncCommand MargharitaCommand => margharitaCommand = margharitaCommand ?? new MvxAsyncCommand(GoToMargharitaCommand);
        public IMvxAsyncCommand MohitoCommand => mohitoCommand = mohitoCommand ?? new MvxAsyncCommand(GoToMohitoCommand);
        public IMvxAsyncCommand CubaLibreCommand => cubaLibreCommand = cubaLibreCommand ?? new MvxAsyncCommand(GoToCubaLibreCommand);
        public IMvxAsyncCommand PinaColadaCommand => pinaColadaCommand = pinaColadaCommand ?? new MvxAsyncCommand(GoToPinaColadaCommand);
        public IMvxAsyncCommand WhiskySourCommand => whiskySourCommand = whiskySourCommand ?? new MvxAsyncCommand(GoToWhiskySourCommand);
        public IMvxAsyncCommand CosmopolitanCommand => cosmopolitanCommand = cosmopolitanCommand ?? new MvxAsyncCommand(GoToCosmopolitanCommand);
        public IMvxAsyncCommand PornstarMartiniCommand => pornstarMartiniCommand = pornstarMartiniCommand ?? new MvxAsyncCommand(GoToPornstarMartiniCommand);
        public IMvxAsyncCommand NegroniCommand => negroniCommand = negroniCommand ?? new MvxAsyncCommand(GoToNegroniCommand);
        public IMvxAsyncCommand EspressoMartiniCommand => espressoMartiniCommand = espressoMartiniCommand ?? new MvxAsyncCommand(GoToEspressoMartiniCommand);
        public IMvxAsyncCommand MoscowMuleCommand => moscowMuleCommand = moscowMuleCommand ?? new MvxAsyncCommand(GoToMoscowMuleCommand);
        public IMvxAsyncCommand BlackWhiteRussian => blackWhiteRussian = blackWhiteRussian ?? new MvxAsyncCommand(GoToBlackWhiteRussianCommand);
        public IMvxAsyncCommand SexOnTheBeach => sexOnTheBeach = sexOnTheBeach ?? new MvxAsyncCommand(GoToSexOnTheBeachCommand);
        public IMvxAsyncCommand ManhattanCommand => manhattanCommand = manhattanCommand ?? new MvxAsyncCommand(GoToManhattanCommand);
        public IMvxAsyncCommand DaiquiriCommand => daiquiriCommand = daiquiriCommand ?? new MvxAsyncCommand(GoToDaiquiriCommand);
        public IMvxAsyncCommand OldFashionedCommand => oldFashionedCommand = oldFashionedCommand ?? new MvxAsyncCommand(GoToOldFashionedCommand);

        #endregion

        #region Methods

        private async Task GoToMargharitaCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.margharitaTitle,
                CocktailDescription = Recipies.margharitaDescription,
                CocktailIngredient1 = Recipies.margharitaIngredient1,
                CocktailIngredient2 = Recipies.margharitaIngredient2,
                CocktailIngredient3 = Recipies.margharitaIngredient3,
                CocktailIngredient4 = Recipies.margharitaIngredient4,
                CocktailRecipe = Recipies.margharitaRecipe
            });
        }

        private async Task GoToMohitoCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.mohitoTitle,
                CocktailDescription = Recipies.mohitoDescription,
                CocktailIngredient1 = Recipies.mohitoIngredient1,
                CocktailIngredient2 = Recipies.mohitoIngredient2,
                CocktailIngredient3 = Recipies.mohitoIngredient3,
                CocktailIngredient4 = Recipies.mohitoIngredient4,
                CocktailIngredient5 = Recipies.mohitoIngredient5,
                CocktailRecipe = Recipies.mohitoRecipe
            });
        }

        private async Task GoToCubaLibreCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.cubaLibreTitle,
                CocktailDescription = Recipies.cubaLibreDescription,
                CocktailIngredient1 = Recipies.cubaLibreIngredient1,
                CocktailIngredient2 = Recipies.cubaLibreIngredient2,
                CocktailIngredient3 = Recipies.cubaLibreIngredient3,
                CocktailRecipe = Recipies.cubaLibreRecipe
            });
        }

        private async Task GoToPinaColadaCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.pinaColadaTitle,
                CocktailDescription = Recipies.pinaColadaDescription,
                CocktailIngredient1 = Recipies.pinaColadaIngredient1,
                CocktailIngredient2 = Recipies.pinaColadaIngredient2,
                CocktailIngredient3 = Recipies.pinaColadaIngredient3,
                CocktailIngredient4 = Recipies.pinaColadaIngredient4,
                CocktailRecipe = Recipies.pinaColadaRecipe
            });
        }

        private async Task GoToWhiskySourCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.whiskySourTitle,
                CocktailDescription = Recipies.whiskySourDescription,
                CocktailIngredient1 = Recipies.whiskySourIngredient1,
                CocktailIngredient2 = Recipies.whiskySourIngredient2,
                CocktailIngredient3 = Recipies.whiskySourIngredient3,
                CocktailIngredient4 = Recipies.whiskySourIngredient4,
                CocktailIngredient5 = Recipies.whiskySourIngredient5,
                CocktailRecipe = Recipies.whiskySourRecipe
            });
        }

        private async Task GoToCosmopolitanCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.cosmopolitanTitle,
                CocktailDescription = Recipies.cosmopolitanDescription,
                CocktailIngredient1 = Recipies.cosmopolitanIngredient1,
                CocktailIngredient2 = Recipies.cosmopolitanIngredient2,
                CocktailIngredient3 = Recipies.cosmopolitanIngredient3,
                CocktailIngredient4 = Recipies.cosmopolitanIngredient4,
                CocktailRecipe = Recipies.cosmopolitanRecipe
            });
        }

        private async Task GoToPornstarMartiniCommand()
        {
            throw new NotImplementedException();
        }

        private async Task GoToNegroniCommand()
        {
            throw new NotImplementedException();
        }

        private async Task GoToEspressoMartiniCommand()
        {
            throw new NotImplementedException();
        }

        private async Task GoToMoscowMuleCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.moscowMuleTitle,
                CocktailDescription = Recipies.moscowMuleDescription,
                CocktailIngredient1 = Recipies.moscowMuleIngredient1,
                CocktailIngredient2 = Recipies.moscowMuleIngredient2,
                CocktailIngredient3 = Recipies.moscowMuleIngredient3,
                CocktailRecipe = Recipies.moscowMuleRecipe
            });
        }

        private async Task GoToManhattanCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.manhattanTitle,
                CocktailDescription = Recipies.manhattanDescription,
                CocktailIngredient1 = Recipies.manhattanIngredient1,
                CocktailIngredient2 = Recipies.manhattanIngredient2,
                CocktailIngredient3 = Recipies.manhattanIngredient3,
                CocktailRecipe = Recipies.manhattanRecipe
            });
        }

        private async Task GoToDaiquiriCommand()
        {
            throw new NotImplementedException();
        }

        private async Task GoToOldFashionedCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.oldFashionedTitle,
                CocktailDescription = Recipies.oldFashionedDescription,
                CocktailIngredient1 = Recipies.oldFashionedIngredient1,
                CocktailIngredient2 = Recipies.oldFashionedIngredient2,
                CocktailIngredient3 = Recipies.oldFashionedIngredient3,
                CocktailIngredient4 = Recipies.oldFashionedIngredient4,
                CocktailRecipe = Recipies.oldFashionedRecipe
            });
        }

        private async Task GoToBlackWhiteRussianCommand()
        {
            await NavigationService.Navigate<CocktailViewModel, CocktailParameter>(new CocktailParameter
            {
                CocktailName = Recipies.blackWhiteRussianTitle,
                CocktailDescription = Recipies.blackWhiteRussianDescription,
                CocktailIngredient1 = Recipies.blackWhiteRussianIngredient1,
                CocktailIngredient2 = Recipies.blackWhiteRussianIngredient2,
                CocktailIngredient3 = Recipies.blackWhiteRussianIngredient3,
                CocktailRecipe = Recipies.blackWhiteRussianRecipe
            });;
        }

        private async Task GoToSexOnTheBeachCommand()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
