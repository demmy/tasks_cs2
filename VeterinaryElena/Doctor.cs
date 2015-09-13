using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    public class Doctor
    {
        public string name;
        public string qualification;
        public int id;
        public int workStage;



       public Doctor(string n, string q, int i, int wS)
        {
            name = n;
            qualification = q;
            id = i;
            workStage = wS;
        }
    }
}
