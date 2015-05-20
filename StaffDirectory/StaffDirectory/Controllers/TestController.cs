using StaffDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StaffDirectory.DataAccess;
using System.Data.Entity;

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

        public HttpResponseMessage Delete(int id)
        {
            PersonContext db = new PersonContext();
            Person person = db.People.Find(id);

            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.People.Remove(person);

            db.SaveChanges();
            
            return Request.CreateResponse(HttpStatusCode.OK, person);


        }

        public HttpResponseMessage Put(int id, Person person)
        {
            PersonContext db = new PersonContext();

            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != person.ID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage Post(Person person)
        {
            PersonContext db = new PersonContext();

            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, person);

                return response;
            }
                
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

            }

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
