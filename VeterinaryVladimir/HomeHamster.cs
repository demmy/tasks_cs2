﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    public class HomeHamster : HomeAnimal
    {
        
        
        public HomeHamster(string nameAnimal, int yearBirthDay) : base (nameAnimal, yearBirthDay)
        {
           
        }

        public override bool ExaminationReaction()
        {
            return true;
        }

    }
}
