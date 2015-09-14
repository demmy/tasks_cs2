using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeHamster : HomeAnimal
    {
        public HomeHamster RunInCircke {get; set;}
        
        public HomeHamster(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }

    }
}
