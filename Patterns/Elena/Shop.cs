using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Patterns.Elena
{
    /*public class ShopEventArgs
    {
        public void SampleEventArgs(string s) { Text = s; }
        public String Text {get; private set;} // readonly
    }
    */
   

    class Shop
    {
        public delegate void MyHendler();
        public event MyHendler ShopClosed;
        public event MyHendler WhiteDressArrived;
        public event MyHendler RedDressArrived;
        public event MyHendler MenShirtArrived;
        public event MyHendler ChildrenSuitArrived;

        public Shop()
        {
            Timer mytimer = new Timer();
            mytimer.Interval = 5000;
            mytimer.Elapsed += ShopWork;
            mytimer.Start();
            
         }

        public void ShopWork(object sender, EventArgs e)
        {
            Random newActionCode=new Random();
            int newEventRandom = newActionCode.Next(5);
            if (newEventRandom==1)
            {
                WhiteDressArrived();
            }

            else  if (newEventRandom==2)
            {
                ShopClosed();
            }

            else if (newEventRandom == 3)
            {
               RedDressArrived();
            }

            else if (newEventRandom ==4)
            {
                MenShirtArrived();
            }

            else if (newEventRandom == 5)
            {
                ChildrenSuitArrived();
            }


        }

     
    }
}
