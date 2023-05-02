using Core.Services;
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

        private IMvxCommand? backPressedCommand;
        private IMvxAsyncCommand? addNoteCommand;

        public IMvxCommand BackPressedCommand => backPressedCommand = backPressedCommand ?? new MvxCommand(onBackPressed);
        public IMvxAsyncCommand AddNoteCommand => addNoteCommand = addNoteCommand ?? new MvxAsyncCommand(GoToAddNoteCommand);

        private async Task GoToAddNoteCommand()
        {
            await NavigationService.Navigate<AddRecipeViewModel>();
        }
    }
}
