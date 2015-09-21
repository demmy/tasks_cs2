using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeDog : HomeAnimal
    {
        public void RunAfter(HomeHamster hamster)
        {
            throw new NotImplementedException();
        }

        public void RunAfter(HomeCat cat)
        {
            throw new NotImplementedException();
        }

        public HomeDog(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }

        public override bool ExaminationReaction()
        {
            return false;
        }

    }
}
