using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Windows;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet

        public ITemperatureService TemperatureService;

        public DelegateCommand<string> GetTempCommand { get; set; }
        public TemperatureModel CurrentTemp { get; set; }

        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTemp, CanGetTemp);
        }

        public async void GetTemp(string obj)
        {
            CurrentTemp = await TemperatureService.GetTempAsync();
        }

        public static double CelsiusInFahrenheit(double c)
        {
            return c;
        }

        public static double FahrenheitInCelsius(double f)
        {
            return f;
        }

        public bool CanGetTemp(string obj)
        {
            if (TemperatureService == null)
            {
                return false;
            }
            else return true;
        }


        public void SetTemperatureService(ITemperatureService service)
        {
            TemperatureService = service;
        }

    }
}
