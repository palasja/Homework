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
            var endDate = DateTime.Parse("2020-12-31");

            var cStart = DateTime.Now;
            var cEnd = DateTime.Now;

            Console.WriteLine((startDate < cStart && endDate < cStart));
            Console.WriteLine((startDate > cEnd && endDate > cEnd));
            Console.WriteLine("=================Convert=======================");
            Console.WriteLine(!(startDate < cStart && endDate < cStart));
            Console.WriteLine(!(startDate > cEnd && endDate > cEnd) || !(startDate > cEnd && endDate > cEnd));

            Console.WriteLine(!(startDate < cStart && endDate < cStart));

            /*(c => (!(startDate < cStart && endDate < cStart) || !(startDate > cEnd && endDate > cEnd)*/
            /*            Console.WriteLine((endDate.Year - startDate.Year) *12 + (endDate.Month - startDate.Month));*/
        }



    }

    

}
