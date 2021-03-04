using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ServiceHardwareRepository : IRepository<ServiceHardware>
    {
        ContractContext db;

        public ServiceHardwareRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<ServiceHardware> GetAll()
        {
            return db.ServiceHardwares;
        }

        public async Task<ServiceHardware> GetAsync(int id)
        {
            return await db.ServiceHardwares.FindAsync(id);
        }

        public async void CreateAsync(ServiceHardware serviceHardware)
        {
            await db.ServiceHardwares.AddAsync(serviceHardware);
        }

        public void Update(ServiceHardware serviceHardware)
        {
            db.Entry(serviceHardware).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            ServiceHardware serviceHardware = await db.ServiceHardwares.FindAsync(id);
            if (serviceHardware != null)
                db.ServiceHardwares.Remove(serviceHardware);
        }
    }
}
