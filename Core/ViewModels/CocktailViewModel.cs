using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class CocktailViewModel : BaseViewModel
    {
        public override void onBackPressed()
        {
            NavigationService.Close(this);
        }


    }
}
