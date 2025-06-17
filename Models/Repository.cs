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
            _users.Add(new UserInfo() { Name = "Salih GÜNAYDIN", Email = "salihgunaydin@jandarma.gov.tr", Phone = "5419613419", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Şerife Nur", Email = "soyhaan7@gmail.com", Phone = "5437714841", WillAttend = true });
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