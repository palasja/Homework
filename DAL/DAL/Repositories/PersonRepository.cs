using DAL.Interfaces;
using DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Person Get(int id)
        {
            return db.People.Find(id);
        }

        public void Create(Person person)
        {
            db.People.Add(person);
        }

        public void Update(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Person person = db.People.Find(id);
            if (person != null)
                db.People.Remove(person);
        }
    }
}
