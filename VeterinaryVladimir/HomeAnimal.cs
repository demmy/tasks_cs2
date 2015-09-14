using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeAnimal
    {
            public string nameAnimal;
            public int legs;
            public int yearBirthDay;

            public HomeAnimal()
                : this("", 1900)
            {
            }

            public HomeAnimal(string nameAnimal, int yearBirthDay)
            {
                this.nameAnimal = nameAnimal;
                this.yearBirthDay = yearBirthDay;   
            }

            public HomeAnimal(int legs)
            {
                this.legs = legs;
            }
        
            public HomeAnimal Eat { get; set; }

            public HomeAnimal Sleep { get; set; }





    }
}
