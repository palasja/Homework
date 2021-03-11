using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO.Serivces;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class ServiceInfoService : IServiceInfoRepository
    {
        ContractContext context;
        public ServiceInfoService(ContractContext context)
        {
            this.context = context;
        }
        public async Task<List<ServiceInfoDTO>> GetServicesInfoAsync()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceInfo, ServiceInfoDTO>());
            var mapper = new Mapper(config);
            List<ServiceInfo> services = await context.ServiceInfo.ToListAsync();

            return mapper.Map<List<ServiceInfoDTO>>(services);
        }
    }
}
