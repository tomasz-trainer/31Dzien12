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

        [ObservableProperty]
        private ObservableCollection<Rate> rates = new ObservableCollection<Rate>();

        [RelayCommand]
        private async Task LoadRatesAsync()
        {
            var _rates = await _webApiService.GetExchangeRatesAsync();
            rates.Clear();
            foreach (var rate in _rates)
            {
                rates.Add(rate);
            }

        }
    }
}
