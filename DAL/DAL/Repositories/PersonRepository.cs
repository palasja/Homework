using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        ContractContext db;

        public PersonRepository(ContractContext db)
        {
            this.db = db;
        }

        public IEnumerable<Person> GetAll()
        {
            return db.People;
        }

        public async Task<Person> GetAsync(int id)
        {
            return await db.People.FindAsync(id);
        }

        public async void CreateAsync (Person person)
        {
            await db.People.AddAsync(person);
        }

        public void Update(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
        }

        public async void DeleteAsync(int id)
        {
            Person person = await db.People.FindAsync(id);
            if (person != null)
                db.People.Remove(person);
        }
    }
}
