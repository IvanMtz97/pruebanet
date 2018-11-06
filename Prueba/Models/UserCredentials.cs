using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class UserCredentials
    {
        public String Email { get; set; }
        public String Password { get; set; }

        public UserCredentials(String Email, String Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}
