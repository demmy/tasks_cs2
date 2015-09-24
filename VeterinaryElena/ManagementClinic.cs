﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
   public class ManagementClinic
    {
        public void DischargeAnimal(int identificator)
        {
            foreach (HomeAnimal a in Program.animals)
            {
                if (a.ID == identificator)
                { a.IsHealthy = true; }
            }

        }

        public void Readmission(int identificator)
        {
            foreach (HomeAnimal a in Program.animals)
            {
                if (a.ID == identificator)
                { a.IsHealthy = false; }
            }
        }

        protected HomeAnimal ReturnPets(int identificator)
        {
            foreach (HomeAnimal ha in Program.animals)
            {
                if (ha.ID == identificator)
                { return ha; }
            }

            throw new InvalidOperationException();
        }

        public int isConteins(string nameA, string ownerA, string kindA)
        
        {
            int number = 0;
            foreach (HomeAnimal ha in Program.animals)
            {
                if (ha.Name == nameA && ha.Owner == ownerA && ha.KindOfAnimal == kindA)
                { number = ha.ID; }
            }

            return number;
        }
    }
}
