using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Elena
{
    public static class SortedData
    {
      public static  SortedSet<PriorityQueue> OurSetWhithData = new SortedSet<PriorityQueue>(new SortQueueByPriority());
    }

   public class PriorityQueue : IPriorityQueue<object>
    {
        private int  priority;
        private Queue<object> queueForPriority;

        public int Priority
        {
            get { return priority; }
        }

        
        public PriorityQueue(int p, Queue<object> q)
        {
            priority = p;
            queueForPriority = q;
        }

        public void Enqueue(object val, int priority)
        {
            bool isPriorityExist = false;
            foreach (PriorityQueue p in SortedData.OurSetWhithData)
                
            {
                if (p.priority == priority)
                {
                    isPriorityExist = true;
                    p.queueForPriority.Enqueue(val);
                }
            }

            if (!isPriorityExist)
            {
                Queue<object> q = new Queue<object>();
                q.Enqueue(val);
                
                SortedData.OurSetWhithData.Add(new PriorityQueue(priority, q));
            }

           
        }

        public object Dequeue()
        {
            object decueue;
            try
            {
                decueue = SortedData.OurSetWhithData.First<PriorityQueue>().queueForPriority.Dequeue();
            }

            catch (InvalidOperationException)
            {
                decueue = null;
            }
               
            return decueue;
        }

        public object First()
        {
            object first;
            try
            {
                first = SortedData.OurSetWhithData.First<PriorityQueue>().queueForPriority.Peek();
            }
            catch (InvalidOperationException)
            {
                first = null;
            }

            return first;
        }

        public object First(int priority)
        {
            object first =null;
            try
            {
                
                foreach (PriorityQueue p in SortedData.OurSetWhithData)
                {
                    if (p.priority == priority)
                    {
                        first = p.queueForPriority.Peek();
                    }
                }
            }
            catch (InvalidOperationException)
            {
                first = null;
            }

            return first;
        }

        public object Last()
        {
            object last;
            try
            {
                last = SortedData.OurSetWhithData.Last<PriorityQueue>().queueForPriority.Last<object>();
            }
            catch (InvalidOperationException)
            {
                last = null;
            }
            return last;
        }

        public object Last(int priority)
        {
            object last=null;
            try
            {
                foreach (PriorityQueue p in SortedData.OurSetWhithData)
                {
                    if (p.priority == priority)
                    {
                        last = p.queueForPriority.Last<object>();
                    }
                }
            }


            catch (InvalidOperationException)
            {
                last = null;
            }
            return last;
        }

        public int Count
        {
            get 
            {
                int allCount=0;
                try
                {
                    foreach (PriorityQueue p in SortedData.OurSetWhithData)
                    {
                       
                            allCount += p.queueForPriority.Count();
                        
                    }
                }

                catch (InvalidOperationException)
                {  }
                return allCount;
            }
        }

        public int GetCount(int priority)
        {
            int countInThisQoueu=0;
            try
            {
                foreach (PriorityQueue p in SortedData.OurSetWhithData)
                {
                    if (p.priority == priority)
                    {
                        countInThisQoueu = p.queueForPriority.Count();
                    }
                }
            }
            catch (InvalidOperationException)
            { }
            return countInThisQoueu;
        }
    }

    class SortQueueByPriority : IComparer<PriorityQueue>
    {
        
        public int Compare(PriorityQueue pq1, PriorityQueue pq2)
        {
            int resultOfCompare = 0;
            if (pq1.Priority > pq2.Priority)
            { resultOfCompare = 1; }
            if (pq1.Priority < pq2.Priority)
            { resultOfCompare = -1; }
            return resultOfCompare;
        }


    }
}

