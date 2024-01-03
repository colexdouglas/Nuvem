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

        public PharmacyController(PharmacyDBContext pharmacyDBContext)
        {
            _pharmacyDBContext = pharmacyDBContext;
        }

        [HttpGet]
        public IEnumerable<Pharmacy> Get()
        {
            return _pharmacyDBContext.Pharmacys;
        }

        [HttpPut("{id}")]
        public string Put(int id,[FromBody] Pharmacy value)
        {
            var pharmacy = _pharmacyDBContext.Pharmacys.FirstOrDefault(s => s.PharmacyId == id);
            
            if (pharmacy != null)
            {
                try 
                {
                    value.UpdatedDate = DateTime.Now;
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
