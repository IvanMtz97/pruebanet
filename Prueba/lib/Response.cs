using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.lib
{
    public class Response
    {
        public Boolean success { get; set; }
        public dynamic payload { get; set; }
        public String message { get; set; }

        public Response(Boolean success, dynamic payload, String message = "")
        {
            this.success = success;
            this.payload = payload;
            this.message = message;
        }
    }
}
