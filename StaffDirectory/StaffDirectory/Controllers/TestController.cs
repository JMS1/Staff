using StaffDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StaffDirectory.DataAccess;

namespace StaffDirectory.Controllers
{
    public class TestController : ApiController
    {
        


       

        //public HttpResponseMessage Get()
        //{
        //    var emps = db.People.AsQueryable();

        //    return Request.CreateResponse(HttpStatusCode.OK, emps);

        //}

        public IEnumerable<Person> Get()
        {
            PersonContext db = new PersonContext();
            var emps = db.People.ToList();
            return emps;
        }


        



        //private static void CreatePerson()
        //{
        //    PersonContext db = new PersonContext();

        //    var employees = new List<Person>
        //    {
        //        new Person{name="John Smith", email="JohnSmith@gmail.com", phoneNumber=08454348231 },
        //        new Person{name="Jane Smith", email="JaneSmith@gmail.com", phoneNumber=08454348232 }
        //    };

        //    employees.ForEach(s => db.People.Add(s));
        //    db.SaveChanges();

        //}

        
    }

}
