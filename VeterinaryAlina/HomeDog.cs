using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeDog : HomeAnimal
    {
        string disease;
        public HomeDog(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, DogBrids brid, string disease)
            : base(name, birthYear, genderOfAnimal, isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate)
        {
            this.disease = disease;
        }
        public enum DogBrids
        {
            Affenpinscher,
            Akita,
            Basenji,
            Beagl,
            Bloodhound,
            Dalmatian,
            Greyhound,
            Harrier,
            Keeshond,
            Kuvasz
        }
    }
}
