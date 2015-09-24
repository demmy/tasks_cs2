using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Alina
{
    public class Goods
    {
        public string Name { get; private set; }
        public Goods(string name)
        {
            Name = name;
        }
    }
}
