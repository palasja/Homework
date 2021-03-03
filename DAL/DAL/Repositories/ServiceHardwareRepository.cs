using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        public ServiceHardware Get(int id)
        {
            return db.ServiceHardwares.Find(id);
        }

        public void Create(ServiceHardware serviceHardware)
        {
            db.ServiceHardwares.Add(serviceHardware);
        }

        public void Update(ServiceHardware serviceHardware)
        {
            db.Entry(serviceHardware).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ServiceHardware serviceHardware = db.ServiceHardwares.Find(id);
            if (serviceHardware != null)
                db.ServiceHardwares.Remove(serviceHardware);
        }
    }
}
