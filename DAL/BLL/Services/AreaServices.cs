using AutoMapper;
using BLL.ModelsBLL;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public static class AreaServices
    {
        static IUnitOfWork uof = new UnitOfWork();

        static public List<AreaToMenu> GetAreasSimple()
        {
            var areasDB = uof.Areas.GetAll();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Area, AreaToMenu>());
            var mapper = new Mapper(config);
            var areas = mapper.Map<List<AreaToMenu>>(areasDB);
            
            return areas;
        }


        
    }
}
