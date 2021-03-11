using DAL.ModelsDAL;
using System;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IAreaRepositiry Areas { get; }
        public IOrganizationRepository Organizations { get;  }
        public IContractsService Contracts { get; }
        public IServiceInfoRepository ServicesInfo { get; }
    }
}
