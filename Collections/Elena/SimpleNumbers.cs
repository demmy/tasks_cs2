using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Elena
{
    class SimpleNumbers:ISimpleNumbers
    {
       private static List<int> simple = new List<int>();
       
        public SimpleNumbers(int max)
        {
         
            for (int i = 1; i < max; i++)
                simple.Add(i);
            int j = 1;
            while (j < simple.Count)
            {
                Step(simple[j], j);
                j++;
            }

        }

        int Step(int Prime, int startFrom)
        {
            int i = startFrom + 1;
            int Removed = 0;
            while (i < simple.Count)
                if (simple[i] % Prime == 0)
                {
                    simple.RemoveAt(i);
                    Removed++;
                }
                else
                    i++;
            return Removed;
        }

        private class SNSequence : IEnumerator<int>
        {
            private  int currentNumber = 0;
            private SimpleNumbers instance;
            public SNSequence(SimpleNumbers instance)
            {
                this.instance = instance;
            }

            public int Current
            {
                get
                {
                    if (currentNumber == -1 ||currentNumber == simple.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return simple[currentNumber]; 
                }
            }

            public void Dispose()
            {
              
            }

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            public bool MoveNext()
            {
                //this.instance;
               if (currentNumber != simple.Count)
                {
                    currentNumber++;
                }
                return currentNumber < simple.Count;
              
            }

            public void Reset()
            {
                currentNumber = -1;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SNSequence(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
