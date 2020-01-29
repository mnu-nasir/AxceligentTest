using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_UserClass
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                
                Console.WriteLine("Please enter the username, or q to exit");
                var userName = Console.ReadLine();
                
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()} ");
            }
        }
    }

    public class User
    {
        private static IList<string> _listOfNames = new List<string>();

        public void Add(string userName)
        {
            _listOfNames.Add(userName);
        }

        public int GetUsersCount()
        {
            return _listOfNames.Count();
        }
    }
}
