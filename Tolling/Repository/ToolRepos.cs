using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tolling.Data;
using Tolling.Interfaces;
using Tolling.Models;

namespace Tolling.Repository
{
    public class ToolRepos : ITool
    {
        private readonly Dbcontext _db;
        public ToolRepos(Dbcontext db)
        {
            _db = db;
        }
        public void Create(Tool tool)
        {
            var Tools = _db.Tool.Where(u => u.SerialNumber == tool.SerialNumber).ToList();
            if (Tools.Count != 0)
            {
                throw new Exception("Tool Is Founded Please Choose Another SerialNumber");
            }
            _db.Tool.Add(tool);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var tool = _db.Tool.Find(id);
            _db.Tool.Remove(tool);
            _db.SaveChanges();
        }

        public Tool GetOne(int id)
        {
            return _db.Tool.Find(id);
        }

        public IEnumerable<Tool> GetAll()
        {
            return _db.Tool.ToList();
        }
        public  void Update(Tool tool)
        {
            _db.Tool.Update(tool);
            _db.SaveChanges();
        }
    }
}
