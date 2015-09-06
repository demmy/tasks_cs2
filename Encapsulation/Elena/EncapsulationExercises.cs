using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Elena
{
    class EncapsulationExercises : IEncapsulationExercises
    {
        public void MoneyMoney()
        {
           

            Money m1 = new Money();
            Money m2 = new Money(25,51);
            Money m3 = new Money(768);

            int hrivnas = m1.Hrivnas;
            int kopecks = m1.Kopeks;

            Money m4 = m1 + m3;
            int totalKopecs = (int)m2;
            float someMoney = (float)m2;
            string amount = (string)m2;

            ComplexNumber c1 = new ComplexNumber(2,3);
            ComplexNumber c2 = new ComplexNumber(-8, 5);

            ComplexNumber c3 = c1 + c2;
            c3 = c1 - c2;
            c3 = c1 * 2;
            c3 = c1 * c2;
            c3=c1/4;
            c3 = c1 / c2;
            string complexNumber = (string)c2;

        }

        public void WorkPriorityQueue()
        {
            Queue<object> q=new Queue<object>();
            PriorityQueue pq = new PriorityQueue(0,q );
            pq.Enqueue("Hi!", 2);
            pq.Enqueue("WTF?", 2);
            pq.Enqueue("Hello!", 1);
            pq.Enqueue("W", 2);
            pq.Enqueue(88, 1);

            object first = pq.First();
            object firstPriority = pq.First(2);

            object last = pq.Last();
            object lastPriority = pq.Last(1);
            object count = pq.Count;
            object countPriority = pq.GetCount(2);


        }
    }
}
