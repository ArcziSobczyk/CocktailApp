using Core.Services;
using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class FunFactViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        private IMvxCommand? backCommand;
        public IMvxCommand BackCommand => backCommand = backCommand ?? new MvxCommand(onBackPressed);
    }
}
