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
                
                switch (ConsoleHelper.PrintMenu())
                {
                    case MainMenu.AboutClinic:
                        myClinic.PrintAboutClinic();
                        break;
                    case MainMenu.PutToClinic:
                        myClinic.PutAnimalToClinic();
                        break;
                    case MainMenu.AnimalList:
                        myClinic.ShowListOfAnimals();
                        break;
                    case MainMenu.DischargeAnimal:
                        myClinic.DischargeAnimal();
                        break;
                    case MainMenu.MedicalInspection:
                        myClinic.MedicalInspection();
                        break;
                    case MainMenu.QuitProgram:
                        isRuning = false;
                        break;
                    default:
                        break;
                }
            } while (isRuning);
        }
    }
}
