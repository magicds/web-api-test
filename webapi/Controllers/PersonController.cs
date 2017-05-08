using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Models;

namespace webapi.Controllers
{
    public class PersonController : ApiController
    {
        Person[] persons = new Person[] {
            new Person { Id=1,Name="zs1"},
            new Person { Id=2,Name="zs2"},
            new Person { Id=3,Name="zs3"},
            new Person { Id=4,Name="zs4"},
            new Person { Id=5,Name="zs5"}
        };

        // GET api/<controller>
        public IEnumerable<Person> GetAllPerson()
        {
            //return new string[] { "value1", "value2" };
            return persons;
        }

        public IHttpActionResult GetPerson(int id)
        {
            var person = persons.FirstOrDefault((p) => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        
    }
}