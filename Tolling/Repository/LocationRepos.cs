using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class LocationRepos:ILocation
    {
        private readonly Dbcontext _db;
        public LocationRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Location location)
        {
            var Locations = _db.Location.Where(u => u.LocationName == location.LocationName).ToList();
            if (Locations.Count != 0)
            {
                throw new Exception("Locations Is Founded Please Choose Another Name");
            }
            _db.Location.Add(location);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var location = _db.Location.Find(id);
            _db.Location.Remove(location);
            _db.SaveChanges();
        }

        public Location GetOne(int id)
        {
            return _db.Location.Find(id);
        }

        public IEnumerable<Location> GetAll()
        {
            return _db.Location.ToList();
        }
        public void Update(Location location)
        {
            _db.Location.Update(location);
            _db.SaveChanges();
        }
    }
}
