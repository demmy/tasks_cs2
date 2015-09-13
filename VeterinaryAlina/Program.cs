using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeFish fish1 = new HomeFish("Tom", 2015, "male", false, true, false, new DateTime(2015, 9, 11), HomeFish.FishBrids.Barb, "fractured fin");
            HomeFish fish2 = new HomeFish("Molly", 2015, "female", true, true, false, new DateTime(2015, 9, 11), HomeFish.FishBrids.Cory);
            VetClinic myClinic = new VetClinic("Home Animal Clinic");

            switch (ConsoleHelper.PrintMenu())
            {
                case MainMenu.AboutClinic: myClinic.PrintAboutClinic();
                    break;
                case MainMenu.PutToClinic:
                    break;
                case MainMenu.AnimalList:
                    break;
                case MainMenu.DischargeAnimal:
                    break;
                case MainMenu.QuitProgram:
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
