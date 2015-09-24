using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    enum menuDoctor { Surgeon = 123, Traumatologist = 2574 };
    class Program
    {

       public static ManagementClinic maneger = new ManagementClinic();
       public static List<Doctor> personal = new List<Doctor>();
       public static List<HomeAnimal> animals = new List<HomeAnimal>();

        private static Menu mainMenu = new Menu(
            new Menu.ItemAction[]
            {
                new Menu.ItemAction{shortName="R",text="Register new animal", MyAction=Register, Code=1},
                new Menu.ItemAction{shortName="L", text="Show list of  animals", MyAction=ShowList, Code=2},
                new Menu.ItemAction{shortName="D", text="Discharge animal", MyAction=Discharge, Code=3},
                new Menu.ItemAction{shortName="E", text="Exsamination", MyAction=Exsamination, Code=4},
                new Menu.ItemAction{shortName="H", text="About clinica", MyAction=Help,Code=5},
                new Menu.ItemAction{shortName="Q", text="Quit", MyAction=null, Code=6}
            }
            );

        private static Menu doctorMenu = new Menu(
            new Menu.ItemCode[]
            {
                new Menu.ItemCode{shortName="S",Code=(int)menuDoctor.Surgeon, Description="Surgeon"},
                new Menu.ItemCode{shortName="T",Code=(int)menuDoctor.Traumatologist, Description="Traumatologist"}
            });

        private static void GetDoctor()
        {
            Doctor doctorOfAnimal;

          //  return doctorOfAnimal;
        }

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
            foreach (HomeAnimal ah in animals)
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
            foreach (HomeAnimal ah in animals)
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
                int doctorID;
                Console.WriteLine("Select your doctor:");
                switch ((menuDoctor)doctorMenu.GetChoice())
                {
                    case menuDoctor.Surgeon:
                        doctorID = 123;
                        break;
                    case menuDoctor.Traumatologist:
                        doctorID = 2574;
                        break;
                    default:
                        throw new ApplicationException("Incorrect code");
                }


                if (kind == "cat")
                {
                    CreatorCat newCat = new CreatorCat();
                    animals.Add(newCat.FactoryCreatorAnimal(nameAnimal, animals.Count + 1, thisYear - year, doctorID, false, owner));
                }

                if (kind == "dog")
                {
                    CreatorDog newDog = new CreatorDog();
                    animals.Add(newDog.FactoryCreatorAnimal(nameAnimal, animals.Count + 1, thisYear - year, doctorID, false, owner));
                }

                if (kind == "hamster")
                {
                    CreatorHamster newHamster = new CreatorHamster();
                    animals.Add(newHamster.FactoryCreatorAnimal(nameAnimal, animals.Count + 1, thisYear - year, doctorID, false, owner));
                }

                if (kind == "fish")
                {
                    CreatorFish newFish = new CreatorFish();
                    animals.Add(newFish.FactoryCreatorAnimal(nameAnimal, animals.Count + 1, thisYear - year, doctorID, false, owner));
                }
            }
        }

        static void Main(string[] args)
        {
           
            personal.Add(new Doctor("John Silver", "surgeon", 123, 21));
            personal.Add(new Doctor("Richard Baxter", "traumatologist", 2574, 12));
               
            HomeCat newAnimals = new HomeCat("Tom",animals.Count+1,3,123, false,"Piter Jackson");
            animals.Add(newAnimals);
            mainMenu.Show();
            
         
        }
    }
}
