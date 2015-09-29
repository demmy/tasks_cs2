using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public abstract class HomeAnimal
    {
            private string nameAnimal;
            private int yearBirthDay;

            public HomeAnimal()
                : this("", 1900)
            {
            }

            public HomeAnimal(string nameAnimal, int yearBirthDay)
            {
                this.nameAnimal = nameAnimal;
                this.yearBirthDay = yearBirthDay;   
            }

           
            public abstract bool ExaminationReaction();
            
    }
}
