using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class Tooling_Movement_LogRepos: ITooling_Movement_Log
    {
        private readonly Dbcontext _db;
        public Tooling_Movement_LogRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Tooling_Movement_Log Tooling_Movement_log)
        {
            var location = _db.Tooling_Movement_Log.Where(u => u.serialNumber == Tooling_Movement_log.serialNumber).OrderBy(l => l.Id).ToList();
           if (location.Count==0) 
            {
                Tooling_Movement_log.ActionName = "Initialize At";
            }
           else if (Tooling_Movement_log.LocationId == location[0].LocationId)

            {
                Tooling_Movement_log.ActionName = "Transfer From";

            }
            else
            {
                Tooling_Movement_log.ActionName = "Recieved At";
            }
            _db.Tooling_Movement_Log.Add(Tooling_Movement_log);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Tooling_Movement_log = _db.Tooling_Movement_Log.Find(id);
            _db.Tooling_Movement_Log.Remove(Tooling_Movement_log);
            _db.SaveChanges();
        }

        public Tooling_Movement_Log GetOne(int id)
        {
            return _db.Tooling_Movement_Log.Find(id);
        }

        public IEnumerable<Tooling_Movement_Log> GetAll()
        {
            return _db.Tooling_Movement_Log.ToList();
        }
        public void Update(Tooling_Movement_Log Tooling_Movement_log)
        {
            _db.Tooling_Movement_Log.Update(Tooling_Movement_log);
            _db.SaveChanges();
        }
    }
}
