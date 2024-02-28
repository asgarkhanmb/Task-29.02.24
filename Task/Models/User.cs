

using System.Dynamic;

namespace task.Models
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        private string password;

        public User()
        {
          
        }
        public User(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public string Get()
        {
            return password; 
            
        }
        public void Set(string password)
        {
           this.password = password;
        }

    }
}
