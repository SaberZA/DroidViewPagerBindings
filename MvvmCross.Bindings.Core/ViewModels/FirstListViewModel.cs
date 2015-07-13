using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmCross.Bindings.Core.ViewModels
{
    public class FirstListViewModel 
		: MvxViewModel
    {
		private ObservableCollection<FirstViewModel> _items;
        public ObservableCollection<FirstViewModel> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        public FirstListViewModel()
        {
            Items = new ObservableCollection<FirstViewModel>();
            for (var i = 0; i < 5; i++)
                Items.Add(new FirstViewModel { Name = "Item " + i, Description = "I am Item " + i });
        }

        private static void ShowItemPageChanged(FirstViewModel toPage)
        {
            MvxTrace.TaggedTrace("SimpleListViewModel", "Page changed to {0}", toPage.Name);
        }

        public ICommand ItemPageChangedCommand
        {
            get { return new MvxCommand<FirstViewModel>(ShowItemPageChanged); }
        }

        private static void ShowPageChanged(int toPage)
        {
            MvxTrace.TaggedTrace("SimpleListViewModel", "Page changed to {0}", toPage);
        }

        public ICommand PageChangedCommand
        {
            get { return new MvxCommand<int>(ShowPageChanged); }
        }
    }
}
