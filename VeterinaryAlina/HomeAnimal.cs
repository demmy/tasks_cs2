﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public abstract class HomeAnimal
    {
        public string Name { get; protected set; }
        public DateTime BirthYear { get; protected set; }
        public string GenderOfAnimal { get; protected set; }
        public bool IsHealthy { get; protected set; }
        public bool IsVaccinated { get; protected set; }
        public bool IsAlergicToMedication { get; protected set; }
        static int uniqueCode=0;
        public int AnimalID { get; protected set; }
        public static Dictionary<string, List<string>> animalBrids = new Dictionary<string, List<string>>() 
        { 
            {"Cat", new List<string>{"Balinese", "Bengal", "Birman", "Bombay",
                "Burmese","Chartreux", "Cymric", "Himalayan", "Javanese", "MaineCoon"}},
            {"Dog", new List<string>{"Affenpinscher", "Akita", "Basenji", "Beagl",
                "Bloodhound", "Dalmatian", "Greyhound", "Harrier", "Keeshond", "Kuvasz"}},
            {"Fish", new List<string>{"Angelfish", "Barb", "Betta", "Catfish", 
                "Cichlid", "Cory", "Danio", "Discus", "Firemouth", "Goldfish"}},
            {"Hamster", new List<string> {"Syrian", "Roborovski", "Chinese",
                "WinterWhite", "Campbell"}},
            {"Parrot", new List<string>{"Cockatiel", "Lovebird", "Parrotlet",
                "Caique", "Poicephalus", "Amazon", "Eclectus", "Macaw", "Cockatoos", "Lorie"}}
        };
        public DateTime RegistrationDate { get; protected set; }
        public HomeAnimal()
        {

        }
        public HomeAnimal
            (string name, DateTime birthYear, string genderOfAnimal, bool isHealthy, bool isVaccinated,
            bool isAlergicToMedication, DateTime registrationDate, string animalBris)
        {
            Name = name;
            BirthYear = birthYear;
            GenderOfAnimal = genderOfAnimal;
            IsHealthy = isHealthy;
            IsVaccinated = isVaccinated;
            IsAlergicToMedication = isAlergicToMedication;
            RegistrationDate = registrationDate;
            AnimalID = GetFreeCode();
        }
        public static  int GetFreeCode()
        {
            return ++uniqueCode;
        }
        public virtual void ShowConditionOFAnimal(int id)
        {
            Console.WriteLine("Name of this animal is: {0}", Name);
            Console.WriteLine("Gender of this animal is: {0}", GenderOfAnimal);
            Console.WriteLine(IsHealthy ? "Animal is healthy" : "Animal is sick");
        }
    }
}
