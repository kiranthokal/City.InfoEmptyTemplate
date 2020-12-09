using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City.InfoEmptyTemplate.Controllers
{
    [ApiController]   
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>
            {
                new {id = 1, Name = "Pune"},
                new {id = 2, Name = "Mumbai"},
                new {id = 3, Name = "Nagpur"},
                new {id = 4, Name = "Mumbai1"},
                new {id = 5, Name = "Nagpur1"}
            });
        }

        [HttpGet("api/cities/id")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(new { id = 1, Name = "Pune" });
        }
    }
}
