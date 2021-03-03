using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ContractRepository : IRepository<Contract>
    {
        ContractContext db;

        public ContractRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<Contract> GetAll()
        {
            return db.Contracts;
        }

        public Contract Get(int id)
        {
            return db.Contracts.Find(id);
        }

        public void Create(Contract contract)
        {
            db.Contracts.Add(contract);
        }

        public void Update(Contract contract)
        {
            db.Entry(contract).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Contract contract = db.Contracts.Find(id);
            if (contract != null)
                db.Contracts.Remove(contract);
        }
    }
}
