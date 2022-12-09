using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private MySQLDBContext _dbContext;

        public OwnerController(MySQLDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IList<Owner> GetOwners()
        {
            return (this._dbContext.Owner.ToList());
        }

        [HttpPost]
        public void PostOwnerToDB(int owner_id, string firstname, string lastname, string driverlicense)
        {
            //validate and write to database
            Owner owner = new Owner(owner_id, firstname, lastname, driverlicense);
            _dbContext.Add(owner);
            _dbContext.SaveChanges();
        }

        [HttpPut]
        public void PutOwnerToDB(Owner owner)
        {
            //validate and write to database
            _dbContext.Update(owner);
            _dbContext.SaveChanges();
        }
    }
}