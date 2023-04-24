using MvvmCross.Commands;
using System.Threading.Tasks;

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
        private IMvxAsyncCommand ownRecipies;
        private IMvxCommand exitCommand;
        public IMvxAsyncCommand RecipiesCommand => recipiesCommand = recipiesCommand ?? new MvxAsyncCommand(GoToRecipies);
        public IMvxAsyncCommand FunFactCommand => funFactCommand = funFactCommand ?? new MvxAsyncCommand(GoToFunFact);
        public IMvxAsyncCommand OwnRecipiesCommand => ownRecipies = ownRecipies ?? new MvxAsyncCommand(GoToOwnRecipies);
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
        private async Task GoToOwnRecipies()
        {
            await NavigationService.Navigate<OwnRecipiesViewModel>();
        }
        #endregion
    }
}