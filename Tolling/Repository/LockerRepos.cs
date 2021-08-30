using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Interfaces;
using Tolling.Interfaces;
using Tolling.Data;
using Tolling.Models;
namespace Tolling.Repository
{
    public class LockerRepos:ILocker
    {
        private readonly Dbcontext _db;
        public LockerRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Locker locker,LocationDetails locationdetails)
        {
           
            _db.Locker.Add(locker);
            _db.SaveChanges();
            AssignMToM(locationdetails);
        }

        public void Delete(int id)
        {
            var locker = _db.Locker.Find(id);
            _db.Locker.Remove(locker);
            _db.SaveChanges();
        }

        public Locker GetOne(int id)
        {
            return _db.Locker.Find(id);
        }

        public IEnumerable<Locker> GetAll()
        {
            return _db.Locker.ToList();
        }
        public void Update(Locker locker,LocationDetails locationDetails)
        {
            _db.Locker.Update(locker);
            _db.SaveChanges();
            _db.LocationDetails.Update(locationDetails);
            _db.SaveChanges();
        }
        public void AssignMToM(LocationDetails locationdetails)
        {
            _db.LocationDetails.Add(locationdetails);
            _db.SaveChanges();
        }
    }
}