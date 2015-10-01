using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPProject
{
    class Controller
    {
         Model model = new Model();
        public int ResultSumm(int a,int b)
        {
            return model.summ(a, b);
        }

        public int ResultDifference(int a, int b)
        {
            return model.difference(a, b);
        }

        public int ResultMiltiplication(int a, int b)
        {
            return  model.multiplication(a, b);;
        }

        public double ResultDivision(int a, int b)
        {
            return model.div(a,b);
        }
    }
}
