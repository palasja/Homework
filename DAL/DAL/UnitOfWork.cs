using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private ContractContext db = new ContractContext();

        private AreaRepository areaRepository;
        private ContractRepository contractRepository;
        private OrganizationRepository organizationRepository;
        private PersonRepository personRepository;
        private ServiceHardwareRepository serviceHardwareRepository;
        private ServiceInfoRepository serviceInfoRepository;
        private ServiceSoftwareRepository serviceSoftwareRepository;


        public AreaRepository Areas
        {
            get
            {
                if (areaRepository == null)
                    areaRepository = new AreaRepository(db);
                return areaRepository;
            }
        }

        public ContractRepository Contracts
        {
            get
            {
                if (contractRepository == null)
                    contractRepository = new ContractRepository(db);
                return contractRepository;
            }
        }
        public OrganizationRepository Organizations
        {
            get
            {
                if (organizationRepository == null)
                    organizationRepository = new OrganizationRepository(db);
                return organizationRepository;
            }
        }
        public PersonRepository People
        {
            get
            {
                if (personRepository == null)
                    personRepository = new PersonRepository(db);
                return personRepository;
            }
        }
        public ServiceHardwareRepository ServiceHardware
        {
            get
            {
                if (serviceHardwareRepository == null)
                    serviceHardwareRepository = new ServiceHardwareRepository(db);
                return serviceHardwareRepository;
            }
        }
        public ServiceInfoRepository ServiceInfo
        {
            get
            {
                if (serviceInfoRepository == null)
                    serviceInfoRepository = new ServiceInfoRepository(db);
                return serviceInfoRepository;
            }
        }
        public AreaRepository Areas
        {
            get
            {
                if (areaRepository == null)
                    areaRepository = new AreaRepository(db);
                return areaRepository;
            }
        }
    }
    }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
