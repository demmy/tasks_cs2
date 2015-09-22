using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Elena
{
    class SimpleNumbers:ISimpleNumbers
    {
       //private static List<int> simple = new List<int>();
       SimpleNumbers instance;
        private int maxNumber;
        public SimpleNumbers(int max)
        {
           // instance = as(SimpleNumbers)1;
            maxNumber = max;
        }

        private class SNSequence : IEnumerator<int>
        {
            private  int current = 0;
            private SimpleNumbers instance;

            public SNSequence(SimpleNumbers instance)
            {
                this.instance = instance;
            }

            public int Current
            {
                get
                {
                    return current;
                    /*if (currentNumber == -1 ||currentNumber == simple.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    return simple[currentNumber]; */
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
                bool rezult=false;
                int temp = Current + 1;
                int next = 0;
                int exit = 0;
                int i = 2;

                while (exit == 0)
                {
                    if (temp % i == 0 && i != temp)
                    {
                        temp++;
                        i = 2;
                        continue;
                    }

                    if ((i == temp) || (i > Math.Sqrt(temp)))
                    {
                        next = temp;
                        exit = 1;
                    }

                    i++;
                }
                if (next <= instance.maxNumber)
                { rezult = true;
                current = next;
                }
                return rezult;
              
              
            }

            public void Reset()
            {
                current = -1;
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
