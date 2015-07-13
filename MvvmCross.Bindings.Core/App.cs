using Cirrious.CrossCore.IoC;
using MvvmCross.Bindings.Core.ViewModels;

namespace MvvmCross.Bindings.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
				
            RegisterAppStart<FirstListViewModel>();
        }
    }
}