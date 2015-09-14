using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public abstract class HomeAnimal
    {
        protected string name;
        protected DateTime birthYear;
        protected string genderOfAnimal;
        protected bool isHealthy;
        protected bool isVaccinated;
        protected bool isAlergicToMedication;
        static int uniqueCode=0;
        public int AnimalID { get; protected set; }
        public static Dictionary<AnimalType, List<string>> animalBrids = new Dictionary<AnimalType, List<string>>() 
        { 
            {AnimalType.Cat, new List<string>{"Balinese", "Bengal", "Birman", "Bombay",
                "Burmese","Chartreux", "Cymric", "Himalayan", "Javanese", "MaineCoon"}},
            {AnimalType.Dog, new List<string>{"Affenpinscher", "Akita", "Basenji", "Beagl",
                "Bloodhound", "Dalmatian", "Greyhound", "Harrier", "Keeshond", "Kuvasz"}},
            {AnimalType.Fish, new List<string>{"Angelfish", "Barb", "Betta", "Catfish", 
                "Cichlid", "Cory", "Danio", "Discus", "Firemouth", "Goldfish"}},
            {AnimalType.Hamster, new List<string> {"Syrian", "Roborovski", "Chinese",
                "WinterWhite", "Campbell"}},
            {AnimalType.Parrot, new List<string>{"Cockatiel", "Lovebird", "Parrotlet",
                "Caique", "Poicephalus", "Amazon", "Eclectus", "Macaw", "Cockatoos", "Lorie"}}
        };
        protected DateTime registrationDate;
        public HomeAnimal()
        {

        }
        public HomeAnimal
            (string name, DateTime birthYear, string genderOfAnimal, bool isHealthy, bool isVaccinated,
            bool isAlergicToMedication, DateTime registrationDate, string animalBris)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.genderOfAnimal = genderOfAnimal;
            this.isHealthy = isHealthy;
            this.isVaccinated = isVaccinated;
            this.isAlergicToMedication = isAlergicToMedication;
            this.registrationDate = registrationDate;
            this.AnimalID = GetFreeCode();
        }
        public static  int GetFreeCode()
        {
            return ++uniqueCode;
        }
    }
}
