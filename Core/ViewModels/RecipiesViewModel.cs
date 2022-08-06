using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class RecipiesViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Navigate<MainMenuViewModel>();
        }
    }
}
