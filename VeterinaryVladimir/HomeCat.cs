using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeCat : HomeAnimal
    {
        //private string nameAnimal;
        //private int yearBirthDay;

        private void RunAfter(HomeHamster hamster)
        {
           throw new NotImplementedException();
        }

         
        public HomeCat(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }

        public override bool ExaminationReaction()
        {
            return false;
        }

    }
}
