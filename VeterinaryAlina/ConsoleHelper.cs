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
        public static AnimalType PrintAnimalType()
        {
            Console.WriteLine("[1] Home cat");
            Console.WriteLine("[2] Home dog");
            Console.WriteLine("[3] Home fish");
            Console.WriteLine("[4] Home hamster");
            Console.WriteLine("[5] Home parrot");
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
                    Console.WriteLine("[1] Balinese");
                    Console.WriteLine("[2] Bengal");
                    Console.WriteLine("[3] Birman");
                    Console.WriteLine("[4] Bombay");
                    Console.WriteLine("[5] Burmese");
                    Console.WriteLine("[6] Chartreux");
                    Console.WriteLine("[7] Cymric");
                    Console.WriteLine("[8] Himalayan");
                    Console.WriteLine("[9] Javanese");
                    Console.WriteLine("[10] MaineCoon");
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
                    Console.WriteLine("[1] Affenpinscher");
                    Console.WriteLine("[2] Akita");
                    Console.WriteLine("[3] Basenji");
                    Console.WriteLine("[4] Beagl");
                    Console.WriteLine("[5] Bloodhound");
                    Console.WriteLine("[6] Dalmatian");
                    Console.WriteLine("[7] Greyhound");
                    Console.WriteLine("[8] Harrier");
                    Console.WriteLine("[9] Keeshond");
                    Console.WriteLine("[10] Kuvasz");
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
                    Console.WriteLine("[1] Angelfish");
                    Console.WriteLine("[2] Barb");
                    Console.WriteLine("[3] Betta");
                    Console.WriteLine("[4] Catfish");
                    Console.WriteLine("[5] Cichlid");
                    Console.WriteLine("[6] Cory");
                    Console.WriteLine("[7] Danio");
                    Console.WriteLine("[8] Discus");
                    Console.WriteLine("[9] Firemouth");
                    Console.WriteLine("[10] Goldfish");
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
                    Console.WriteLine("[1] Syrian");
                    Console.WriteLine("[2] Roborovski");
                    Console.WriteLine("[3] Chinese");
                    Console.WriteLine("[4] WinterWhite");
                    Console.WriteLine("[5] Campbell");
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
                    Console.WriteLine("[1] Cockatiel");
                    Console.WriteLine("[2] Lovebird");
                    Console.WriteLine("[3] Parrotle");
                    Console.WriteLine("[4] Caique");
                    Console.WriteLine("[5] Poicephalus");
                    Console.WriteLine("[6] Amazon");
                    Console.WriteLine("[7] Eclectus");
                    Console.WriteLine("[8] Macaw");
                    Console.WriteLine("[9] Cockatoos");
                    Console.WriteLine("[10] Lorie");
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
