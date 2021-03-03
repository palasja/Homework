using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class AreaRepository : IRepository<Area>
    {
        ContractContext db;

        public AreaRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<Area> GetAll()
        {
            return db.Areas;
        }

        public Area Get(int id)
        {
            return db.Areas.Find(id);
        }

        public void Create(Area area)
        {
            db.Areas.Add(area);
        }

        public void Update(Area area)
        {
            db.Entry(area).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Area area = db.Areas.Find(id);
            if (area != null)
                db.Areas.Remove(area);
        }
    }
}
