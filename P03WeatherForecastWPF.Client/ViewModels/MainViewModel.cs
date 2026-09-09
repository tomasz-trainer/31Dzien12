using P03WeatherForecastWPF.Client.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03WeatherForecastWPF.Client.ViewModels
{
    internal class MainViewModel
    {
        private string _cityName = "Warszawa";
        private City[] _cities;
        private City _selectedCity;
        private Weather weather;



        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        public City[] Cities
        {
            get { return _cities; }
            set { _cities = value; }
        }

        public City SelectedCity
        {
            get { return _selectedCity; }
            set { _selectedCity = value; }
        }

        public Weather Weather
        {
            get { return weather; }
            set { weather = value; }
        }
    }
}
