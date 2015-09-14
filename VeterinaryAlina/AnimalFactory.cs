using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public enum AnimalType 
    {
        Cat, Dog, Fish, Hamster, Parrot
    }
    static class AnimalFactory
    {
        public static HomeAnimal CreateAnimal(AnimalType type, string name, DateTime birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, string animalBrid, string disease)
        {
            switch (type)
            {
                case AnimalType.Cat: return new HomeCat(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                case AnimalType.Dog: return new HomeDog(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                case AnimalType.Fish: return new HomeFish(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                case AnimalType.Hamster: return new HomeHamster(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                case AnimalType.Parrot: return new HomeParrot(name, birthYear, genderOfAnimal, isHealthy, isVaccinated,
                    isAlergicToMedication, registrationDate, animalBrid, disease);
                default:
                    throw new Exception("This type of animals doesn't contain in the database of the clinic");
            }
        }
    }
}
