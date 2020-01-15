using CallAWebApi.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CallAWebApi.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET api/people
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return new Person[]
            {
                new Person { Id = 1, Name = "Duncan" },
                new Person { Id = 2, Name = "Ruth" }
            };
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return new Person { Id = id, Name = $"Person{id}" };
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            return person;
        }

        [HttpPut]
        public ActionResult<Person> Put(Person person)
        {
            return person;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}