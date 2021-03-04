using AutoMapper;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using BLL.Services;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class Program
    {

        static void Main(string[] args)
        {
            var getOrg = OrganizationService.GetOrganizationOnArea(new AreaToMenu() { Id = 3, SimpleName = "Наровля" });
            var area = AreaServices.GetAreasSimple();
            foreach (var item in getOrg)
            {
                Console.WriteLine(item.FullName);
            }
        }

        public static List<OrganizationDTO> GetOrganizationOnArea(AreaToMenu area)
        {
            IUnitOfWork uow = new UnitOfWork();
            var AllOrganizations = uow.Organizations.GetAll();
            var AreaOrganization = AllOrganizations.Where(org => org.Area.Id == area.Id).ToList();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
            var mapper = new Mapper(config);
            var organization = mapper.Map<List<OrganizationDTO>>(AreaOrganization);

            return organization.OrderBy(org => org.FullName).ToList();
        }
    }

    

}
