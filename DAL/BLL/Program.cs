﻿using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork uof = new UnitOfWork();
            var area = uof.Areas.GetAll();
            foreach (var item in area)
            {
                Console.WriteLine(item);
            }
        }
    }
}
