using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Services
{
    public class UserService
    {

        public List<User> SeedList()
        {

            List<User> Users = new List<User>();

            Users.Add(new User("Ivan", "ivan@gmail.com", "8126522105", 21, true, "Administrador"));
            Users.Add(new User("Juan", "Juan@gmail.com", "8120412391", 21, false, "Usuario"));
            Users.Add(new User("Jose", "Jose@gmail.com", "8124012582", 21, true, "Moderador"));
            Users.Add(new User("Pedro", "Pedro@gmail.com", "8192899175", 21, true, "Usuario"));
            Users.Add(new User("Alfonso", "Alfonso@gmail.com", "8120544090", 21, false, "Moderador"));
            Users.Add(new User("Martin", "Martin@gmail.com", "8188277395", 21, false, "Usuario"));
            Users.Add(new User("Pepe", "Pepe@gmail.com", "8192465532", 21, true, "Usuario"));

            return Users;

        }

    }
}
