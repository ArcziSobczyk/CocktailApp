using Core.Services;
using MvvmCross.Commands;
using System;

namespace Core.ViewModels
{
    public class AddRecipeViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        private IMvxCommand? backPressedCommand;
        private IMvxCommand? addRecipeCommand;
        public IMvxCommand BackPressedCommand => backPressedCommand = backPressedCommand ?? new MvxCommand(onBackPressed);
        public IMvxCommand AddRecipeCommand => addRecipeCommand = addRecipeCommand ?? new MvxCommand(addRecipe);

        private void addRecipe()
        {
            try
            {
                DatabaseService.CreateCocktailsTable();
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }
    }
}
