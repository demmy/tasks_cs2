using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryVladimir
{
    class Clinica 
    {
        private List<CartAnimal> animals;

        public Clinica()
        {
            animals = new List<CartAnimal>();
        }
        
        public void addAnimal(HomeAnimal notHealthAnimal)
        {
            CartAnimal newCart = new CartAnimal();
            newCart.animal = notHealthAnimal;
            newCart.isHealth = false;
            newCart.inDate = DateTime.Now;

            animals.Add(newCart);
        }

        public void clinicaOut(int id)
        {
            CartAnimal cart = animals[id];
            cart.isHealth = true;
            cart.outDate = DateTime.Now;
        }

        public List<CartAnimal> getAnimals()
        {
            return animals;
        }

        
    }
}
