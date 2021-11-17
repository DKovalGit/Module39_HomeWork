using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MeteoStation.Repository;
using MeteoStation.Models;

namespace MeteoStation.Pages
{
    public partial class WeatherPage : ContentPage
    {

        private Weather _weather;

        private WeatherRepository<Weather>_repo;
        public WeatherPage()
        {
            InitializeComponent();
            _repo = new WeatherRepository<Weather>();
            GetMeteoData();
            Device.StartTimer(TimeSpan.FromSeconds(2), OnTimerTick);
        }
        private bool OnTimerTick()
        {
            GetMeteoData();
            return true;
        }

        private void GetMeteoData()
        {
            _weather = _repo.Get();

            lblTempInside.Text = _weather.TmpInsideText;
            lblTempOutside.Text = _weather.TmpOutsideText;
            lblPressure.Text = _weather.PressureText;
        }

    }
}