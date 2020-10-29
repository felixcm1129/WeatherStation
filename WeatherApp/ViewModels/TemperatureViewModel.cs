using System;
using System.Collections.Generic;
using System.Text;
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
        public TemperatureModel CurrentTemp { get; private set; }

        public TemperatureViewModel()
        {
            
        }

        public double CelsiusInFahrenheit(double c)
        {
            return c;
        }

        public double FahrenheitInCelsius(double f)
        {
            return f;
        }

        public bool CanGetTemp()
        {
            throw new NotImplementedException();
        }

        public void SetTemperatureService(ITemperatureService service)
        {
            TemperatureService = service;
        }

    }
}
