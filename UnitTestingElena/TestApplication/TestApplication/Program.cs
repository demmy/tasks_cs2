using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Sum(2, 3));
            unchecked
            {
                Console.WriteLine((int.MaxValue + 1).ToString());
            
           Console.WriteLine((int.MinValue-1).ToString());}
            Console.ReadKey(true);
        }

       /* public static bool Assert(bool obj, string message)
        {
            if (obj)
            { Console.WriteLine("It's false"); }

            else { Console.WriteLine(message); }

            return obj;
        }*/

      static public int Sum(int op1, int op2)
        {
            return op1 + op2;
        }
    }
}
