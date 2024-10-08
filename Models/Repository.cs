using System.ComponentModel;
using System.Net.Http.Headers;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {Id=1,Name = "test1",Email = "test1@gmail.com",Phone = "testnumber1",WillAttend = true});
            _users.Add(new UserInfo() {Id=2,Name = "test2",Email = "test2@gmail.com",Phone = "testnumber2",WillAttend = false});
            _users.Add(new UserInfo() {Id=3,Name = "test3",Email = "test3@gmail.com",Phone = "testnumber3",WillAttend = true});
        }

        public static List<UserInfo> Users 
        {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id= Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user=>user.Id == id);
        }
    }
}