using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeParrot : HomeAnimal
    {
        string disease;
        public HomeParrot(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, ParrotBrids brid, string disease)
            : base(name, birthYear, genderOfAnimal, isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate)
        {
            this.disease = disease;
        }
        public enum ParrotBrids
        {
            Cockatiel,
            Lovebird,
            Parrotlet,
            Caique,
            Poicephalus,
            Amazon,
            Eclectus,
            Macaw,
            Cockatoos,
            Lorie,
            Parakeet
        }
    }
}
