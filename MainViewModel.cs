using ReactiveUI;
using System.Linq;

namespace CopyCloneFinal.ViewModel
{
    public class MainViewModel: ReactiveObject
    {
        private ItemViewModel[] _items;
        public ItemViewModel[] Items
        {
            get => _items;
            set => this.RaiseAndSetIfChanged(ref _items, value);
        }

        public MainViewModel()
        {
            Items = new []
            {
                new ItemViewModel(this)
                {
                    Data = new ItemDataViewModel
                    {
                        Text = ""
                    }
                }
            };
        }

        public void CopyItem(ItemViewModel source)
        {
            Items = Items.Concat(new[] {new ItemViewModel(this)
            {
                Data = new ItemDataViewModel
                {
                    Text = source.Data.Text
                }
            }}).ToArray();
        }

        public void CloneItem(ItemViewModel source)
        {
            Items = Items.Concat(new[]
            {
                new ItemViewModel(this)
                {
                    Data = source.Data
                }
            }).ToArray();
        }

        

    }
}
