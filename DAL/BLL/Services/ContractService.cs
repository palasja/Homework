using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using BLL.ModelsDTO.Serivces;
using DAL;
using DAL.ModelsDAL;
using DAL.ModelsDAL.Serivces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContractService : IContractsService
    {
        ContractContext context;
        public ContractService(ContractContext context)
        {
            this.context = context;
        }
        public async Task<List<ContractInfo>> GetFullContractOnOrganization(int organizationId)
        {
            List<ContractInfo> fullInfo = new List<ContractInfo>();
            using (var context = new ContractContext())
            {
                var orgContracts = await context.Contracts.Where(con => con.OrganizationId == organizationId).ToListAsync();

                foreach (var contract in orgContracts)
                {
                    var hardwareTask = await HardwaresForContractAsync(contract);
                    var softwareTask = await SoftwaresForContractAsynk(contract);
                    fullInfo.Add(
                        new ContractInfo() {
                            Id = contract.Id,
                            Number = contract.Number,
                            StartDate = contract.StartDate,
                            EndDate = contract.EndDate,
                            HardwareForInfo = hardwareTask,
                            SoftwareForInfo = softwareTask

                        }
                    );
                }
            }
            return fullInfo;
        }

        public async Task AddContract(ContractDTO contractDTO, List<ServiceHardwareDTO> hardwaresDTO, List<ServiceSoftwareDTO> softwaresDTO)
        {
            var configContract = new MapperConfiguration(cfg => cfg.CreateMap<ContractDTO, Contract>());
            var configHardwares = new MapperConfiguration(cfg => cfg.CreateMap<ServiceHardwareDTO, ServiceHardware>());
            var configSoftwares = new MapperConfiguration(cfg => cfg.CreateMap<ServiceSoftwareDTO, ServiceSoftware>());

            var mapperContract = new Mapper(configContract);
            var mapperHardwares = new Mapper(configHardwares);
            var mapperSoftwares = new Mapper(configSoftwares);

            Contract contract = mapperContract.Map<Contract>(contractDTO);
            List<ServiceHardware> hardwares = mapperHardwares.Map<List<ServiceHardware>>(hardwaresDTO);
            List<ServiceSoftware> softwares = mapperSoftwares.Map<List<ServiceSoftware>>(softwaresDTO);
            contract.ServicesHardware = hardwares;
            contract.ServicesSoftware = softwares;

            using (ContractContext context = new ContractContext())
            {
                await context.Contracts.AddAsync(contract);
                await context.SaveChangesAsync();
            }
        }

        public async Task<double> GetCostOnPeriod(int areaId, DateTime startFilter, DateTime endFilter)
        {
            double fullCost = 0;
            var contracts = await FilterContract(areaId, startFilter, endFilter);
            fullCost += GetCostHardware(contracts);
            fullCost += GetCostSoftware(contracts);
            return fullCost;
        }

        private async Task<List<Contract>> FilterContract(int areaId, DateTime startFilter, DateTime endFilter)
        {
            var contracts = new List<Contract>();
            using (ContractContext context = new ContractContext())
            {
                contracts = await context.Contracts.Where(c => c.Organization.AreaId == areaId).Include(c => c.ServicesHardware).ThenInclude(sh => sh.ServiceInfo).
                     Include(c => c.ServicesSoftware).ThenInclude(sh => sh.ServiceInfo).ToListAsync();
            }
            var a = contracts.Where((c => ((!(startFilter < c.StartDate && endFilter < c.StartDate))))).ToList();
            var b = contracts.Where((c => ((!(startFilter > c.EndDate && endFilter > c.EndDate))))).ToList();
            var filtredContracts = contracts.Where((c => (!((startFilter < c.StartDate && endFilter < c.StartDate) || (startFilter > c.EndDate && endFilter > c.EndDate))))).ToList();
            return filtredContracts;
        }

        private double GetCostSoftware(List<Contract> contracts)
        {
            double sum = 0;
            foreach (var contract in contracts)
            {
                foreach (var software in contract.ServicesSoftware)
                {
                    var serviceInfo = software.ServiceInfo;

                    sum += software.MainPlaceCount * serviceInfo.MainCost;
                    sum += software.AdditionalPlaceCount * serviceInfo.AdditionalCost;
                }
            }
            return sum;
        }

        private double GetCostHardware(List<Contract> contracts)
        {
            double sum = 0;
            foreach (var contract in contracts)
            {
                foreach (var software in contract.ServicesHardware)
                {
                    var serviceInfo = software.ServiceInfo;

                    sum += software.ServerCount * serviceInfo.MainCost;
                    sum += software.WorkplaceCount * serviceInfo.AdditionalCost;
                }
            }
            return sum;
        }
        private async Task<List<HardwareForInfo>> HardwaresForContractAsync(Contract contract)
        {
            List<HardwareForInfo> hardwares = new List<HardwareForInfo>();
            using (var context = new ContractContext())
            {
                hardwares = await context.ServiceHardwares.Where(hard => hard.ContractId == contract.Id).Include(info => info.ServiceInfo).
                    Select(item => new HardwareForInfo()
                    {
                        ServerCount = item.ServerCount,
                        WorkplaceCount = item.WorkplaceCount,
                        ServiceInfoName = item.ServiceInfo.Name
                    }).ToListAsync();
            }
            return hardwares;
        }

        private async Task<List<SoftwareForInfo>> SoftwaresForContractAsynk(Contract contract)
        {
            List<SoftwareForInfo> softwares = new List<SoftwareForInfo>();
            using (var context = new ContractContext())
            {
                softwares = await context.ServiceSoftwares.Where(hard => hard.ContractId == contract.Id).Include(info => info.ServiceInfo).
                    Select(item => new SoftwareForInfo()
                    {
                        MainPlaceCount = item.MainPlaceCount,
                        AdditionalPlaceCount = item.AdditionalPlaceCount,
                        ServiceInfoName = item.ServiceInfo.Name
                    }).ToListAsync();
            }
            return softwares;
        }
    }

}
