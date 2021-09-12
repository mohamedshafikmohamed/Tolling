using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class LocationDetailsRepos: ILocationDetails
    {
        private readonly Dbcontext _db;
        public LocationDetailsRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(LocationDetails part)
        {

            var x = 7;

            
        }

        public void Delete(int id)
        {
            var LocationDetails = _db.LocationDetails.Find(id);
            _db.LocationDetails.Remove(LocationDetails);
            _db.SaveChanges();
        
            }

        public LocationDetails GetOne(int id)
        {
            return _db.LocationDetails.Find(id);
        }

        public IEnumerable<LocationDetails> GetAll()
        {
            return _db.LocationDetails.ToList();
        }
        public void Update(LocationDetails part)
        {
            _db.LocationDetails.Update(part);
            _db.SaveChanges();
        
            }

        

    }


}
