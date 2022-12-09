using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private MySQLDBContext _dbContext;  
  
        public VehicleController(MySQLDBContext context)  
        {  
            _dbContext = context;  
        }

        [HttpGet]  
        public IList<Vehicle> GetVehicles()
        {  
            return (this._dbContext.Vehicle.Include(x => x.Owner).ToList());  
        }

        [HttpPost]
        public void PostVehicleToDB(int vehicle_id, string brand, string vin, string color, int year, Owner owner)
        {
            //validate and write to database
            Vehicle vehicle = new Vehicle(vehicle_id, brand, vin, color, year, owner);
            _dbContext.Add(vehicle);
            _dbContext.SaveChanges();
        }

        [HttpPut]
        public void PutVehicleToDB(Vehicle vehicle)
        {
            //validate and write to database
            _dbContext.Update(vehicle);
            _dbContext.SaveChanges();
        }
    }
} 