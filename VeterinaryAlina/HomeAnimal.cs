using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeAnimal
    {
        string name;
        int birthYear;
        string genderOfAnimal;
        protected bool isHealthy;
        protected bool isVaccinated;
        protected bool isAlergicToMedication;
        int uniqueCode;
        DateTime registrationDate;
        public HomeAnimal()
        {

        }
        public HomeAnimal
            (string name, int birthYear, string genderOfAnimal, bool isHealthy, bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.genderOfAnimal = genderOfAnimal;
            this.isHealthy = isHealthy;
            this.isVaccinated = isVaccinated;
            this.isAlergicToMedication = isAlergicToMedication;
            this.registrationDate = registrationDate;
        }
    }
}
