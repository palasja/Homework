using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class OrganizationRepository : IRepository<Organization>
    {
        ContractContext db;

        public OrganizationRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<Organization> GetAll()
        {
            return db.Organizations;
        }

        public Organization Get(int id)
        {
            return db.Organizations.Find(id);
        }

        public void Create(Organization organization)
        {
            db.Organizations.Add(organization);
        }

        public void Update(Organization organization)
        {
            db.Entry(organization).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Organization organization = db.Organizations.Find(id);
            if (organization != null)
                db.Organizations.Remove(organization);
        }
    }
}