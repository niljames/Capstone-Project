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
    public class MedicineController : ControllerBase
    {
        ApplicationDBContext med = new ApplicationDBContext();
        // GET: api/<EmployeesController>
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<Medicine> Get()
        {
            return med.Medicine.ToList();
        }

        [HttpGet("{id}")]
        [Route("api/[controller]/{id}")]
        public Medicine GetIndMed(string id)
        {
            return med.Medicine.SingleOrDefault(x => x.Name == id);
        }
      

        // POST api/<EmployeesController>
        [HttpPost]
        [Route("api/[controller]/addMedicine")]
        public void Post([FromBody] Medicine value)
        {
            med.Medicine.Add(value);
            med.SaveChanges();
        }

        // PUT api/<EmployeesController>/5
        //[HttpPut("{id}")]
        [HttpPut]
        [Route("api/[controller]/updateMedicine")]
        public void Put([FromBody] Medicine value)
        {
            med.Medicine.Update(value);
            med.SaveChanges();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        [Route("api/[controller]/deleteMedicine/{id}")]
        public void Delete(int id)
        {
            var meds = med.Medicine.Find(id);

            med.Medicine.Remove(meds);
            med.SaveChanges();
        }
    }
}
