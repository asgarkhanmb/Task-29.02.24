using Praktik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User()
                {
                    id=1,
                    fullName="Asgarkhan Bayramov",
                    age=27,
                    email="asgarkhanmb@code.edu.az",
                    password="12345"

                },
               new User()
               {
                   id= 2,
                   fullName="Aykhan Agayev",
                   age=23,
                   email="aykhan@code.edu.az",
                   password="123456"
               },
               new User()
               {
                   id= 3,
                   fullName="Bahruz Aliyev",
                   age=37,
                   email="bahruz@code.edu.az",
                   password="1234"

               },
            };
        }

        public User GetById(User[] users, int id)
        {
            return users.Where(m => m.id == id).FirstOrDefault();
        }

    }
}
