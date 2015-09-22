﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class VetClinic
    {
        public string ClinicName { get; private set; }
        List<HomeAnimal> clinic = new List<HomeAnimal>();
        HomeAnimal animal;
        public VetClinic(string clinicName)
        {
            ClinicName = clinicName;
            clinic = new List<HomeAnimal> { };
        }
        public void PrintAboutClinic()
        {
            Console.WriteLine("Home Animal Veterinary Clinic was founded in 2015.\n" +
                              "Our mission is pet health care and service. We always strive to provide\n" +
                              "our patients with the most knowledgeable and up-to-date care possible,\n" +
                              "while offering our clients the best customer service available.\n" +
                              "We feel that clients will want to return to our practice, with that as our primary goal.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void PutAnimalToClinic()
        {
            ConsoleHelper.PrintMyMenu(ConsoleHelper.anymalType);
            string type = ConsoleHelper.GetMenuItem(ConsoleHelper.anymalType);
            string brid = ConsoleHelper.PrintAnimalBrids(type);
            string name = ConsoleHelper.GetNameForCreateAnimal();
            string gender = ConsoleHelper.GetgenderOfAnimalForCreateAnimal();
            DateTime birthDate = ConsoleHelper.GetBirthYearForCreateAnimal();
            bool isHelthy = ConsoleHelper.GetIsHealsyForCreateAnimal();
            bool isVaccinate = ConsoleHelper.GetIsVaccinatedForCreateAnimal();
            bool isAlergicToMedication = ConsoleHelper.GetIsAlergicToMedicationForCreateAnimal();
            string disease = ConsoleHelper.GetDisease();

            animal = AnimalFactory.CreateAnimal(type, name, birthDate, gender, isHelthy,
                isVaccinate, isAlergicToMedication, DateTime.Now, brid, disease);
            clinic.Add(animal);
        }
        public void ShowListOfAnimals()
        {
            if (clinic.Count != 0)
            {
                foreach (var animal in clinic)
                {
                    Console.WriteLine(animal);
                }
            }
            else
            {
                Console.WriteLine("Clinic is empty");
            }
            Console.ReadLine();
        }
        public void DischargeAnimal()
        {
            int id = ConsoleHelper.GetInt("Input ID to remove", 1, clinic.Count);
            clinic.RemoveAt(id - 1);
        }
        public void MedicalInspection()
        {
            if (clinic.Count != 0)
            {
                int id = ConsoleHelper.GetInt("Input ID to show condition of animal", 1, clinic.Count);
                animal.ShowConditionOFAnimal(id); 
            }
            else
            {
                Console.WriteLine("Clinic is empty");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

    }
}
