using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class AddRecipeViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        private IMvxCommand backPressedCommand;
        public IMvxCommand BackPressedCommand => backPressedCommand = backPressedCommand ?? new MvxCommand(onBackPressed);
    }
}
