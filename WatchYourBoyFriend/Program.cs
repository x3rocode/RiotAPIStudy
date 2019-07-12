using HamsterRiotAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchYourBoyFriend
{
    public enum Status
    {
        None, GamePlaying, GameEnd, Offline
    }
    class Program
    {
        static string ReadAPIKey()
        {
            var api = File.ReadAllText("apikey/apikey.txt");
            Config.APIKey = api;
            return api;
        }
        static void Main(string[] args)
        {
            ReadAPIKey();
        }
    }
}
