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
            _users.Add(new UserInfo() { Id = 1, Name = "Salih GÜNAYDIN", Email = "ss@ss.com", Phone = "5555555555", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Şerife Nur", Email = "sss7@gmail.com", Phone = "414234341231", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Ali SARI", Email = "sari@hotmail.com", Phone = "5415417898", WillAttend = false });

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

            user.Id = Users.Count + 1; // Yeni kullanıcı eklendiğinde, ID'sini mevcut kullanıcı sayısına göre ayarlıyoruz.
            _users.Add(user); // Yeni kullanıcıyı listeye ekliyoruz.
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id); // Verilen ID'ye sahip kullanıcıyı buluyoruz. Eğer bulunamazsa null döner.
        }
    }
}