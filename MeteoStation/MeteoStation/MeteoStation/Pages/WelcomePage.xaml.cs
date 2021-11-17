using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeteoStation.Pages
{

    public partial class WelcomePage : ContentPage
    {
        public const string BUTTON_WEATHER_TEXT = "УЗНАТЬ ПОГОДУ";
        public const string BUTTON_ALARM_TEXT = "УСТАНОВИТЬ БУДИЛЬНИК";

        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void GetWeather_Click(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new WeatherPage());

        }
        private async void GetAlarm_Click(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new AlarmPage());

        }

    }
}