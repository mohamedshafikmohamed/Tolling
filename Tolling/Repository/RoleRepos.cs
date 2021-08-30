using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class RoleRepos:IRole
    {
        private readonly Dbcontext _db;
        public RoleRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Role role)
        {

            _db.Role.Add(role);
            _db.SaveChanges();
          
        }

        public void Delete(string id)
        {
            var role = _db.Role.Find(id);
            _db.Role.Remove(role);
            _db.SaveChanges();
        }

        public Role GetOne(string id)
        {
            return _db.Role.Find(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _db.Role.ToList();
        }
        public void Update(Role role)
        {
            _db.Role.Update(role);
            _db.SaveChanges();
        }

    }
}
