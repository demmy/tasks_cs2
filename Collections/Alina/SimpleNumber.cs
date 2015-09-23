using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Alina
{
    class SimpleNumber: ISimpleNumbers
    {
        List<int> numbers = new List<int>();
        public SimpleNumber(int top)
        {
            for (int i = 2; i < top; i++)
            {
                if (IsNumberSimple(i))
                {
                    numbers.Add(i);
                }
            }
        }
        private bool IsNumberSimple(int number)
        {
            bool isSimple = true;
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }
            return isSimple;
        }
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers.Insert(index, value); }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SNSequence(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int Count
        {
            get { return numbers.Count; }
        }
    }
}
