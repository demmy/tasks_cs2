using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    class HomeAnimals
    {
        protected int id;
        protected string name;
        protected int doctor;
        protected int age;
        protected bool isHealthy;
        protected int ageAverage;
        protected string kindOfAnimal;
        protected string owner;

       public string KindOfAnimal
       {
        get{return this.kindOfAnimal;}
       }

       public string Name
       { get { return name; } }


       public int AgeAverage
       { get { return ageAverage; } }


       public int ID
       { get { return id; } }


       public string Owner
       { get { return owner; } }

       public bool IsHealthy
       { get { return isHealthy; } }
       /*public string Doctor
       {
           get
           {
                foreach(Doctor d in personal)
           }
       }*/
        public List<HomeAnimals> animals = new List<HomeAnimals>();

        protected HomeAnimals ReturnPets(int identificator)
        {
            foreach (HomeAnimals ha in animals)
            {
                if (ha.id == identificator)
                {return ha;}
            }

            throw new InvalidOperationException();
        }

        public void DischargeAnimal(int identificator)
        {
            try
            {
                ReturnPets(identificator).isHealthy = true; ;
            }

            catch(InvalidOperationException)
            {

            }
            
        }

        public void Readmission(int identificator)
        {
            ReturnPets(identificator).isHealthy = false;
        }

        public int isConteins(string nameA, string ownerA, string kindA)
        {
            int number = 0;
            foreach (HomeAnimals ha in animals)
            {
                if (ha.name == nameA && ha.owner == ownerA && ha.kindOfAnimal == kindA)
                { number = ha.id; }
            }

            return number;
        }
    }

    class HomeDog : HomeAnimals
    {
        public HomeDog(string n, int d, int a, bool iH, string o)
        {
            name = n;
            id = animals.Count + 1;
            doctor = d;
            age = a;
            isHealthy = iH;
            ageAverage = 10;
            kindOfAnimal = "dog";
            owner = o;
        }
    }

    class HomeHamster : HomeAnimals
    {
        public HomeHamster(string n, int d, int a, bool iH, string o)
        {
            name = n;
            id = animals.Count + 1;
            doctor = d;
            age = a;
            isHealthy = iH;
            ageAverage = 2;
            kindOfAnimal = "hamster";
            owner = o;
        }
    }

    class HomeCat : HomeAnimals
    {
        public HomeCat(string n, int d, int a, bool iH, string o)
        {
           
                name = n;
                id = animals.Count + 1;
                doctor = d;
                age = a;
                isHealthy = iH;
                ageAverage = 15;
                kindOfAnimal = "cat";
                owner = o;
            
        }
    }

    class HomeFish : HomeAnimals
    {
        bool ispredatory;
        public HomeFish(string n, int d, int a, bool iH, string o, bool predatory)
        {
            name = n;
            id =animals.Count + 1;
            doctor = d;
            age = a;
            isHealthy = iH;
            ageAverage = 1;
            kindOfAnimal = "fish";
            owner = o;
            ispredatory = predatory;
        }
    }
}
