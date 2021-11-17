﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MeteoStation.Models;

namespace MeteoStation.Pages
{
    public partial class AlarmPage : ContentPage
    {
        private Alarm alarm;
        private View[] views;
        public AlarmPage()
        {
            InitializeComponent();
            alarm = new Alarm();
            views = new View[]
            {
                datePicker,
                timePicker,
                switchControl,
                slider
            };
        }
        public void DateSelectedHandler(object sender, DateChangedEventArgs e)
        {
            alarm.SetDate(e.NewDate);
            if (alarm.IsDateValid())
            {
                VisualStateManager.GoToState(datePicker, "Valid");
            }
            else
            {
                VisualStateManager.GoToState(datePicker, "Invalid");
            }

            //datePickerText.Text = "Запустится " + alarm.DateStr;
        }
        public void TimeChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                alarm.SetTime(timePicker.Time);

                if (alarm.IsTimeValid())
                {
                    VisualStateManager.GoToState(timePicker, "Valid");
                }
                else
                {
                    VisualStateManager.GoToState(timePicker, "Invalid");
                }
            }
        }
        public void VolumeChangedHandler(object sender, ValueChangedEventArgs e)
        {
            alarm.Volume = (int)e.NewValue;

            sliderText.Text = String.Format("Уровень громкости: {0}", alarm.Volume);
        }
        public void SwitchHandler(object sender, ToggledEventArgs e)
        {
            alarm.IsRepeat = e.Value;

            if (!e.Value)
            {
                switchHeader.Text = "Без повтора";
                return;
            }

            switchHeader.Text = "Повторять каждый день";
        }
        private void OnSaveButtonClicked(object sender, System.EventArgs e)
        {

            if (alarm.IsDateSet && alarm.IsTimeSet)
            {

                alarmSetText.Text = "Будильник установлен на: " + alarm.DateStr + " в " + alarm.TimeStr;
                foreach (var view in views)
                {
                    view.IsEnabled = false;
                }
            }
        }
    }
}