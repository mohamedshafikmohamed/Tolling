using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Models;

namespace Tolling.Interfaces
{
   public  interface IUser:Crud<User,int>
    {
       
        public User SignIn(SignIn signIn);
        
        public  string MD5Hash(string input);
        
           
        
    }        
}
