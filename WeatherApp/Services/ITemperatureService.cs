using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface ITemperatureService
    {
        public Task<TemperatureModel> GetTempAsync();
    }
}
