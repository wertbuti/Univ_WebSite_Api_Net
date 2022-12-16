using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univ_WebSite_Api_Net.Service
{
    public class PersonService
    {
        UnivEntities _univEntities;

        public PersonService()
        {
            _univEntities = new UnivEntities();
        }
        public List<Person> SelectAll()
        {
            List<Person> personList = new List<Person>();

            personList = _univEntities.People.ToList();

            return personList;
        }

        public Person SelectByID(int personID)
        {
            Person person = new Person();

            person = _univEntities.People.Where(x => x.PersonID == personID).FirstOrDefault();

            return person;
        }

        public int Insert(Person person)
        {
            int result = 0;


            _univEntities.People.Add(person);

            result = _univEntities.SaveChanges();


            return result;
        }

        public int Update(Person person)
        {
            int result = 0;


            _univEntities.Entry(person).State = System.Data.Entity.EntityState.Modified;

           // _univEntities.People.Add(person);

            result = _univEntities.SaveChanges();


            return result;
        }
    }
}