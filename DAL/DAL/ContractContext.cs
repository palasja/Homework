﻿using DAL.ModelsDAL;
using DAL.ModelsDAL.Serivces;
using DAL.TestRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL
{
    public class ContractContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<ServiceHardware> ServiceHardwares { get; set; }
        public DbSet<ServiceSoftware> ServiceSoftwares { get; set; }
        public DbSet<ServiceInfo> ServiceInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appconfig.json").Build();*/
            var config = new ConfigurationBuilder().SetBasePath(@"D:\C#\Task12\DAL\DAL").AddJsonFile("appconfig.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ConnectionStrings")); ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>().HasData(AreaRepository.getAreas());
            modelBuilder.Entity<ServiceInfo>().HasData(ServiceInfoRepository.getSerivecesInfo());
            modelBuilder.Entity<ServiceSoftware>().HasData(ServiceSoftwareRepository.getSerivecesSoftware());
            modelBuilder.Entity<ServiceHardware>().HasData(ServiceHardwareRepository.getSerivecesHardware());
            modelBuilder.Entity<Person>().HasData(PersonRepository.GetPeople());
            modelBuilder.Entity<Organization>().HasData(OrganizationRepository.GetOrganizations());
            modelBuilder.Entity<Contract>().HasData(ContractRepository.GetContracts());
        }
    }
}
