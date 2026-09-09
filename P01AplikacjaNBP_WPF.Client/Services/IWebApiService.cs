using P01AplikacjaNBP_WPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01AplikacjaNBP_WPF.Client.Services
{
    public interface IWebApiService
    {
        public Task<Rate[]> GetExchangeRatesAsync();
    }
}
