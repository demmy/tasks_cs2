using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class ConsoleHelper
    {
        public static Dictionary<string, string> menuItems = new Dictionary<string, string>() {
        {"H", "About company"},
        {"R", "Put new animal in clinic"},
        {"L", "Show list of animals"},
        {"D", "Discharge animal"},
        {"M", "Medical inspection of animal"},
        {"Q", "Quit"}
        };
        public static Dictionary<string, string> anymalType = new Dictionary<string, string>{
        {"C", "Cat"},
        {"D", "Dog"},
        {"F", "Fish"},
        {"H", "Hamster"},
        {"P", "Parrot"},
        };
        public static Dictionary<string, string> anymalHealth = new Dictionary<string, string>{
        {"1", "Animal is healsy"},
        {"2", "Animal is sick"}
        };
        public static Dictionary<string, string> anymalVaccinations = new Dictionary<string, string>{
        {"1", "Animal is vaccinated"},
        {"2", "Animal doesn't vaccinated"}
        };
        public static Dictionary<string, string> anymalAlergic = new Dictionary<string, string>{
        {"1", "Animal has alergic to medication"},
        {"2", "Animal doesn't have alergic to medication"}
        };
        public static Dictionary<string, string> anymalGender = new Dictionary<string, string>{
        {"1", "Male"},
        {"2", "Female"}
        };
        public static int GetInt(string message, int minValue, int maxValue)
        {
            int result = int.MinValue;
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out result) || result < minValue || result > maxValue);
            return result;
        }
        public static string GetString(string message)
        {
            string result;
            do
            {
                Console.WriteLine(message);
                result = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(result));
            return result;
        }
        public static void PrintMyMenu(Dictionary<string, string> item)
        {
            Console.Clear();
            for (int i = 0; i < item.Count; i++)
			{
                Console.WriteLine("[{0}] - {1}", item.ElementAt(i).Key, item.ElementAt(i).Value);
			}
        }
        public static string GetMenuItem(Dictionary<string, string> items)
        {
            bool isReal = false;
            string item = null;
            do
            {
                string input = (GetString("Please, select the menu item. Enter the relevant letter or number")).ToUpper();
                for (int index = 0; index < items.Count; index++)
                {
                    if (input == items.ElementAt(index).Key)
                    {
                        item = items.ElementAt(index).Value;
                        isReal = true;
                    }
                }
            } while (!isReal);
            return item;
        }
        public static string PrintAnimalBrids(string type)
        {
            var list = HomeAnimal.animalBrids[type];
            Dictionary<string, string> bridsWrapper = new Dictionary<string, string>();
            for (int i = 1; i <= list.Count; i++)
            {
                bridsWrapper.Add(i.ToString(), list[i - 1]);
            }
            PrintMyMenu(bridsWrapper);
            return GetMenuItem(bridsWrapper);
        }
        public static string GetNameForCreateAnimal()
        {
            Console.WriteLine("Please, enter name of the animal");
            string name = Console.ReadLine();
            return name;
        }
        public static DateTime GetBirthYearForCreateAnimal()
        {
            Console.WriteLine("Please, enter birth date of animal");
            int year = GetInt("inputYear ", 1980, 2015);
            int month = GetInt("inputMonth ", 1, 12);
            int date = GetInt("inputDate ", 1, 31);
            return new DateTime(year, month, date);
        }
        public static bool GetIsHealsyForCreateAnimal()
        {
            PrintMyMenu(anymalHealth);
            bool isHealthy = false;
            string health = GetMenuItem(anymalHealth);
            if (health == "Animal is healsy")
            {
                isHealthy = true;
            }
            return isHealthy;
        }
        public static bool GetIsVaccinatedForCreateAnimal()
        {
            PrintMyMenu(anymalVaccinations);
            bool isVaccinated = false;
            string vaccinations = GetMenuItem(anymalVaccinations);
            if (vaccinations == "Animal is vaccinated")
            {
                isVaccinated = true;
            }
            return isVaccinated;
        }
        public static bool GetIsAlergicToMedicationForCreateAnimal()
        {
            PrintMyMenu(anymalAlergic);
            bool isAlergic = false;
            string alergic = GetMenuItem(anymalVaccinations);
            if (alergic == "Animal has alergic to medication")
            {
                isAlergic = true;
            }
            return isAlergic;
        }
        public static string GetgenderOfAnimalForCreateAnimal()
        {
            PrintMyMenu(anymalGender);
            return GetMenuItem(anymalGender);
        }
        public static string GetDisease()
        {
            Console.WriteLine("Please, input information about disease of the animal");
            return Console.ReadLine();
        }
    }
}
