using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Web;
using System.Net.Http;


namespace Webdemo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class WeatherForecastController : ControllerBase
    {
     static List<string> names = new List<string>()
         {
            "harshit","naina","isha"
         };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return names;
        }
        [HttpGet]
        public string Get (int id) {
            return names[id];
        }
        [HttpPost]
        public void Post([FromBody]string value)
        {
            names.Add(value);
        }
        [HttpPut]
        public void Put(int id,[FromBody]string value)
        {
            names[id] = value;
        }
       [HttpDelete]
        public void Delete(int id) 
        {
            names.RemoveAt(id);
        }
        
    }
}
