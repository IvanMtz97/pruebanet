using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba.lib;
using Prueba.Models;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [EnableCors]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public object login([FromBody] UserCredentials credentials)
        {
            if((credentials.Email.Equals("ivan@x8bit.com") && credentials.Password.Equals("asdqwe123")) || (credentials.Email.Equals("jose@x8bit.com") && credentials.Password.Equals("asdqwe123")))
            {
                HttpContext.Session.SetString("email", credentials.Email);
                return new Response(true, new { }, "LOGGED IN");
            }
            else
            {
                return new Response(false, new { }, "Credenciales incorrectas");
            }
        }
    }
}