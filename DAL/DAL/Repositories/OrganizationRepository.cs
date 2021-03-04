using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Organization> GetAsync(int id)
        {
            return await db.Organizations.FindAsync(id);
        }

        public async void CreateAsync(Organization organization)
        {
            await db.Organizations.AddAsync(organization);
        }

        public void Update(Organization organization)
        {
            db.Entry(organization).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            Organization organization = await db.Organizations.FindAsync(id);
            if (organization != null)
                db.Organizations.Remove(organization);
        }
    }
}