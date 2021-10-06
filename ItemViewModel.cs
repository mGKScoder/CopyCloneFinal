using ReactiveUI;
using System.Reactive;

namespace CopyCloneFinal.ViewModel
{
    public class ItemViewModel: ReactiveObject
    {
        private ItemDataViewModel _data;
        public ItemDataViewModel Data
        {
            get => _data;
            set => this.RaiseAndSetIfChanged(ref _data, value);
        }

        private MainViewModel _mainViewModel;

        public ItemViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        private ReactiveCommand<Unit, Unit> _copyItemCommand;
        public ReactiveCommand<Unit, Unit> CopyItemCommand => _copyItemCommand ??= ReactiveCommand.Create<Unit, Unit>((unit) =>
        {
            _mainViewModel?.CopyItem(this);
            return Unit.Default;
        });

        private ReactiveCommand<Unit, Unit> _cloneItemCommand;
        public ReactiveCommand<Unit, Unit> CloneItemCommand => _cloneItemCommand ??= ReactiveCommand.Create<Unit, Unit>((unit) =>
        {
            _mainViewModel.CloneItem(this);
            return Unit.Default;
        });
    }
}
