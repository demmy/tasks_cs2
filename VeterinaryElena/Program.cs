using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Doctor> personal = new List<Doctor>();
            personal.Add(new Doctor("John Silver", "surgeon", 123, 21));
            personal.Add(new Doctor("Richard Baxter", "traumatologist", 2574, 12));
            HomeCat newAnimals = new HomeCat("Tom",123,3,false, "Piter Jackson");

            HomeAnimals newAnimal = new HomeAnimals();

            newAnimal.animals.Add(newAnimals);

            string action;
            Console.WriteLine("Enter your action:\n H- information about company"+
                ",\n R - put new animal in clinic, \n L - show list of animals,\n D - discharge animal,\n Q - quit");
           

            action = Console.ReadLine();

            if (action == "R" || action == "r")
            {
                Console.WriteLine("Enter kind of animal(cat, dog, humster or fish)");
                string kind = Console.ReadLine();
                Console.WriteLine("Enter owner of animal");
                string owner = Console.ReadLine();
                Console.WriteLine("Enter name of animal");
                string nameAnimal = Console.ReadLine();

                int id = 0;
                id=newAnimal.isConteins(nameAnimal, owner, kind);
                if (id != 0)
                {
                    newAnimal.Readmission(id);
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

                        HomeCat newCat = new HomeCat(nameAnimal, doctorID, thisYear - year, false, owner);
                        if (thisYear - year > newCat.AgeAverage)
                        { Console.WriteLine("Your cat is very old. Is data true?"); }
                        newAnimal.animals.Add(newCat);
                    }

                    if (kind == "dog")
                    {

                        HomeDog newDog = new HomeDog(nameAnimal, doctorID, thisYear - year, false, owner);
                        if (thisYear - year > newDog.AgeAverage)
                        { Console.WriteLine("Your dog is very old. Is data true?"); }
                        newAnimal.animals.Add(newDog);
                    }

                    if (kind == "hamster")
                    {

                        HomeHamster newHumster = new HomeHamster(nameAnimal, doctorID, thisYear - year, false, owner);
                        if (thisYear - year > newHumster.AgeAverage)
                        { Console.WriteLine("Your humster is very old. Is data true?"); }
                        newAnimal.animals.Add(newHumster);
                    }

                    if (kind == "fish")
                    {
                        bool predatory=false;

                        HomeFish newFish = new HomeFish(nameAnimal, doctorID, thisYear - year, false, owner, predatory);
                        if (thisYear - year > newFish.AgeAverage)
                        { Console.WriteLine("Your fish is very old. Is data true?"); }
                        newAnimal.animals.Add(newFish);
                    }
                }
            }

          
            if (action == "L" || action == "l")
            {
                foreach (HomeAnimals ah in newAnimal.animals)
                {
                    if (!ah.IsHealthy)
                    {
                        Console.WriteLine("{0}: {1} {2}, owner: {3}. Therapist: ", ah.ID, ah.KindOfAnimal, ah.Name, ah.Owner);
                    }
                }
            }

           
            else if (action == "D" || action == "d")
            {
                int ident;
                Console.WriteLine("Enter ID of animal");
                while (!Int32.TryParse(Console.ReadLine(), out ident))
                { Console.WriteLine("You enter not correct number. Please, enter number"); }
                newAnimal.DischargeAnimal(ident);
            }


            else if (action == "Q" || action == "q")
            {
                Environment.Exit(0);
            }

            else if (action == "H" || action == "h")
            {
                Console.WriteLine("Welcom to our clinic ANIMALIA!");
                Console.WriteLine("Personal:");
                foreach (Doctor p in personal)
                {
                    Console.WriteLine("Doctor {0}, qualification {1}. Experience {2} years", p.name, p.qualification, p.workStage);
                }
            }


            Console.ReadKey(true);
        
        }
    }
}
