using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioharjoitustyo
{
    public class Merkinta
    {
        private readonly /*double*/ string MaxKesto = "7200";
        public string Tyyppi { get; set; }
        public /*double*/ string Matka { get; set; }
        public string Paiva { get; set; }
        private /*double*/ string kesto;
        public /*double*/ string Kesto { get; set; } /*
        get
            {
                return kesto;
            }
            set
            {
                if (value <= MaxKesto) kesto = value;
                else
                {
                    Virhe();
                    kesto = 0;
                } 
            }*/

        public string Kuvaus { get; set; }
        
    }
}
