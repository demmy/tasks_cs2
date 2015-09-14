﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    class Program
    {
        //Использовать набор "домашних животных" классов для написания программы для работы с животными в клинике в отделении "стационара.
        //Программа должна "висеть" в главном меню:
        //    [H] About company
        //    [R] Put new animal in clinic
        //    [L] Show list of animals
        //    [D] Discharge animal
        //    [Q] Quit
        //    (введена ли прописная буква или строчная, не имеет значения).
        //"Put new animal in clinic" значит, что клиент принес животное, которое регистрируется в клинике как лечащееся.
        //   Животному присваивается индивидуальный номер, абсолютно уникальный среди других когда-либо лечившихся животных.
        //"Show list of animals" показывает список животных, которые сейчас лечатся в клинике.
        //"Discharge animal" значит, что животное выписывается. Животных выписывают по индивидуальному номеру,
        //    при выборе этого пункта программа должна спросить номер животного.


        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Clinica clinica = new Clinica();

            HomeDog enimal1 = new HomeDog("Тобик", 3);
            HomeDog enimal2 = new HomeDog("Бобик", 3);
            HomeDog enimal3 = new HomeDog("Бибик", 3);

            HomeCat enimal4 = new HomeCat("Соня", 4);
            HomeCat enimal5 = new HomeCat("Моня", 4);
            HomeCat enimal6 = new HomeCat("Фоня", 4);
            /*
               HomeHamster enimal7  = new HomeHamster("Барон", 3);
               HomeHamster enimal8  = new HomeHamster("Банан", 3);
               HomeHamster enimal9  = new HomeHamster("БоБо" , 3);
               
               HomeFish enimal10 = new HomeFish("Золото",3);
               HomeFish enimal11 = new HomeFish(""      ,3);
               HomeFish enimal12 = new HomeFish(""      ,3);
            */

            clinica.addAnimal(enimal1);
            clinica.addAnimal(enimal2);
            clinica.addAnimal(enimal3);

            clinica.addAnimal(enimal4);
            clinica.addAnimal(enimal5);
            clinica.addAnimal(enimal6);


            for (int animalIndex = 0; animalIndex < clinica.getAnimals().Count; animalIndex++)
            {
                Console.WriteLine("ID= {0} карточка= {1}",
                     animalIndex,
                     clinica.getAnimals()[animalIndex].ToString());
            }

            //int ww = 1;

            Console.WriteLine("");

            clinica.clinicaOut(1);

            for (int animalIndex = 0; animalIndex < clinica.getAnimals().Count; animalIndex++)
            {
                Console.WriteLine("ID= {0} карточка= {1}",
                     animalIndex,
                     clinica.getAnimals()[animalIndex].ToString());
            }

            //int www = 1;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                Console.WriteLine("[H] About company");
                Console.WriteLine("[R] Put new animal in clinic");
                Console.WriteLine("[L] Show list of animals");
                Console.WriteLine("[D] Discharge animal");
                Console.WriteLine("[Q] Quit");

                cki = Console.ReadKey();
                if (cki.Key.ToString() == "H" || cki.Key.ToString() == "h")
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Welcome!");
                    Console.ReadKey();
                }
                else if (cki.Key.ToString() == "R" || cki.Key.ToString() == "r")
                {
                    // ---MenuR();  // Добавить элемент
                    ConsoleKeyInfo ckiR;
                    do
                    {
                        int ageAnimal = 0;
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);

                        Console.WriteLine("Enter for add: [C] - Cat, [D] Dog, [H] Hamster, [F] Fish, [Q] Quit");
                        Console.WriteLine("[C] Cat");
                        Console.WriteLine("[D] Dog");
                        Console.WriteLine("[H] Hamster");
                        Console.WriteLine("[F] Fish");
                        Console.WriteLine("[Q] Quit");

                        ckiR = Console.ReadKey();
                        if (ckiR.Key.ToString() == "C" || ckiR.Key.ToString() == "c")
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Name of Cat?");
                            string nameAnimal = "0";
                            nameAnimal = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Age of Cat? Only int!");
                            }
                            while (!int.TryParse(Console.ReadLine(), out ageAnimal) || ageAnimal < 0);
                            HomeCat enimal = new HomeCat(nameAnimal, ageAnimal);
                            clinica.addAnimal(enimal);
                        }
                        else if (ckiR.Key.ToString() == "D" || ckiR.Key.ToString() == "d")
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Name of Dog?");
                            string nameAnimal = "0";
                            nameAnimal = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Age of Dog? Only int!");
                            }
                            while (!int.TryParse(Console.ReadLine(), out ageAnimal) || ageAnimal < 0);
                            HomeDog enimal = new HomeDog(nameAnimal, ageAnimal);
                            clinica.addAnimal(enimal);
                        }
                        else if (ckiR.Key.ToString() == "H" || ckiR.Key.ToString() == "h")
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Name of Hamster");
                            string nameAnimal = "0";
                            nameAnimal = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Age of Hamster? Only int!");
                            }
                            while (!int.TryParse(Console.ReadLine(), out ageAnimal) || ageAnimal < 0);
                            HomeCat enimal = new HomeCat(nameAnimal, ageAnimal);
                            clinica.addAnimal(enimal);
                        }
                        else if (ckiR.Key.ToString() == "F" || ckiR.Key.ToString() == "f")
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Name of Fish");
                            string nameAnimal = "0";
                            nameAnimal = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Age of Fish? Only int!");
                            }
                            while (!int.TryParse(Console.ReadLine(), out ageAnimal) || ageAnimal < 0);
                            HomeCat enimal = new HomeCat(nameAnimal, ageAnimal);
                            clinica.addAnimal(enimal);
                        }
                        Console.WriteLine("Added! Press any key...");
                        Console.ReadKey();

                    }
                    while (ckiR.Key != ConsoleKey.Escape && ckiR.Key.ToString() != "Q" && ckiR.Key.ToString() != "q");

                    //---MenuR. -----------------------
                }
                else if (cki.Key.ToString() == "L" || cki.Key.ToString() == "l")
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Список животных клиники:");

                    for (int animalIndex = 0; animalIndex < clinica.getAnimals().Count; animalIndex++)
                    {
                        if (clinica.getAnimals()[animalIndex].isHealth == false)
                        {
                            Console.WriteLine("ID= {0} карточка= {1}",
                                animalIndex,
                                clinica.getAnimals()[animalIndex].ToString());
                        }
                    }
                    Console.ReadKey();
                }
                else if (cki.Key.ToString() == "D" || cki.Key.ToString() == "d")
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Код животного?");
                    int i;
                    while (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i > clinica.getAnimals().Count)
                    {
                        Console.Write("Попробуйте еще раз. Число должно быть целым от 0 до (включительно) {0}: ", clinica.getAnimals().Count);
                    }

                    // проверить индекс
                    if (clinica.getAnimals()[i].isHealth == false)
                    {
                        clinica.clinicaOut(i);
                        Console.WriteLine("Животное с ID ={0} выписано из клиники", i);
                    }
                    else
                    {
                        Console.WriteLine("Животное с ID ={0} на момент запроса вне клиники", i);
                    }

                    for (int animalIndex = 0; animalIndex < clinica.getAnimals().Count; animalIndex++)
                    {
                        Console.WriteLine("ID= {0} карточка= {1}",
                             animalIndex,
                             clinica.getAnimals()[animalIndex].ToString());
                    }


                    Console.ReadKey();
                }
            }
            while (cki.Key != ConsoleKey.Escape && cki.Key.ToString() != "Q" && cki.Key.ToString() != "q");

        }
    }
}