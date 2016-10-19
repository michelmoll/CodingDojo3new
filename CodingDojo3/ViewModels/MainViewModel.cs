using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private List<StockEntry> stock;

        private ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();

        public ObservableCollection<StockEntryViewModel> Items
        {
            get {return Items;}
            set
            {
                items = value;
            }
        }
        public MainViewModel()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;
            foreach (var item in manager.CurrentStock.OnStock)
            {
                Items.Add(new StockEntryViewModel(item));  //filling view model data stucture
            }
        }

    }
}
