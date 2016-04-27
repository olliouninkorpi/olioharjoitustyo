using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioharjoitustyo
{
    public class Merkinta
    {
        private readonly double MaxKesto = 7200;
        public string Tyyppi { get; set; }
        public double Matka { get; set; }
        public string Paiva { get; set; }
        private double kesto;
        public double Kesto {
                get
            {
                return kesto;
            }
            set
            {
                if (value <= MaxKesto) kesto = value;
                else
                {
                    /*Virhe();*/
                    kesto = 0;
                }
            }
        }

        public string Kuvaus { get; set; }
        
    }
}
