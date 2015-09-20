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
            bool isRuning = true;
            VetClinic myClinic = new VetClinic("Home Animal Clinic");
            do
            {
                ConsoleHelper.PrintMyMenu(ConsoleHelper.menuItems);
                switch (ConsoleHelper.GetMenuItem(ConsoleHelper.menuItems))
                {
                    case "About company":
                        myClinic.PrintAboutClinic();
                        break;
                    case "Put new animal in clinic":
                        myClinic.PutAnimalToClinic();
                        break;
                    case "Show list of animals":
                        myClinic.ShowListOfAnimals();
                        break;
                    case "Discharge animal":
                        myClinic.DischargeAnimal();
                        break;
                    case "Medical inspection of animal":
                        myClinic.MedicalInspection();
                        break;
                    case "Quit":
                        isRuning = false;
                        break;
                    default:
                        break;
                }
            } while (isRuning);
        }
    }
}
