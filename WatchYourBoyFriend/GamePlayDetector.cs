using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchYourBoyFriend
{
    public class GamePlayDetector
    {
        public List<User> registeredList = new List<User>();

        /// <summary>
        /// 게임 플레이 중인 아이들은 여기에 등록되어요. 게임이 끝나면 여기서 없어져요.
        /// </summary>
        public Dictionary<string, User> gamePlayingUserMap = new Dictionary<string, User>();
        public void Add(string name)
        {
            registeredList.Add(new User()
            {
                current = Status.None,
                userNickName = name
            });
        }

        public void UpdateDetector()
        {
          
            foreach(User v in registeredList)
            {
            
                if (v.current == Status.GamePlaying && gamePlayingUserMap.ContainsKey(v.userNickName) == false)
                {
                    gamePlayingUserMap.Add(v.userNickName, v);
                    Console.WriteLine(v.userNickName + " 게임중 ~ ");
                }
            }

            foreach(User v in gamePlayingUserMap.)
        }
    }
}
