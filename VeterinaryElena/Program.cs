using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    class Program
    {
       public static ManagementClinic maneger = new ManagementClinic();
       public static List<Doctor> personal = new List<Doctor>();

        private static Menu mainMenu = new Menu(
            new Menu.ItemAction[]
            {
                new Menu.ItemAction{text="Register new animal", MyAction=Register},
                new Menu.ItemAction{text="Show list of  animals", MyAction=ShowList},
                new Menu.ItemAction{text="Discharge animal", MyAction=Discharge},
                new Menu.ItemAction{text="Exsamination", MyAction=Exsamination},
                new Menu.ItemAction{text="About clinica", MyAction=Help},
                new Menu.ItemAction{text="Quit", MyAction=null}
            }
            );

        private static void Help()
        {
            Console.WriteLine("Welcom to our clinic ANIMALIA!");
            Console.WriteLine("Personal:");
            foreach (Doctor p in personal)
            {
                Console.WriteLine("Doctor {0}, qualification {1}. Experience {2} years", p.Name, p.Qualification, p.WorkStage);
            }
        }
        private static void Exsamination()
        {
            foreach (HomeAnimal ah in maneger.animals)
            {
                if (!ah.IsHealthy)
                {
                    ah.ExaminationReaction();
                }
            }
        }

        private static void Discharge()
        {
            int ident;
            Console.WriteLine("Enter ID of animal");
            while (!Int32.TryParse(Console.ReadLine(), out ident))
            { Console.WriteLine("You enter not correct number. Please, enter number"); }
            maneger.DischargeAnimal(ident);
        }

        private static void ShowList()
        {
            foreach (HomeAnimal ah in maneger.animals)
            {
                if (!ah.IsHealthy)
                {
                    Console.WriteLine("{0}: {1} {2}, owner: {3}. Therapist: ", ah.ID, ah.KindOfAnimal, ah.Name, ah.Owner);
                }
            }
        }

        private static void Register()
        {
            Console.WriteLine("Enter kind of animal(cat, dog, humster or fish)");
            string kind = Console.ReadLine();
            Console.WriteLine("Enter owner of animal");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter name of animal");
            string nameAnimal = Console.ReadLine();

            int id = 0;
            id = maneger.isConteins(nameAnimal, owner, kind);
            if (id != 0)
            {
                maneger.Readmission(id);
            }
            else
            {
                Console.WriteLine("Enter year of birthday of animal");
                int year;//= Console.ReadLine();
                while (!Int32.TryParse(Console.ReadLine(), out year))
                { Console.WriteLine("You enter not correct number. Please, enter number"); }
                int thisYear = Convert.ToInt32(DateTime.Now.Year);

                Console.WriteLine("Select your doctor:\n 1- surgeon\n 2- traumatologist");
                int doctorID;
                while (!Int32.TryParse(Console.ReadLine(), out doctorID) || doctorID < 1 && doctorID > 2)
                { Console.WriteLine("You enter not correct number. Please, enter number"); }


                if (kind == "cat")
                {
                    HomeCat newCat = new HomeCat(nameAnimal, maneger.animals.Count + 1, thisYear - year, doctorID, false, owner);
                    if (thisYear - year > newCat.AgeAverage)
                    { Console.WriteLine("Your cat is very old. Is data true?"); }
                    maneger.animals.Add(newCat);
                }

                if (kind == "dog")
                {
                    HomeDog newDog = new HomeDog(nameAnimal, maneger.animals.Count + 1, thisYear - year, doctorID, false, owner);
                    if (thisYear - year > newDog.AgeAverage)
                    { Console.WriteLine("Your dog is very old. Is data true?"); }
                    maneger.animals.Add(newDog);
                }

                if (kind == "hamster")
                {
                    HomeHamster newHumster = new HomeHamster(nameAnimal, maneger.animals.Count + 1, thisYear - year, doctorID, false, owner);
                    if (thisYear - year > newHumster.AgeAverage)
                    { Console.WriteLine("Your humster is very old. Is data true?"); }
                    maneger.animals.Add(newHumster);
                }

                if (kind == "fish")
                {
                    HomeFish newFish = new HomeFish(nameAnimal, maneger.animals.Count + 1, thisYear - year, doctorID, false, owner);

                    if (thisYear - year > newFish.AgeAverage)
                    { Console.WriteLine("Your fish is very old. Is data true?"); }
                    maneger.animals.Add(newFish);
                }
            }
        }

        static void Main(string[] args)
        {
           
            personal.Add(new Doctor("John Silver", "surgeon", 123, 21));
            personal.Add(new Doctor("Richard Baxter", "traumatologist", 2574, 12));
               
            HomeCat newAnimals = new HomeCat("Tom",maneger.animals.Count+1,3,123, false,"Piter Jackson");
            maneger.animals.Add(newAnimals);
            mainMenu.Show();
         
        }
    }
}
