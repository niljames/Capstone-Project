using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone_API.Controllers
{

    [EnableCors()]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApplicationDBContext user = new ApplicationDBContext();
        // GET: api/<EmployeesController>
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<User> Get()
        {
            return user.User.ToList();
        }
        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        [Route("api/[controller]/{id}")]
        public User Get(int id)
        {
            return user.User.SingleOrDefault(x => x.UserId == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [Route("api/[controller]/addUser")]
        public void Post([FromBody] User value)
        {
            user.User.Add(value);
            user.SaveChanges();
        }

        // PUT api/<EmployeesController>/5
        //[HttpPut("{id}")]

        [HttpPut]
        [Route("api/[controller]/updateUser")]
        public void Put([FromBody] User value)
        {
            user.User.Update(value);
            user.SaveChanges();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        [Route("api/[controller]/deleteUser/{id}")]
        public void Delete(int id)
        {
            var users = user.User.Find(id);

            user.User.Remove(users);
            user.SaveChanges();
        }
    }
}
