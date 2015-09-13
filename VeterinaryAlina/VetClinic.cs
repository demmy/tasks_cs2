using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryAlina
{
    public class VetClinic
    {
        public string ClinicName {get; private set;}
        List<HomeAnimal> clinic;
        public VetClinic(string clinicName)
        {
            ClinicName = clinicName;
            clinic = new List<HomeAnimal> { };
        }      
        public void PrintAboutClinic()
        {
            Console.WriteLine("Home Animal Veterinary Clinic was founded in 2015.\n"+
                              "Our mission is pet health care and service. We always strive to provide\n"+
                              "our patients with the most knowledgeable and up-to-date care possible,\n"+
                              "while offering our clients the best customer service available.\n"+
                              "We feel that clients will want to return to our practice, with that as our primary goal.");
        }
        public void PutAnimalToClinic()
        {
            
        }

    }
}
