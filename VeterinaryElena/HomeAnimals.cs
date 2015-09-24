using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{


   public abstract class HomeAnimal
    {
        int id;
        string name;
        int doctor;
        int age;
        bool isHealthy;
        int ageAverage;
        string kindOfAnimal;
        string owner;

        abstract public void ExaminationReaction();
      
        public string KindOfAnimal
        {
            get { return this.kindOfAnimal; }
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
            set { isHealthy = value; }
        }

        public HomeAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal, int averageOfAnimal, string kindAnimal)
        {
            name = nameOfAnimal;
            id = idOfAnimal;
            doctor = doctorOfAnimal;
            age = ageOfAnimal;
            isHealthy = isHealthyAnimal;
            ageAverage = averageOfAnimal;
            kindOfAnimal = kindAnimal;
            owner = ownerOfAnimal;
        }

    }

    public interface ICreatorAnimal
    {
        HomeAnimal FactoryCreatorAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                             bool isHealthyAnimal, string ownerOfAnimal);
    }

    public class CreatorCat:ICreatorAnimal
    {


        public HomeAnimal FactoryCreatorAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal)
        {
            return new HomeCat(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal);
        }
    }

    public class CreatorDog : ICreatorAnimal
    {
        public HomeAnimal FactoryCreatorAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal)
        {
            return new HomeDog(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal);
        }
    }

    public class CreatorHamster : ICreatorAnimal
    {
        public HomeAnimal FactoryCreatorAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal)
        {
            return new HomeHamster(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal);
        }
    }

    public class CreatorFish : ICreatorAnimal
    {
        public HomeAnimal FactoryCreatorAnimal(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal)
        {
            return new HomeFish(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal);
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
        {      }

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
        {}

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
        { }

    }

    class HomeFish : HomeAnimal
    {

        public override void ExaminationReaction()
        {
            Console.WriteLine("Fish is swiming");
        }
 public HomeFish(string nameOfAnimal, int idOfAnimal, int ageOfAnimal, int doctorOfAnimal,
                            bool isHealthyAnimal, string ownerOfAnimal )
            : base(nameOfAnimal, idOfAnimal, ageOfAnimal, doctorOfAnimal, isHealthyAnimal, ownerOfAnimal, 5, "fish")
        {      }


    }
}
    
