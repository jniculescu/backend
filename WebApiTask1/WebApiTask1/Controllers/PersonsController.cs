using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTask1.Models;

namespace WebApiTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllPersons()
        {
            var persons = new List<Person>
            {
                new Person("James", 55),
                new Person("Lisa", 35)
            };
            return new JsonResult(persons);
        }
    }
}