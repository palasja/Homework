using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<ServiceInfo> GetAsync(int id)
        {
            return await db.ServiceInfo.FindAsync(id);
        }

        public async void CreateAsync(ServiceInfo serviceInfo)
        {
            await db.ServiceInfo.AddAsync(serviceInfo);
        }

        public void Update(ServiceInfo serviceInfo)
        {
            db.Entry(serviceInfo).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            ServiceInfo serviceInfo = await db.ServiceInfo.FindAsync(id);
            if (serviceInfo != null)
                db.ServiceInfo.Remove(serviceInfo);
        }
    }
}
