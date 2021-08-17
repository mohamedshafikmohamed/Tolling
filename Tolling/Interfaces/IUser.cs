using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Models;

namespace Tolling.Interfaces
{
   public  interface IUser
    {
        public  void Create(User user);
        public  IEnumerable<User> GetUsers();
        public User GetUser(int id);
        public User SignIn(SignIn signIn);
        public  void Update(User user);
        public  void Delete(int id);
    }        
}
