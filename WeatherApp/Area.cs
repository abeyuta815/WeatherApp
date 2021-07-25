using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    /// <summary>
    /// ComboBox用地域クラス
    /// 実装まで行う
    /// </summary>
    public class Area
    {
        public Dictionary<string, string> areaTable { get; set; }

        public Area()
        {
            areaTable = new Dictionary<string, string>()
            {
                {"https://weathernews.jp/onebox/35.665944/139.779250/q=%E6%9D%B1%E4%BA%AC%E9%83%BD%E4%B8%AD%E5%A4%AE%E5%8C%BA&amp;v=03eb9fdc19a3d7be2488ffadb3443caa1ee505918d7e87a96678a5adf4d5c8f4&amp;lang=ja"
                ,"中央区"},
                {"https://weathernews.jp/onebox/35.691836/139.697187/q=%E6%9D%B1%E4%BA%AC%E9%83%BD%E6%96%B0%E5%AE%BF%E5%8C%BA&amp;v=d11c72e1358b131995c4d7163374718ac4c7a4179519c48c7824850e0c3eebe5&amp;lang=ja"
                ,"新宿区"},
                {"https://weathernews.jp/onebox/35.6777222222222/139.770527777778/q=%E6%9D%B1%E4%BA%AC&v=f02d60103eebddd4b43e66485464fc491ef1c14596ce3f73dcdd050eaf83551e&lang=ja"
                ,"東京"},
                {"https://weathernews.jp/onebox/44.0182069444444/144.277411944444/q=%E7%B6%B2%E8%B5%B0&v=1f0af837be3a6e775955963b8e3ceb2bd7916cbb054b76cc8454ea48fb69929f&lang=ja"
                ,"網走"},
                {"https://weathernews.jp/onebox/24.335354/123.818993/q=%E8%A5%BF%E8%A1%A8%E5%B3%B6&v=ae080cdcbd07130e92835a4ec93086c912e7f890e0f3ea1ab947ade8be29f72f&lang=ja"
                ,"西表島"}

            };
        }
    }
}
