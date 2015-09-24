using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Patterns.Alina
{
    public class Shop
    {
        List<Customer> customerBase = new List<Customer>();
        public void AddToClientList(Customer newCustomer)
        {
            customerBase.Add(newCustomer);
        }
        public void DeleteFromClientList(Customer customer)
        {
            customerBase.Remove(customer);
        }

        Dictionary<string, List<Goods>> shopwindow = new Dictionary<string, List<Goods>>(){
            {"Vacuum cleaners", new List<Goods>()},
            {"Washing machines", new List<Goods>()},
            {"Tablets", new List<Goods>()}
        };
        public delegate void MyHendler();
        public event MyHendler GoodArrived;
        public Shop()
        {
            Timer mytimer = new Timer();
            mytimer.Interval = 7000;
            mytimer.Elapsed += mytimer_Elapsed;
            mytimer.Start();
        }

        void mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            GoodsArrived();
            SendNotifyToClient();
            GoodArrived();
        }
        public void SendNotifyToClient()
        {
            foreach (var subscriber in customerBase)
                subscriber.ReactToArrival();
        }

        public void GoodsArrived()
        {
            shopwindow["Vacuum cleaners"].Add(new Goods("Vacuum cleaner"));
            shopwindow["Washing machines"].Add(new Goods("Washing machine"));
            shopwindow["Tablets"].Add(new Goods("Tablet"));
        }
    }
}
