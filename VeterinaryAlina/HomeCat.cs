using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeCat:HomeAnimal
    {
        string disease;
        string animalBrid;
        public HomeCat(string name, DateTime birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, string animalBrid, string disease)
            : base(name, birthYear, genderOfAnimal, isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate, animalBrid)
        {
            this.disease = disease;
            this.animalBrid = animalBrid;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",
                this.AnimalID, this.name, this.genderOfAnimal, this.animalBrid, this.birthYear,
                this.registrationDate, this.isHealthy, this.disease, this.isVaccinated, this.isVaccinated);
        }
    }
}
