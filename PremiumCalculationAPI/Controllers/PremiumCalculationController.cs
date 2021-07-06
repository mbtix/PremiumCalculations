using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApplication.Model;
using CoreWebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumCalculationController : ControllerBase
    {
        readonly IPremiumBAL _premiumBAL;
        public PremiumCalculationController(IPremiumBAL premiumBAL)
        {
            _premiumBAL = premiumBAL;
        }

        // GET: api/Premium
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // POST: api/Premium

        [HttpPost]
        public double Post([FromBody] PremiumVM premium)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return 0;
                }
                double calcuatedValue = _premiumBAL.CalculatePremium(premium);
                return calcuatedValue;
            }
            catch(Exception ex)
            {
                return 0;
            }
            
        }

        // PUT: api/Premium/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Premium/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
