using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Interfaces;
using Tolling.Data;
using Tolling.Models;
namespace Tolling.Repository
{
    public class PartRepos:IPart
    {
        private readonly Dbcontext _db;
        public PartRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Part part,ToolPart toolPart)
        {
            


            _db.Part.Add(part);
            _db.SaveChanges();
           
            AssignMToM(toolPart);
        }

        public void Delete(string id)
        {
            var part = _db.Part.Find(id);
            _db.Part.Remove(part);
            _db.SaveChanges();
        }

        public Part GetOne(string id)
        {
            return _db.Part.Find(id);
        }

        public IEnumerable<Part> GetAll()
        {
            return _db.Part.ToList();
        }
        public void Update(Part part,ToolPart toolpart)
        {
            _db.Part.Update(part);
            _db.ToolPart.Update(toolpart);
            _db.SaveChanges();
        }

        public void AssignMToM(ToolPart Toolpart)
        {
           _db.ToolPart.Add(Toolpart);
            _db.SaveChanges();
        }
    
    }
}
