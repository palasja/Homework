using AutoMapper;
using BLL.ModelsDTO.Serivces;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL.Serivces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ServiceInfoService
    {
        public async Task<List<ServiceInfoDTO>> GetServicesInfoAsync()
        {
            List<ServiceInfoDTO> organization = new List<ServiceInfoDTO>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var services = await uow.ServiceInfo.GetAllAsync();
                var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceInfo, ServiceInfoDTO>());
                var mapper = new Mapper(config);
                organization = mapper.Map<List<ServiceInfoDTO>>(services);

            }

            return organization;
        }
    }
}
