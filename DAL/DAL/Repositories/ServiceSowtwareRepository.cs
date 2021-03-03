using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        public ServiceSoftware Get(int id)
        {
            return db.ServiceSoftwares.Find(id);
        }

        public void Create(ServiceSoftware serviceSoftware)
        {
            db.ServiceSoftwares.Add(serviceSoftware);
        }

        public void Update(ServiceSoftware serviceSoftware)
        {
            db.Entry(serviceSoftware).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ServiceSoftware serviceSoftware = db.ServiceSoftwares.Find(id);
            if (serviceSoftware != null)
                db.ServiceSoftwares.Remove(serviceSoftware);
        }
    }
}
