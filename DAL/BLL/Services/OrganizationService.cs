using AutoMapper;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using BLL.ModelsDTO.Serivces;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using DAL.ModelsDAL.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrganizationService
    {
        

        public async Task<List<OrganizationDTO>> GetOrganizationOnAreaAsync(int areaId )
        {
            List<OrganizationDTO> organization = new List<OrganizationDTO>();
            using (IUnitOfWork uow = new UnitOfWork()) {
                var AllOrganizations = await uow.Organizations.GetAllAsync();
                var AreaOrganization = AllOrganizations.Where(org => org.AreaId == areaId).OrderBy(org => org.FullName).ToList();
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
                var mapper = new Mapper(config);
                organization = mapper.Map<List<OrganizationDTO>>(AreaOrganization);

            }

            return organization;
        }
    }
}
