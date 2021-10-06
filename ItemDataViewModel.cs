using ReactiveUI;

namespace CopyCloneFinal.ViewModel
{
    public class ItemDataViewModel: ReactiveObject
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref _text, value);
        }
    }
}
