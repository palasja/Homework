using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ServiceSoftwareRepository : IRepository<ServiceSoftware>
    {
        ContractContext db;

        public ServiceSoftwareRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<ServiceSoftware> GetAll()
        {
            return db.ServiceSoftwares;
        }

        public async Task<ServiceSoftware> GetAsync(int id)
        {
            return await db.ServiceSoftwares.FindAsync(id);
        }

        public async void CreateAsync(ServiceSoftware serviceSoftware)
        {
           await db.ServiceSoftwares.AddAsync(serviceSoftware);
        }

        public void Update(ServiceSoftware serviceSoftware)
        {
            db.Entry(serviceSoftware).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            ServiceSoftware serviceSoftware = await db.ServiceSoftwares.FindAsync(id);
            if (serviceSoftware != null)
                db.ServiceSoftwares.Remove(serviceSoftware);
        }
    }
}
