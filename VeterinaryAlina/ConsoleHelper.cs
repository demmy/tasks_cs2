using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public enum MainMenu
    {
        AboutClinic, PutToClinic, AnimalList, DischargeAnimal, MedicalInspection,  QuitProgram
    }

    public class ConsoleHelper
    {
        static List<string> animalType = new List<string>() { "Home cat", "Home dog", "Home fish",
            "Home hamster", "Home parrot" };
        static List<string> catBrids = new List<string>() { "Balinese", "Bengal", "Birman",
            "Bombay", "Burmese", "Chartreux", "Cymric", "Himalayan", "Javanese", "MaineCoon"};
        static List<string> dogBrids = new List<string>() { "Affenpinscher", "Akita", "Basenji",
            "Beagl", "Bloodhound", "Dalmatian", "Greyhound", "Harrier", "Keeshond", "Kuvasz"};
        static List<string> fishBrids = new List<string>() { "Angelfish", "Barb", "Betta",
            "Catfish", "Cichlid", "Cory", "Danio", "Discus", "Firemouth", "Goldfish"};
        static List<string> hamsterBrids = new List<string>() { "Syrian", "Roborovski", "Chinese",
            "WinterWhite", "Campbell"};
        static List<string> parrotBrids = new List<string>() { "[1] Cockatiel", "[2] Lovebird", "[3] Parrotle",
            "[4] Caique", "[5] Poicephalus", "[6] Amazon", "[7] Eclectus", "[8] Macaw", "[9] Cockatoos", "[10] Lorie"};
        public static int GetInt(string message, int minValue, int maxValue)
        {
            int result = int.MinValue;
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out result) || result < minValue || result > maxValue);
            return result;
        }
        public static MainMenu PrintMenu()
        {
            Console.WriteLine("[H] About company");
            Console.WriteLine("[R] Put new animal in clinic");
            Console.WriteLine("[L] Show list of animals");
            Console.WriteLine("[D] Discharge animal");
            Console.WriteLine("[M] Medical inspection of animal");
            Console.WriteLine("[Q] Quit");
            do
            {
                Console.WriteLine("Please, select the menu item. Enter the relevant letter");
                string input = Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "H": return MainMenu.AboutClinic;
                    case "R": return MainMenu.PutToClinic;
                    case "L": return MainMenu.AnimalList;
                    case "D": return MainMenu.DischargeAnimal;
                    case "M": return MainMenu.MedicalInspection;
                    case "Q": return MainMenu.QuitProgram;
                    default:
                        break;
                }
            } while (true);
        }
        public static void PrintList(List<string> list)
        {
            int count = 1;
            Console.Clear();
            foreach (string element in list)
            {
                Console.WriteLine("[{0}] - {1}", count, element);
                count++;
            }
        }
        public static AnimalType PrintAnimalType()
        {
            PrintList(animalType);
            do
            {
                Console.WriteLine("Please, select type of animal. Enter the relevant number");
                string inputAnimal = Console.ReadLine();
                switch (inputAnimal)
                {
                    case "1": return AnimalType.Cat;
                    case "2": return AnimalType.Dog;
                    case "3": return AnimalType.Fish;
                    case "4": return AnimalType.Hamster;
                    case "5": return AnimalType.Parrot;
                    default:
                        break;
                }

            } while (true);
        }

        public static string PrintAnimalBrids(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat:
                    PrintList(catBrids);
                    do
                    {
                        Console.WriteLine("Please, select brid of cat. Enter the relevant number");
                        string inputBridOfCat = Console.ReadLine();
                        switch (inputBridOfCat)
                        {
                            case "1": return HomeAnimal.animalBrids[AnimalType.Cat][1];
                            case "2": return HomeAnimal.animalBrids[AnimalType.Cat][2];
                            case "3": return HomeAnimal.animalBrids[AnimalType.Cat][3];
                            case "4": return HomeAnimal.animalBrids[AnimalType.Cat][4];
                            case "5": return HomeAnimal.animalBrids[AnimalType.Cat][5];
                            case "6": return HomeAnimal.animalBrids[AnimalType.Cat][6];
                            case "7": return HomeAnimal.animalBrids[AnimalType.Cat][7];
                            case "8": return HomeAnimal.animalBrids[AnimalType.Cat][8];
                            case "9": return HomeAnimal.animalBrids[AnimalType.Cat][9];
                            case "10": return HomeAnimal.animalBrids[AnimalType.Cat][10];
                            default: Console.WriteLine("This brid of cats doesn't contain in the database of the clinic");
                                throw new Exception("This brid of cats doesn't contain in the database of the clinic");
                        }
                    } while (true);
                case AnimalType.Dog:
                    PrintList(dogBrids);
                    do
                    {
                        Console.WriteLine("Please, select brid of dog. Enter the relevant number");
                        string inputBridOfDog = Console.ReadLine();
                        switch (inputBridOfDog)
                        {
                            case "1": return HomeAnimal.animalBrids[AnimalType.Dog][1];
                            case "2": return HomeAnimal.animalBrids[AnimalType.Dog][2];
                            case "3": return HomeAnimal.animalBrids[AnimalType.Dog][3];
                            case "4": return HomeAnimal.animalBrids[AnimalType.Dog][4];
                            case "5": return HomeAnimal.animalBrids[AnimalType.Dog][5];
                            case "6": return HomeAnimal.animalBrids[AnimalType.Dog][6];
                            case "7": return HomeAnimal.animalBrids[AnimalType.Dog][7];
                            case "8": return HomeAnimal.animalBrids[AnimalType.Dog][8];
                            case "9": return HomeAnimal.animalBrids[AnimalType.Dog][9];
                            case "10": return HomeAnimal.animalBrids[AnimalType.Dog][10];
                            default: Console.WriteLine("This brid of dogs doesn't contain in the database of the clinic");
                                throw new Exception("This brid of dogs doesn't contain in the database of the clinic");
                        }
                    } while (true);
                case AnimalType.Fish:
                    PrintList(fishBrids);
                    do
                    {
                        Console.WriteLine("Please, select brid of fisf. Enter the relevant number");
                        string inputBridOfFish = Console.ReadLine();
                        switch (inputBridOfFish)
                        {
                            case "1": return HomeAnimal.animalBrids[AnimalType.Fish][1];
                            case "2": return HomeAnimal.animalBrids[AnimalType.Fish][2];
                            case "3": return HomeAnimal.animalBrids[AnimalType.Fish][3];
                            case "4": return HomeAnimal.animalBrids[AnimalType.Fish][4];
                            case "5": return HomeAnimal.animalBrids[AnimalType.Fish][5];
                            case "6": return HomeAnimal.animalBrids[AnimalType.Fish][6];
                            case "7": return HomeAnimal.animalBrids[AnimalType.Fish][7];
                            case "8": return HomeAnimal.animalBrids[AnimalType.Fish][8];
                            case "9": return HomeAnimal.animalBrids[AnimalType.Fish][9];
                            case "10": return HomeAnimal.animalBrids[AnimalType.Fish][10];
                            default: Console.WriteLine("This brid of fishes doesn't contain in the database of the clinic");
                                throw new Exception("This brid of fishes doesn't contain in the database of the clinic");
                        }
                    } while (true);
                case AnimalType.Hamster:
                    PrintList(hamsterBrids);
                    do
                    {
                        Console.WriteLine("Please, select brid of fisf. Enter the relevant number");
                        string inputBridOfFish = Console.ReadLine();
                        switch (inputBridOfFish)
                        {
                            case "1": return HomeAnimal.animalBrids[AnimalType.Hamster][1];
                            case "2": return HomeAnimal.animalBrids[AnimalType.Hamster][2];
                            case "3": return HomeAnimal.animalBrids[AnimalType.Hamster][3];
                            case "4": return HomeAnimal.animalBrids[AnimalType.Hamster][4];
                            case "5": return HomeAnimal.animalBrids[AnimalType.Hamster][5];
                            default: Console.WriteLine("This brid of hamsters doesn't contain in the database of the clinic");
                                throw new Exception("This brid of hamsters doesn't contain in the database of the clinic");
                        }
                    } while (true);
                case AnimalType.Parrot:
                    PrintList(parrotBrids);
                    do
                    {
                        Console.WriteLine("Please, select brid of fisf. Enter the relevant number");
                        string inputBridOfParrot = Console.ReadLine();
                        switch (inputBridOfParrot)
                        {
                            case "1": return HomeAnimal.animalBrids[AnimalType.Parrot][1];
                            case "2": return HomeAnimal.animalBrids[AnimalType.Parrot][2];
                            case "3": return HomeAnimal.animalBrids[AnimalType.Parrot][3];
                            case "4": return HomeAnimal.animalBrids[AnimalType.Parrot][4];
                            case "5": return HomeAnimal.animalBrids[AnimalType.Parrot][5];
                            case "6": return HomeAnimal.animalBrids[AnimalType.Parrot][6];
                            case "7": return HomeAnimal.animalBrids[AnimalType.Parrot][7];
                            case "8": return HomeAnimal.animalBrids[AnimalType.Parrot][8];
                            case "9": return HomeAnimal.animalBrids[AnimalType.Parrot][9];
                            case "10": return HomeAnimal.animalBrids[AnimalType.Parrot][10];
                            default: Console.WriteLine("This brid of parrots doesn't contain in the database of the clinic");
                                throw new Exception("This brid of parrots doesn't contain in the database of the clinic");
                        }
                    } while (true);
                default: return null;
            }
        }
        public static string GetNameForCreateAnimal()
        {
            Console.WriteLine("Please, enter name of the animal");
            string name = Console.ReadLine();
            return name;
        }
        public static DateTime GetBirthYearForCreateAnimal()
        {
            int year = GetInt("inputYear ", 1980, 2015);
            int month = GetInt("inputMonth ", 1, 12);
            int date = GetInt("inputDate ", 1, 31);
            return new DateTime(year, month, date);
        }
        public static bool GetIsHealsyForCreateAnimal()
        {
            Console.WriteLine("[1] Animal is healsy");
            Console.WriteLine("[2] Animal is sick");
            do
            {
                Console.WriteLine("Please, input information about the animal. Enter the relevant number");
                string inputIsHealsy = Console.ReadLine();
                switch (inputIsHealsy)
                {
                    case "1": return true;
                    case "2": return false;
                }
            } while (true);
        }
        public static bool GetIsVaccinatedForCreateAnimal()
        {
            Console.WriteLine("[1] Animal is vaccinated");
            Console.WriteLine("[2] Animal doesn't vaccinated");
            do
            {
                Console.WriteLine("Please, input information about the animal. Enter the relevant number");
                string inputIsHealsy = Console.ReadLine();
                switch (inputIsHealsy)
                {
                    case "1": return true;
                    case "2": return false;
                }
            } while (true);
        }
        public static bool GetIsAlergicToMedicationForCreateAnimal()
        {
            Console.WriteLine("[1] Animal has alergic to medication");
            Console.WriteLine("[2] Animal doesn't have alergic to medication");
            do
            {
                Console.WriteLine("Please, input information about the animal. Enter the relevant number");
                string inputIsHealsy = Console.ReadLine();
                switch (inputIsHealsy)
                {
                    case "1": return true;
                    case "2": return false;
                }
            } while (true);
        }
        public static string GetgenderOfAnimalForCreateAnimal()
        {
            Console.WriteLine("[1] Male");
            Console.WriteLine("[2] Female");
            do
            {
                Console.WriteLine("Please, input information about gender of the animal. Enter the relevant number");
                string inputGender = Console.ReadLine();
                switch (inputGender)
                {
                    case "1": return "male";
                    case "2": return "female";
                }
            } while (true);
        }
        public static string GetDisease()
        {
            Console.WriteLine("Please, input information about disease of the animal");
            return Console.ReadLine();
        }
    }
}
