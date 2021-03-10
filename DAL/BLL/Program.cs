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
            var a = new ContractContext();
            var areas = a.Areas.Select(a => a.FullName);
            foreach (var item in areas)
            {
                Console.WriteLine(item);
            }
/*            a.Dispose();*/
           var areas1 = a.Areas.Select(a => a.SimpleName);

            foreach (var item in areas1)
            {
                Console.WriteLine(item);
            }
        }



    }

    

}
