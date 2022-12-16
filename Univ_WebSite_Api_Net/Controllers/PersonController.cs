using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Univ_WebSite_Api_Net.Service;

namespace Univ_WebSite_Api_Net.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        //public List<Person> Get2()
        //{
        //    List<Person> personList = new List<Person>();

        //    PersonService personService = new PersonService();

            

        //    personList =  new List<Person> { 
        //        new Person() { PersonID=1,Name="n1",Family="f1", BirthDate=DateTime.Now,Picture="aa",Sex=false } ,

        //        new Person() { PersonID=1,Name="n2",Family="f2", BirthDate=DateTime.Now,Picture="aa2",Sex=false } ,

        //    };


        //    return personList;
        //}

        public List<Person> Get()
        {
            List<Person> personList = new List<Person>();

            PersonService personService = new PersonService();
            personList = personService.SelectAll();


            return personList;
        }

        public Person GetByID(int personID)
        {
            Person person = new Person();// { PersonID = 1, Name = "n1", Family = "f1", BirthDate = DateTime.Now, Picture = "aa", Sex = false };

            PersonService personService = new PersonService();
            person = personService.SelectByID(personID);

            return person;
        }

        // POST: api/Person
        public int Post(Person person)
        {
            PersonService personService = new PersonService();
           return  personService.Insert(person);

        }

        public int Put(Person person)
        {
            PersonService personService = new PersonService();
            return personService.Update(person);
        }

    }
}
