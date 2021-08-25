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
        public void Create(Part part)
        {
            


            _db.Part.Add(part);
            _db.SaveChanges();
            ToolPart tp = new ToolPart();
            tp.PartNumber=part.PartNumber;
            AssignToTool(tp);
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
        public void Update(Part part)
        {
            _db.Part.Update(part);
            _db.SaveChanges();
        }

        public void AssignToTool(ToolPart Toolpart)
        {
            _db.ToolPart.Add(Toolpart);
            _db.SaveChanges();
        }
    }
}
