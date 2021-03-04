using AutoMapper;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Services
{
    public static class OrganizationService
    {
        static IUnitOfWork uow = new UnitOfWork();

        public static List<OrganizationDTO> GetOrganizationOnArea(AreaToMenu area )
        {
            var AllOrganizations = uow.Organizations.GetAll();
            var AreaOrganization  = AllOrganizations.Where(org => org.AreaId == area.Id).ToList();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>() );
            var mapper = new Mapper(config);
            var organization = mapper.Map<List<OrganizationDTO>>(AreaOrganization);

            return organization.OrderBy(org => org.FullName).ToList();
        }
    }
}
