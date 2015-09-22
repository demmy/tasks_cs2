using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Konstantin
{
         class PrimeNumbers : ISimpleNumbers
         {
            private int limit = 0;
            public PrimeNumbers(int top) { this.limit = top; }

            private class PMSequence : IEnumerator<int>
            {
                private PrimeNumbers instance;
                private int currentNumber = 0;

                public PMSequence(PrimeNumbers instance) { this.instance = instance; }

                public object Current
                {
                    get { return currentNumber; }
                }

                public bool MoveNext()
                {
                    bool isPrime = true;
                    for (int i = currentNumber+1; i <= this.instance.limit; i++)
                    {
                        isPrime = true;
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {

                            if ((i % j == 0||i==1)&&i!=0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            currentNumber = i;
                            break;
                        }
                    }
                    return isPrime;
                }

                public void Reset()
                {
                    currentNumber = 0;
                }

                int IEnumerator<int>.Current
                {
                    get { return currentNumber; }
                }

                public void Dispose()
                {
                    instance = null;
                }
            }

            public IEnumerator<int> GetEnumerator()
            {
                return new PMSequence(this);
                
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
         }
}
