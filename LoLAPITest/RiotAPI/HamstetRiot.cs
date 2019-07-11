using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterRiotAPI.Structure;
namespace HamsterRiotAPI
{
    /// <summary>
    /// 이건 너가 만약에 누군가한테 이 라이브러리를 줬을때... HamsterRiot를 사용하게 만들어야겠지ㅣ.. 가장중요한 서비스 제공 클래스야 ㅇㅇ
    /// </summary>
    public class HamsterRiot
    { 
        /// <summary>
        /// name으로 소환사 정보를 가져옵니다.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static Summoner GetSummonerByName(string userName)
        {
            //http://라이엇..com/v3/summo.../dall4e 
            string requestURL = Config.BaseAPIUrl + APIRepository.SummnonerByNameURL + userName; // url을 만들어서
            var response = HttpRequest.Req(requestURL); //url에 요청을한 결과를 받아와서
            var json = HttpRequest.GetJson(response); //결과물로 json을 만들어서 
            var deserializeObject = JsonConvert.DeserializeObject<Summoner>(json); // json을 deserailize한 오브젝트로 만든다 
            return deserializeObject;
        }

        /// <summary>
        /// id로 소환사 정보를 가져옵니다.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static Summoner GetSummonerByID(string userID)
        {
            string requestURL = Config.BaseAPIUrl + APIRepository.SummnonerByIDURL + userID;
            var response = HttpRequest.Req(requestURL);  
            var json = HttpRequest.GetJson(response);  
            var deserializeObject = JsonConvert.DeserializeObject<Summoner>(json); 
            return deserializeObject;
        }

    }
}
