﻿using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ContractRepository : IRepository<Contract>
    {
        ContractContext db;

        public ContractRepository(ContractContext db)
        {
            this.db = db;
        }
        public async Task<List<Contract>> GetAllAsync()
        {
            return await db.Contracts.ToListAsync();
        }

        public async Task<Contract> GetAsync(int id)
        {
            return await db.Contracts.FindAsync(id);
        }

        public async Task CreateAsync(Contract contract)
        {
            await db.Contracts.AddAsync(contract);
        }

        public void Update(Contract contract)
        {
            db.Entry(contract).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            Contract contract = await db.Contracts.FindAsync(id);
            if (contract != null)
                db.Contracts.Remove(contract);
        }
    }
}