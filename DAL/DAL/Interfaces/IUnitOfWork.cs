using DAL.ModelsDAL;
using DAL.ModelsDAL.Serivces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Area> Areas { get; }
        public IRepository<Contract> Contracts { get; }
        public IRepository<Organization> Organizations { get; }
        public IRepository<Person> People { get; }
        public IRepository<ServiceHardware> ServiceHardware { get; }
        public IRepository<ServiceInfo> ServiceInfo { get; }
        public IRepository<ServiceSoftware> ServiceSoftware { get; }
        public void Save();
    }
}
