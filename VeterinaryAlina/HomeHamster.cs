using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeHamster : HomeAnimal
    {
        string disease;
        public HomeHamster(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, HamsterBrids brid, string disease)
            : base(name, birthYear, genderOfAnimal, isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate)
        {
            this.disease = disease;
        }
        public enum HamsterBrids
        {
            Syrian,
            Roborovski,
            Chinese,
            WinterWhite,
            Campbell,
        }
    }
}
