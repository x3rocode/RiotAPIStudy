using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HamsterRiotAPI.HttpUtils
{
    /// <summary>
    /// 라이엇 웹페이지에 요청을 하는 ㅡㅋㄹ래스잖아.. 따로 분리해야지..
    /// </summary>
    public static class HttpRequest
    {
        public static string GetJson(HttpWebResponse response)
        {
            Stream stream = response.GetResponseStream(); // 리스폰스로부터 스트림을 받아와서
            StreamReader reader = new StreamReader(stream, Encoding.UTF8); //UTF8인코딩으로 스트림을 읽을거야
            string text = reader.ReadToEnd(); //처음부터 끝까지 (json을 읽는거야)

            return text; //읽어들인 json을 리턴할꺼야
        }

        public static HttpWebResponse Req(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.PreAuthenticate = true;
            request.Headers.Add("X-Riot-Token", Config.APIKey);

            //여기서 대답
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response;
        }
    }
}
