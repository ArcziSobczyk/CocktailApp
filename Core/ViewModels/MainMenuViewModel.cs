using Core.Intrefaces;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Core.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }

        #region Command
        private IMvxAsyncCommand recipiesCommand;
        private IMvxAsyncCommand funFactCommand;
        private IMvxCommand exitCommand;
        public IMvxAsyncCommand RecipiesCommand => recipiesCommand = recipiesCommand ?? new MvxAsyncCommand(GoToRecipies);
        public IMvxAsyncCommand FunFactCommand => funFactCommand = funFactCommand ?? new MvxAsyncCommand(GoToFunFact);
        public IMvxCommand ExitCommand => exitCommand = exitCommand ?? new MvxCommand(onBackPressed);
        #endregion

        #region Navigation
        private async Task GoToRecipies()
        {
            await NavigationService.Navigate<RecipiesViewModel>();
        }
        private async Task GoToFunFact()
        {
            await NavigationService.Navigate<FunFactViewModel>();
        }
        #endregion
    }
}