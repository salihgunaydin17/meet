using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Salih GÜNAYDIN", Email = "ss@ss.com", Phone = "5555555555", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Şerife Nur", Email = "sss7@gmail.com", Phone = "414234341231", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ali SARI", Email = "sari@hotmail.com", Phone = "5415417898", WillAttend = false });

        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}