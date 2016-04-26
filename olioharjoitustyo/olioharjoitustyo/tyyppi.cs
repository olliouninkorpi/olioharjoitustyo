using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioharjoitustyo
{
    class tyyppi
    {
        private readonly double MaxKesto = 7200;
        public string Tyyppi { get; set; }
        public double Matka { get; set; }
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
                    Console.WriteLine("Virheellinen kesto. Syötä pienempi luku.");
                    kesto = 0;
                }
            }
        public string Kuvaus { get; set; }
    }
}
