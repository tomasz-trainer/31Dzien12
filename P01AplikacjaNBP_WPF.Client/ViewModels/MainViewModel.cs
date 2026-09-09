using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P01AplikacjaNBP_WPF.Client.Models;
using P01AplikacjaNBP_WPF.Client.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace P01AplikacjaNBP_WPF.Client.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        private readonly IWebApiService _webApiService;

        public MainViewModel(IWebApiService webApiService)
        {
            _webApiService = webApiService;
        }

        private ObservableCollection<Rate> _exchangeRates = new ObservableCollection<Rate>();

        [RelayCommand]
        private async Task LoadRatesAsync()
        {
            var rates = await _webApiService.GetExchangeRatesAsync();
            _exchangeRates.Clear();
            foreach (var rate in rates)
            {
                _exchangeRates.Add(rate);
            }

        }
    }
}
