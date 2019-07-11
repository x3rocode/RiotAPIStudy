using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterRiotAPI;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            HamsterRiotAPI.Config.APIKey = "YOUR_API_KEY";
            var obj = HamsterRiot.GetSummonerByName("YOUR_NAME");
            Console.WriteLine(obj.name);
        }
    }
}
