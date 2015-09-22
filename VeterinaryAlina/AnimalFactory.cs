using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{

    static class AnimalFactory
    {
        public static HomeAnimal CreateAnimal(string type, string name, DateTime birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, string animalBrid, string disease)
        {
            HomeAnimal newAnimal;
            switch (type)
            {
                case "Cat":
                    newAnimal = new HomeCat(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                    break;
                case "Dog":
                    newAnimal = new HomeDog(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                    break;
                case "Fish":
                    newAnimal = new HomeFish(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                    break;
                case "Hamster":
                    newAnimal = new HomeHamster(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                    break;
                case "Parrot":
                    newAnimal = new HomeParrot(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                    break;
                default:
                    throw new Exception("This type of animals doesn't contain in the database of the clinic");
            }
            return newAnimal;
        }
    }
}
