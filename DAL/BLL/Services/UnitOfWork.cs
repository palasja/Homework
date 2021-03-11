using BLL.Interfaces;
using DAL;
using System;


namespace BLL.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private ContractContext db = new ContractContext();

        private AreaServices areaRepository;
        private ContractService contractRepository;
        private OrganizationService organizationRepository;
        private ServiceInfoService serviceInfoRepository;
        /*        private PersonRepository personRepository;
                private ServiceHardwareRepository serviceHardwareRepository;
        private ServiceSoftwareRepository serviceSoftwareRepository;*/


        public IAreaRepositiry Areas
        {
            get
            {
                if (areaRepository == null)
                    areaRepository = new AreaServices(db);
                return areaRepository;
            }
        }
        public IOrganizationRepository Organizations
        {
            get
            {
                if (organizationRepository == null)
                    organizationRepository = new OrganizationService(db);
                return organizationRepository;
            }
        }

        public IContractsService Contracts
        {
            get
            {
                if (contractRepository == null)
                    contractRepository = new ContractService(db);
                return contractRepository;
            }
        }
        public IServiceInfoRepository ServicesInfo
        {
            get
            {
                if (serviceInfoRepository == null)
                    serviceInfoRepository = new ServiceInfoService(db);
                return serviceInfoRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.DisposeAsync();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
