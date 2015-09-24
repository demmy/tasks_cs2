using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Alina
{
    public class Customer
    {
        public string Name { get; private set; }
        public Customer(string name)
        {
            Name = name;
        }
        public void ReactToArrival()
        {
            Console.WriteLine("{0} say: I received a notification", Name);
        }
        public void BuyGoods()
        {
            Console.WriteLine("{0} say: I will buy this product!", Name);
        }
        public void IgnoreNotice()
        {
            Console.WriteLine("{0} say: I will ignore this notice!", Name);
        }
        public void UnsubscribeFromNotificationsg()
        {
            Console.WriteLine("{0} say: I will unsubscribe from this notice!", Name);
        }
    }
}
