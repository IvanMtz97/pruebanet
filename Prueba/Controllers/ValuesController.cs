using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route("getAll")]
        public IActionResult Get()
        {
            var Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            UserService us = new UserService();
            List<User> Users = us.SeedList();

            Debug.WriteLine(HttpContext.Session.GetString("Email"));

            return Ok(Users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("postUser")]
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            var Session = HttpContext.Session.GetString("email");
            return Ok(user);
        }
        
        [Route("postRandom")]
        [HttpPost]
        public dynamic PostRandom([FromBody] dynamic data)
        {
            return data;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
