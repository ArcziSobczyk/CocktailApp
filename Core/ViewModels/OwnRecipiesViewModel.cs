using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class OwnRecipiesViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        private IMvxCommand backPressedCommand;
        private IMvxAsyncCommand addRecipeCommand;
        public IMvxCommand BackPressedCommand => backPressedCommand = backPressedCommand ?? new MvxCommand(onBackPressed);
        public IMvxAsyncCommand AddRecipeCommand => addRecipeCommand = addRecipeCommand ?? new MvxAsyncCommand(GoToAddRecipeCommand);

        private async Task GoToAddRecipeCommand()
        {
            await NavigationService.Navigate<AddRecipeViewModel>();
        }
    }
}
