using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public enum AnimalType 
    {
        Cat, Dog, Fish, Hamster, Parrot
    }
    static class AnimalFactory
    {
        public static HomeAnimal CreateAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat: 
                    break;
                case AnimalType.Dog:
                    break;
                case AnimalType.Fish:
                    break;
                case AnimalType.Hamster:
                    break;
                case AnimalType.Parrot:
                    break;
                default:
                    break;
            }
        }
    }
}
