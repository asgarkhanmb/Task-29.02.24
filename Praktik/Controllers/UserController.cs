using Praktik.Helpers.Constants;
using Praktik.Models;
using Praktik.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void GetAll()
        {
           var users=_userService.GetAll();

            foreach(var user in users)
            {
                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);
            }
        }
        public void GetById()
        {
            Console.WriteLine("Enter user id");
            UserId: string strId=Console.ReadLine();

            int id;

            bool isCorrectId=int.TryParse(strId, out id);

            if (isCorrectId)
            {
                var user = _userService.GetById(_userService.GetAll(), 20);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                    return;
                }

                string result = $"{user.fullName} - {user.age} - {user.email}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;
            }



           
        }
   
    }
}
