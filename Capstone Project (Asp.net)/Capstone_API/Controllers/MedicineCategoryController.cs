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
    public class MedicineCategoryController : ControllerBase
    {
        ApplicationDBContext medC = new ApplicationDBContext();
        // GET: api/<EmployeesController>
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<MedicineCategory> Get()
        {
            return medC.MedicineCategory.ToList();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        [Route("api/[controller]/{id}")]
        public MedicineCategory Get(int id)
        {
            return medC.MedicineCategory.SingleOrDefault(x => x.MedicineCategoryId == id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [Route("api/[controller]/addCategory")]
        public void Post([FromBody] MedicineCategory value)
        {
            medC.MedicineCategory.Add(value);
            medC.SaveChanges();
        }

        // PUT api/<EmployeesController>/5
        //[HttpPut("{id}")]
        [HttpPut]
        [Route("api/[controller]/updateCategory")]
        public void Put([FromBody] MedicineCategory value)
        {
            
            medC.MedicineCategory.Update(value);
            medC.SaveChanges();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        [Route("api/[controller]/deleteCategory/{id}")]
        public void Delete(int id)
        {
            var meds = medC.MedicineCategory.Find(id);

            medC.MedicineCategory.Remove(meds);
            medC.SaveChanges();
        }
    }
}
