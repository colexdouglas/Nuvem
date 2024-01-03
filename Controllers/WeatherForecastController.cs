using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Nuvem.Models;

namespace Nuvem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PharmacyController : ControllerBase
    {
        private PharmacyDBContext _pharmacyDBContext;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        

        public PharmacyController(PharmacyDBContext pharmacyDBContext)
        {
            _pharmacyDBContext = pharmacyDBContext;
        }

        [HttpGet]
        public IEnumerable<Pharmacy> Get()
        {
            return _pharmacyDBContext.Pharmacys;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public string Put(int id,[FromBody] Pharmacy value)
        {
            var pharmacy = _pharmacyDBContext.Pharmacys.FirstOrDefault(s => s.PharmacyId == id);
            if (pharmacy != null)
            {
                try 
                {
                    _pharmacyDBContext.Entry<Pharmacy>(pharmacy).CurrentValues.SetValues(value);
                    _pharmacyDBContext.SaveChanges();
                    return "success";
                }
                catch (Exception ex) 
                {
                    return (ex.Message);
                }
            }
            return "Please enter correct parameters";
        }
    }
}
