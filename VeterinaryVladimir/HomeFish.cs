using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeFish : HomeAnimal
    {
        public HomeFish Legs(int legs = 0)
        {
            throw new NotImplementedException();
        }

        public HomeFish(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }

    }
}
