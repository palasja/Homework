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
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class Program
    {

        static void Main(string[] args)
        {
            var startDate = DateTime.Parse("2019-06-01");
            var endDate = DateTime.Parse("2021-12-31");

            var a = endDate - startDate;
            var q = endDate - startDate;
            /*            ContractService service = new ContractService();

                        var areaDTO = new AreaDTO() { Id = 3, FullName = "Наровлянский район", SimpleName = "Наровля" };

                        Console.WriteLine(service.GetCostOnPeriod(areaDTO, startDate, endDate).Result); */
            Console.WriteLine((endDate.Year - startDate.Year) *12 + (endDate.Month - startDate.Month));
        }



    }

    

}
