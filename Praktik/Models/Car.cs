using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik.Models
{
    internal class Car
    {
        public string name;
        public int speed;
        private string color="Red";
        public string Color
        {

            get
            {
                if (speed > 400)
                {
                    return color;
                }

                return null;
            }
            set
            {
                color = value;
            }


        }
    }

}
