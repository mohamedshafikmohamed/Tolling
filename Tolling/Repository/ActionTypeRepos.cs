using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
  public  class ActionTypeRepos:IActionType
    {
        private readonly Dbcontext _db;
        public ActionTypeRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(ActionType Actiontype)
        {
            var Locations = _db.ActionType.Where(u => u.ActionName == Actiontype.ActionName).ToList();
            if (Locations.Count != 0)
            {
                throw new Exception("ActionType Is Founded Please Choose Another Name");
            }
            _db.ActionType.Add(Actiontype);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var Actiontype = _db.ActionType.Find(id);
            _db.ActionType.Remove(Actiontype);
            _db.SaveChanges();
        }

        public ActionType GetOne(string id)
        {
            return _db.ActionType.Find(id);
        }

        public IEnumerable<ActionType> GetAll()
        {
            return _db.ActionType.ToList();
        }
        public void Update(ActionType Actiontype)
        {
            _db.ActionType.Update(Actiontype);
            _db.SaveChanges();
        }
    }
}

    

