using DAL.ModelsDAL;
using DAL.ModelsDAL.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.TestRepository
{
    static class ContractRepository
    {
        public static List<Contract> GetContracts()
        {
            var contracts = new List<Contract>();

            contracts.Add(new Contract()
            {
                Id = 1,
                Number = "12-123/ВК6",
                SatartDate = DateTime.Now,
                EndDate = DateTime.Now,
                OrganizationId = 1,
            });
            contracts.Add(new Contract()
            {
                Id = 2,
                Number = "12-1/ГК6",
                SatartDate = DateTime.Now,
                EndDate = DateTime.Now,
                OrganizationId = 2,
            });
            contracts.Add(new Contract()
            {
                Id = 3,
                Number = "33-4/НК-6",
                SatartDate = DateTime.Now,
                EndDate = DateTime.Now,
                OrganizationId = 3,
                
            });
            contracts.Add(new Contract()
            {
                Id = 4,
                Number = "4484/ОИ-6",
                SatartDate = DateTime.Now,
                EndDate = DateTime.Now,
                OrganizationId = 4,
            });;
            return contracts;
        }
    }
}
