﻿using Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
	public class AppStart : MvxAppStart
	{
		public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService) : base(app, mvxNavigationService) { }

		protected override Task NavigateToFirstViewModel(object? hint = null)
		{
			return NavigationService.Navigate<MainMenuViewModel>();
		}
	}
}
