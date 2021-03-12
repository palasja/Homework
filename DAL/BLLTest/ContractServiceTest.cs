using System;
using Xunit;
using DAL.ModelsDAL;
using Moq;
using DAL.Repositories;
using BLL.Services;

namespace BLLTest
{
    public class ContractServiceTest
    {
        [Fact]
        public void GetMonthActionContract_Call_Return()
        {
            ContractService cs = new ContractService();
            var contract = new Contract()
            {
                StartDate = DateTime.Parse("2021-01-01"),
                EndDate = DateTime.Parse("2021-02-01"),
            };
            var result = cs.GetMonthActionContract(contract, DateTime.Parse("2020-01-01"), DateTime.Parse("2021-03-15"));

            Assert.Equal(2, result);
        }
    }
}
