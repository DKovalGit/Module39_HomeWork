using System;
using System.Collections.Generic;
using System.Text;

namespace MeteoStation.Models
{
    public class Weather
    {
        public int TmpInside { get; set; }
        public int TmpOutside { get; set; }
        public int Pressure { get; set; }

        public string TmpInsideText
        {
            get
            {
                return String.Concat(GetSgn(TmpInside), Math.Abs(TmpInside).ToString(), " °C");
            }
        }

        public string TmpOutsideText
        {
            get
            {
                return String.Concat(GetSgn(TmpOutside), Math.Abs(TmpOutside).ToString(), " °C");
            }
        }
        public string PressureText
        {
            get
            {
                return String.Concat(Pressure.ToString(), " mm");
            }
        }
        private string GetSgn(int tmpVal)
        {
            if (tmpVal > 0)
            {
                return "+ ";
            }
            if (tmpVal < 0)
            {
                return "- ";
            }
            else
                return "";
        }
    }

}
