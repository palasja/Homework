﻿using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsBLL;
using BLL.ModelsDTO;
using DAL;
using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AreaServices : IAreaRepositiry
    {
        public AreaServices() {
        }
        public async Task<List<AreaToMenu>> GetAreasSimpleAsync()
        {
            List<AreaToMenu> areas = new List<AreaToMenu>();

            using (var context = new ContractContext())
            {
                areas = await context.Areas.Select(a => new AreaToMenu (){ Id = a.Id, SimpleName = a.SimpleName }).OrderBy(a => a.SimpleName).ToListAsync();
            } 
            return areas;
        }

        public async Task<List<AreaCountOrg>> GetAreasForIndexAsync()
        {
            List<AreaCountOrg> areas = new List<AreaCountOrg>();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Area, AreaDTO>());
            var mapper = new Mapper(config);
            using (var context = new ContractContext())
            {
                areas = await context.Areas.Include(a => a.Organizations).Select(area => new AreaCountOrg()
                {
                    Area = mapper.Map<AreaDTO>(area),
                    CountOrg = area.Organizations.Count()
                }).ToListAsync();
            }
            var a = 0;
            return areas;
        }

        public async Task AddAreaAsync(AreaDTO areaDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AreaDTO, Area>());
            var mapper = new Mapper(config);
            var area = mapper.Map<Area>(areaDTO);

            using (ContractContext context = new ContractContext())
            {
                await context.Areas.AddAsync(area);
                await context.SaveChangesAsync();
            }
        }

        public async Task DelAreaAsync(int id)
        {
            using (ContractContext context = new ContractContext())
            {
                var area = await context.Areas.FindAsync(id);
                context.Areas.Remove(area);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAreaAsync(AreaDTO areaDTO)
        {
            using (var context = new ContractContext())
            {
                var area = context.Areas.Where(a => a.Id == areaDTO.Id).FirstOrDefault();
                area.FullName = areaDTO.FullName;
                area.SimpleName = areaDTO.SimpleName;
                await context.SaveChangesAsync();
            }
        }
    }
}
