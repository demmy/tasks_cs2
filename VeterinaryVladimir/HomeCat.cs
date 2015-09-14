using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeCat : HomeAnimal
    {
        private void RunAfter(HomeHamster hamster)
        {
           throw new NotImplementedException();
        }

        private HomeCat Legs(int legs=4)
        {
            throw new NotImplementedException();
        }
        
        public HomeCat(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }
    
    }
}
