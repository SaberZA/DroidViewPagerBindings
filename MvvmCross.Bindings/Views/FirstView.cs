using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using MvvmCross.Bindings.Core.ViewModels;

namespace MvvmCross.Bindings.Views
{
    [Activity(Label = "View for FirstListViewModel", MainLauncher = true)]
    public class FirstView : MvxActivity<FirstListViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}