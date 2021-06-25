using System;
using System.Drawing;

namespace WeatherApp.WeatherInfomation
{
    /// <summary>
    /// 天気情報格納用クラス
    /// </summary>
    public class WeatherInfomation
    {
        //時間
        public DateTime? DT { get; set; }

        //天気(画像URL)
        public string Weather { get; set; }

        //降水量
        public float? Precipitation { get; set; }

        //気温
        public float? Temperature { get; set; }

        //風速
        public float? WindSpeed { get; set; }

        //風向き
        public string WindDirection { get; set; }

        //集計関数
        public WeatherInfomation(DateTime? dt, string weather, float? precipitation, float? temperature, float? windS, string windD)
        {
            DT = dt;
            Weather = weather;
            Precipitation = precipitation;
            Temperature = temperature;
            WindSpeed = windS;
            WindDirection = windD;
        }
    }
}
