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
        string animalBrid;
        public HomeHamster(string name, DateTime birthYear, string genderOfAnimal, bool isHealthy,
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
                this.AnimalID, Name, GenderOfAnimal, this.animalBrid, BirthYear,
                this.RegistrationDate, IsHealthy, this.disease, IsVaccinated, IsVaccinated);
        }
        public override void ShowConditionOFAnimal(int id)
        {
            base.ShowConditionOFAnimal(id);
            Console.WriteLine("Make a loud squeak");
            Console.WriteLine("Dodge");
        }
    }
}
