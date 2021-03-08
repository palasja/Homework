using AutoMapper;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AreaServices
    {


        public async Task<List<AreaToMenu>> GetAreasSimpleAsync()
        {
            List<AreaToMenu> areas = new List<AreaToMenu>();
            using (IUnitOfWork uof = new UnitOfWork())
            {
                var areasDB = await uof.Areas.GetAllAsync();
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Area, AreaToMenu>());
                var mapper = new Mapper(config);
                areas = mapper.Map<List<AreaToMenu>>(areasDB);
            } 
            return areas.OrderBy(a => a.SimpleName).ToList();
        }

        public async Task<List<AreaCountOrg>> GetAreasForIndexAsync()
        {
            List<AreaCountOrg> areas = new List<AreaCountOrg>();
            using (var context = new ContractContext())
            {
                areas = await context.Areas.Include(a => a.Organizations).Select(area => new AreaCountOrg()
                {
                    Area = area,
                    CountOrg = area.Organizations.Count()
                }).OrderBy(area => area.Area.FullName).ToListAsync();
            }
            return areas;
        }

        public void AddAreaAsync(AreaDTO areaDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AreaDTO, Area>());
            var mapper = new Mapper(config);
            var area = mapper.Map<Area>(areaDTO);

            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.Areas.CreateAsync(area);
                uow.SaveAsync();
            }
        }

        public async Task DelAreaAsync(int id)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                await uow.Areas.DeleteAsync(id);
                await uow.SaveAsync();
            }
        }
    }
}
