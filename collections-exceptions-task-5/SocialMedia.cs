using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_exceptions_task_5
{
    internal class SocialMedia
    {
        public Dictionary<string, List<string>> Friends { get; }

        public SocialMedia()
        {
            Friends = new Dictionary<string, List<String>>();
        }

        public void AddFriend(string username, string friend)
        {
            if (!Friends.ContainsKey(username))
                Friends[username] = new List<String>() { friend };
            else if (Friends.ContainsKey(username))
                Friends[username].Add(friend);
        }

        public void RemoveFriend(string username, string friend)
        {
            if (Friends.ContainsKey(username))
                Friends[username].Remove(friend);
            else if (!Friends.ContainsKey(username))
                Console.WriteLine("Friend doesn't exist");
        }

        public void GetAllFriendsByUsername(string username)
        {
            if (Friends.ContainsKey(username))
            {
                foreach (var friend in Friends[username])
                {
                    Console.WriteLine($"Friends: {friend}");
                }
            }
            else
                Console.WriteLine("Student not found");
        }
    }
}
