using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ServiceInfoRepository : IRepository<ServiceInfo>
    {
        ContractContext db;

        public ServiceInfoRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<ServiceInfo> GetAll()
        {
            return db.ServiceInfo;
        }

        public ServiceInfo Get(int id)
        {
            return db.ServiceInfo.Find(id);
        }

        public void Create(ServiceInfo serviceInfo)
        {
            db.ServiceInfo.Add(serviceInfo);
        }

        public void Update(ServiceInfo serviceInfo)
        {
            db.Entry(serviceInfo).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ServiceInfo serviceInfo = db.ServiceInfo.Find(id);
            if (serviceInfo != null)
                db.ServiceInfo.Remove(serviceInfo);
        }
    }
}
