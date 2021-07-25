using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using weather;

namespace WeatherApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Dictionary<string, string>areaList {get;set;}

        public MainWindow()
        {
            InitializeComponent();
            

            var areaList = new Area().areaTable;

            comboBoxArea.ItemsSource = areaList;
        }

        /// <summary>
        /// 情報収集及び表示する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowArea_Click(object sender, RoutedEventArgs e)
        {
            var weatherScraping = new WeatherScraping();

            var url = (string)comboBoxArea.SelectedValue;
            var html = weatherScraping.GetHtml(url);
            //リスト構造完成
            var lines = weatherScraping.GetWeather(html);

            WeatherListView.ItemsSource = lines;

        }

        /// <summary>
        /// 画面下部ListViewクリック時に画面中央に詳細情報を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeatherListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //選択したListのインデックスを取得
            //var selectIndex = WeatherListView.SelectedIndex;

            if (WeatherListView.SelectedIndex > -1)
            {

                WeatherInfomation.WeatherInfomation selectItem = (WeatherInfomation.WeatherInfomation)WeatherListView.SelectedItems[0];

                WeatherImageImage.Source = new BitmapImage(new Uri(selectItem.Weather));

                DTtextblock.Text = selectItem.DT.ToString();

                TemperatureBlock.Text = String.Format("気温　　:　{0}℃", selectItem.Temperature.ToString());

                PrecipitationBlock.Text = String.Format("降水量　:　{0}mm/h", selectItem.Precipitation.ToString());

                WindSpeedBlock.Text = String.Format("風速　　:　{0}m/s", selectItem.WindSpeed.ToString());

                WindDirectionBlock.Text = String.Format("風向き　 :　{0}", selectItem.WindDirection.ToString());
            }
        }

        /// <summary>
        /// ウィンドウ移動処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
