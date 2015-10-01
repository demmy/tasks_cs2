using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject
{
    class Model
    {

        public int summ(int a, int b)
        {
            return (a + b);
        }

        public int difference(int a, int b)
        {
            return (a - b);
        }

        public int multiplication(int a, int b)
        {
            return (a*b);
        }

        public double div(int a, int b)
        {
            return ((double)a/(double)b);
        }
    }
}
