using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }

        public abstract void Test();

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
