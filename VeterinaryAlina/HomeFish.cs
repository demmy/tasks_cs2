using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class HomeFish : HomeAnimal
    {
        string disease;
        public HomeFish(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, FishBrids brid, string disease)
            :base(name, birthYear, genderOfAnimal, isHealthy, 
            isVaccinated, isAlergicToMedication, registrationDate)
        {
            this.disease = disease;
        }
        //животное может быть принесено не для лечения, а для каких-либо других процедур - поле "болезнь" будет пустым
        public HomeFish(string name, int birthYear, string genderOfAnimal, bool isHealthy,
            bool isVaccinated, bool isAlergicToMedication, DateTime registrationDate, FishBrids brid)
            :this(name, birthYear, genderOfAnimal,  isHealthy,
            isVaccinated, isAlergicToMedication, registrationDate, brid, null)
        {

        }
        public enum FishBrids 
        {
            Angelfish,
            Barb,
            Betta,
            Catfish,
            Cichlid,
            Cory,
            Danio,
            Discus,
            Firemouth,
            Goldfish
        }
    }
}
