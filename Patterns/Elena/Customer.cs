using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Elena
{
    class Customer:ISubscriber
    {
        string name;
        public Customer(string n)
        {
            name = n;
        }

        public string Name { get { return name; } }
        public void ReactOnClossing()
        {
            Console.WriteLine("{0}: I cannt buy nothing: shop is closed", this.Name);
        }

        public void ReactOnGoodArrivedNegative()
        {
            Console.WriteLine("{0}: I don't buy this", this.Name);
        }

       public  void ReactOnGoodArrivedNull()
        {
            Console.WriteLine("{0}: I don't know, I'll buy this or not", this.Name);
        }

        public  void ReactOnGoodArrivedPositive()
        {
            Console.WriteLine("{0}: I buy this", this.Name);
        }
    }
}
