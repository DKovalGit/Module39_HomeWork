using System;
using System.Collections.Generic;
using System.Text;

namespace MeteoStation.Models
{
    public class Alarm
    {
        public DateTime Date { get; private set; }
        public TimeSpan Time { get; private set; }
        public int Volume { get; set; }
        public bool IsRepeat { get; set; }
        public bool IsDateSet { get; set; }
        public bool IsTimeSet { get; set; }
        public string DateStr
        {
            get
            {
                return Date.ToString("dd.MM.yyyy");
            }
        }
        public string TimeStr
        {
            get
            {
                return Time.ToString("hh\\:mm");
            }
        }

        public Alarm()
        {
            IsDateSet = false;
            IsTimeSet = false;
        }
        public void SetDate(DateTime newDate)
        {
            Date = newDate;
            IsDateSet = true;
        }
        public void SetTime(TimeSpan newTime)
        {
            Time = newTime;
            IsTimeSet = true;
        }

        public bool IsTimeValid()
        {
            var tnow = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            var time = Time.ToString();
            if (time.CompareTo(tnow) == 0 || time.CompareTo(tnow) > 0 || time.CompareTo(tnow) < 0 && Date.CompareTo(DateTime.Today) > 0)
                return true;
            else
                return false;
        }
        public bool IsDateValid()
        {
            return (Date.CompareTo(DateTime.Today) >= 0 ? true : false);
        }

    }
}
