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
        public HomeCat(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, CatBrids brid, string disease)
            : base(name, birthYear, genderOfAnimal, isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate)
        {
            this.disease = disease;
        }
        public enum CatBrids
        {
            Balinese,
            Bengal,
            Birman,
            Bombay,
            Burmese,
            Chartreux,
            Cymric,
            Himalayan,
            Javanese,
            MaineCoon
        }
    }
}
