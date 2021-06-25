using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using WeatherApp.WeatherInfomation;
using System;

namespace weather
{
    public class WeatherScraping
    {
        /// <summary>
        /// 引数ultにアクセスした際に取得できるHTMLを返す
        /// </summary>
        /// <param name="url"></param>
        /// <returns>html</returns>
        public string GetHtml(string url)
        {
            // 指定されたURLに対してリスエスト作成
            var req = (HttpWebRequest)WebRequest.Create(url);

            // html取得文字列
            string html = "";

            // 指定したURLに対してReqestを投げてResponseを取得
            using (var res = (HttpWebResponse)req.GetResponse())
            using (var resSt = res.GetResponseStream())
            // 取得した文字列をUTF8でエンコード
            using (var sr = new StreamReader(resSt, Encoding.UTF8))
            {
                // HTMLを取得する。
                html = sr.ReadToEnd();
            }

            return html;
        }

        /// <summary>
        /// 取得したHTMLから天気データをリストに格納して返す
        /// </summary>
        /// <param name="html">HTML文字列</param>
        /// <returns>lines</returns>
        public List<WeatherInfomation> GetWeather(string html)
        {
            //宣言部
            var lines = new List<WeatherInfomation>();
            string line = "";
            
            //一時変数
            DateTime day = DateTime.Today;
            TimeSpan timeSpan;
            DateTime tdt;
            string time = "";
            string strPrecipitation = "";
            string strTemperature = "";
            string strWindS = "";

            //HTMLでdummy対策、数字だけ取り出すための変数
            string iconNo;

            //WeatherInfomationクラス格納用変数
            DateTime? dt = null;
            string weather = "";
            float? precipitation = null;
            float? temperature = null;
            float? windS = null;
            string windD = "";

            


            //天気部分以外を削除
            var weatherHtml = html.Remove(0, html.IndexOf("weather-day__item") + 20);
            weatherHtml = weatherHtml.Remove(weatherHtml.IndexOf("textRight"));

            //細かい不要個所を削除
            //<div><p>タグや改行コードを削除
            var deleteTag = new Regex(".*div.*\n|.*<p>.*\n", RegexOptions.Multiline);//</p>
            var html2 = deleteTag.Match(weatherHtml);

            while (html2.Success)
            {
                weatherHtml = weatherHtml.Replace(html2.Value, "");
                html2 = html2.NextMatch();
            }

            //</p>・</div>タグを削除
            deleteTag = new Regex("</p>|</div.*", RegexOptions.Multiline);
            var html3 = deleteTag.Replace(weatherHtml, "");
            StringReader html4 = new StringReader(html3);
           
            //<br>タグを削除
            deleteTag = new Regex("<br>.*");

            //htmlを一行ごとにDB格納用のデータへ変換してWeatherInfomationクラスへ格納する
            while (true)
            {
                line = html4.ReadLine();

                //行末(null)の場合処理を終了する
                if (line == null)
                {
                    break;
                }

                //日時を検出・編集処理
                if (line.Contains("weather-day__time") == true)
                {
                    time = line.Remove(0, line.IndexOf("weather-day__time") + 19);

                    //日付情報を付与
                    if (time == "00:00")
                    {
                        day = day.AddDays(1);
                    }

                    tdt = DateTime.Parse(time);
                    timeSpan = tdt.TimeOfDay;
                    dt = day.Date + timeSpan;

                }
                //天気を検出・編集処理 //画像ダウンロード
                else if (line.Contains("weather-day__icon") == true)
                {
                    weather = line.Remove(0, line.IndexOf("src") + 5);
                    weather = weather.Substring(0, weather.Length - 2);

                    //URL以外の余計な文字を削除URL形式に編集
                    if (weather.Contains("data-original") == true)
                    {
                        iconNo = Regex.Replace(weather, @"[^100-999]", "");

                        //dummy1...600.png の形式なので、最初の文字だけを削除して正しい数字を得る
                        iconNo = iconNo.Remove(0, 1);
                        weather = String.Format("//smtgvs.weathernews.jp/onebox/img/wxicon/{0}.png", iconNo);
                    }

                    //https:形式に変更
                    weather = String.Format("https:{0}", weather);

                }
                //降水量を検出・編集処理
                else if (line.Contains("weather-day__r") == true)
                {
                    strPrecipitation = line.Remove(0, line.IndexOf("weather-day__r") + 16);
                    //末尾の単位を削除
                    strPrecipitation = strPrecipitation.Remove(strPrecipitation.Length - 4);
                    precipitation = float.Parse(strPrecipitation);

                }
                //気温を検出・編集処理
                else if (line.Contains("weather-day__t") == true)
                {
                    strTemperature = line.Remove(0, line.IndexOf("weather-day__t") + 16);
                    strTemperature = strTemperature.Remove(strTemperature.Length - 1);
                    temperature = float.Parse(strTemperature);
                }
                //風速 風向きを検出・編集処理
                else if (line.Contains("weather-day__w") == true)
                {
                    strWindS = line.Remove(0, line.IndexOf("weather-day__w") + 16);
                    strWindS = deleteTag.Replace(strWindS, "");
                    strWindS = strWindS.Remove(strWindS.Length - 3);
                    windS = float.Parse(strWindS);

                    windD = line.Remove(0, line.IndexOf("<br>") + 4);
                }

                if (dt != null &&
                    weather != "" &&
                    precipitation != null &&
                    temperature != null &&
                    windS != null &&
                    windD != "")
                {
                    var weatherInfomation = new WeatherInfomation(dt, weather, precipitation, temperature, windS, windD);
                    lines.Add(weatherInfomation);

                    dt = null;
                    weather = "";
                    precipitation = null;
                    temperature = null;
                    windS = null;
                    windD = "";
                }
                
            }
            // 天気情報を格納したリストを返す
            return lines;
        }
    }
}
