using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class User
    {

        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Phone { get; set; }
        public int Age { get; set; }
        public Boolean Active { get; set; }
        public String Type { get; set; }

        public User(String Name, String Email, String Phone, int Age, Boolean Active, String Type)
        {
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Age = Age;
            this.Active = Active;
            this.Type = Type;
        }

    }
}
