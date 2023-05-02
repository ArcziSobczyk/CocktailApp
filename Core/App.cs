using Core.Services;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Core
{
    public class App : MvxApplication
    {
		public override void Initialize()
		{
			base.Initialize();
			RegisterCustomAppStart<AppStart>();
		}
	}
}