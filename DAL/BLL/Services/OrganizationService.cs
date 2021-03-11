using AutoMapper;
using BLL.Interfaces;
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
    public class OrganizationService : IOrganizationRepository
    {
        ContractContext context;
        public OrganizationService(ContractContext context)
        {
            this.context = context;
        }

        public async Task<List<OrganizationDTO>> GetOrganizationOnAreaAsync(int areaId )
        {
            List<OrganizationDTO> organization = new List<OrganizationDTO>();
            using (ContractContext context = new ContractContext())
            {
                var AllOrganizations = context.Organizations.Where(org => org.AreaId == areaId).OrderBy(org => org.FullName).ToList();
                var AreaOrganization = AllOrganizations.Where(org => org.AreaId == areaId).OrderBy(org => org.FullName).ToList();
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Organization, OrganizationDTO>());
                var mapper = new Mapper(config);
                organization = mapper.Map<List<OrganizationDTO>>(AreaOrganization);
            }

            return organization;
        }

        public async Task ChangeOrganization(OrganizationDTO organization) 
        {
            var org = context.Organizations.Where(org => org.Id == organization.Id).FirstOrDefault();
            if (!org.Name.Equals(organization.Name)) org.Name = organization.Name;
            if (!org.FullName.Equals(organization.FullName)) org.FullName = organization.FullName;
            if (!org.Address.Equals(organization.Address)) org.Address = organization.Address;
            if (!org.Email.Equals(organization.Email)) org.Email = organization.Email;
            if (!org.Smdo .Equals(organization.Smdo)) org.Smdo = organization.Smdo;
            await context.SaveChangesAsync();

        }

        public async Task AddOrganization(OrganizationDTO organizationDTO, PersonDTO personDTO)
        {
            var configOrganization = new MapperConfiguration(cfg => cfg.CreateMap<OrganizationDTO, Organization>());
            var configPerson = new MapperConfiguration(cfg => cfg.CreateMap<PersonDTO, Person>());

            var mapperOrganization = new Mapper(configOrganization);
            var mapperPerson = new Mapper(configPerson);

            var organization = mapperOrganization.Map<Organization>(organizationDTO);
            var person = mapperPerson.Map<Person>(personDTO);

            person.Organization = organization;

            await context.People.AddAsync(person);
            await context.SaveChangesAsync();
        }
    }

}
