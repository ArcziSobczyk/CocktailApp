using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
	public abstract class BaseViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>, IMvxViewModel
	{
		public BaseViewModel() : base() { }

		public abstract void Prepare(TParameter parameter);
	}
}
