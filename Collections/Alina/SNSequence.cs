using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Alina
{
    class SNSequence: IEnumerator<int>
    {
        SimpleNumber instance;
        int current = -1;
        public SNSequence(SimpleNumber instance)
        {
            this.instance = instance;
        }
        public int Current
        {
            get { return instance[current]; }
        }

        public void Dispose()
        {
           
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            bool isNext = false;
            if (current < instance.Count - 1)
            {
                current++;
                isNext = true;
            }
            return isNext;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}
