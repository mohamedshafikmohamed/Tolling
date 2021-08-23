using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class UserRepos : IUser
    {
        private readonly Dbcontext _db;
        public UserRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(User user)
        {
           var users = _db.Users.Where(u => u.UserName == user.UserName).ToList();
            if(users.Count!=0)
            {
                throw new Exception("User Is Founded Please Choose Another UserName");
            }
              _db.Users.Add(user);
              _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var user =  _db.Users.Find(id);
             _db.Users.Remove(user);
             _db.SaveChanges();
        }

        public  User GetUser(int id)
        {
            return  _db.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return  _db.Users.ToList();
        }

        public User SignIn(SignIn signIn)
        {
            var user = _db.Users.Where(u => u.UserName == signIn.UserName && u.Password == signIn.Password).ToList();
            if (user.Count==0) return null;
            else return user[0];
        }

        public async void Update(User user)
        {
            _db.Users.Update(user);
             _db.SaveChanges();
        }
        public  string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
