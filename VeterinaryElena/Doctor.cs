using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryElena
{
    public class Doctor
    {
         string name;
         string qualification;
         int id;
         int workStage;



       public Doctor(string n, string q, int i, int wS)
        {
            name = n;
            qualification = q;
            id = i;
            workStage = wS;
        }

       public string Name
       { get { return name; } }

       public string Qualification
       { get { return qualification; } }
       
       public int WorkStage
       { get { return workStage; } }


    }
}
