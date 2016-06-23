using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Model
{
    public class BijkomendProduct : IVehuurable
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Aantal { get; set; }

        public BijkomendProduct()
        {
            Prijs = 1.25;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
