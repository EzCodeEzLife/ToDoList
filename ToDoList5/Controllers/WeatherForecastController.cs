using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList5.Models;

namespace ToDoList5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        [HttpGet]
        public IEnumerable<Goal> Get()
        {
            using (var _context = new GoalsDBContext())
            {
                //Goal goal = new Goal();
                //goal.GoalName = "Go to shop";

                //_context.Goals.Add(goal);

                //_context.SaveChanges();

                Goal goal = _context.Goals.FirstOrDefault();
                //goal.GoalName = "Go to Shops";

                _context.Goals.Remove(goal);

                _context.SaveChanges();

                return _context.Goals.ToList();
            }
                
        }
    }
}
