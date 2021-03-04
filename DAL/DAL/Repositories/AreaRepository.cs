using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            return db.Areas ;
        }

        public async Task<Area> GetAsync(int id)
        {
            return await db.Areas.FindAsync(id);
        }

        public async void CreateAsync(Area area)
        {
            await db.Areas.AddAsync(area);
        }

        public void Update(Area area)
        {
           db.Entry(area).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            Area area = await db.Areas.FindAsync(id);
            if (area != null)
                db.Areas.Remove(area);
        }
    }
}
