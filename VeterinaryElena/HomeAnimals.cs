using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
   abstract  class HomeAnimal
    {
        int id;
        string name;
        int doctor;
        int age;
        bool isHealthy;
        int ageAverage;
        string kindOfAnimal;
        string owner;


        public HomeAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal, int averageOfAnimal, string kindAnimal)
        {
            name = nameOfAnimal;
            id = idOfAnimal;
            doctor = doctorOfAnimal;
            age =ageOfAnimal ;
            isHealthy = isHealthyAnimal;
            ageAverage = averageOfAnimal;
            kindOfAnimal = kindAnimal;
            owner = ownerOfAnimal;
        }
        abstract public void ExaminationReaction();


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
       {
           get { return isHealthy; } 
           set {isHealthy=value;}
       }


      
    }

    class HomeDog : HomeAnimal
    {
        public override void ExaminationReaction()
        {
            Console.WriteLine("Dog is siting");
        }
        public HomeDog(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal )
            :base(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal,isHealthyAnimal, ownerOfAnimal,10,"dog" )
        {
          
        }
        
    }

    class HomeHamster : HomeAnimal
    {
        public override void ExaminationReaction()
        {
            Console.WriteLine("Hamster is runing!Catch it!");
        }
    public HomeHamster(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal, 
                            bool isHealthyAnimal, string ownerOfAnimal )
            : base(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal, 2, "humster")
        {

        }
    }

    class HomeCat : HomeAnimal
    {
        public override void ExaminationReaction()
        {
            Console.WriteLine("Cat is bitting");
        }

 public HomeCat(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal )
            : base(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal, 10, "cat")
        {
            
        }
    }

    class HomeFish : HomeAnimal
    {
      //  bool ispredatory;

        public override void ExaminationReaction()
        {
            Console.WriteLine("Fish is swiming");
        }
 public HomeFish(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal )
            : base(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal, 5, "fish")
        {

        }
    }
}
    
