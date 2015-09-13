using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
        public enum MainMenu 
        {
            AboutClinic, PutToClinic, AnimalList, DischargeAnimal, QuitProgram
        }
    public class ConsoleHelper
    {
        public static MainMenu PrintMenu()
        {
            Console.WriteLine("[H] About company");
            Console.WriteLine("[R] Put new animal in clinic");
            Console.WriteLine("[L] Show list of animals");
            Console.WriteLine("[D] Discharge animal");
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
                    case "Q": return MainMenu.QuitProgram;
                    default:
                        break;
                }
            } while (true);
        }


            
            

    }
}
