using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : Controller
    {
        private MySQLDBContext _dbContext;  
  
        public ClaimController(MySQLDBContext context)  
        {  
            _dbContext = context;  
        }

        [HttpGet]  
        public IList<Claim> GetClaims()
        {  
            return (this._dbContext.Claim.Include(x => x.Vehicle).ToList());  
        }

        [HttpPost]
        public void PostClaimToDB(int claim_id, string description, string status, DateTime date, Vehicle vehicle)
        {
            //validate and write to database
            Claim claim = new Claim(claim_id, description, status, date, vehicle);
            _dbContext.Add(claim);
            _dbContext.SaveChanges();
        }

        [HttpPut]
        public void PutClaimToDB(Claim claim)
        {
            //validate and write to database
            _dbContext.Update(claim);
            _dbContext.SaveChanges();
        }
    }
} 