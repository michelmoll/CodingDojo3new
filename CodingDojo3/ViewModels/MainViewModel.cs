﻿using CodingDojo4DataLib;
using CodingDojo4DataLib.Converter;
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
        public Array Currencies
        {
            get { return Enum.GetValues(typeof(Currencies)); }
        }

        public Currencies SelectedCurrency
        {
            get { return selectedCurrency;}
            set
            {
                selectedCurrency = value;
                Onchange("SelectedCurrency");
                StartConversion();
            }
        }

        private void StartConversion()
        {
            foreach (var item in Items)
            {
                item.CalculateSalesPriceFromEuro(SelectedCurrency);
                item.CalculatePurchasePriceFromEuro(SelectedCurrency);
            }
        }

        private List<StockEntry> stock;

        private ObservableCollection<StockEntryViewModel> items = new ObservableCollection<StockEntryViewModel>();
        private Currencies selectedCurrency;

        public ObservableCollection<StockEntryViewModel> Items
        {
            get {return items;}
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
