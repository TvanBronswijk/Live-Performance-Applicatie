using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Model
{
    public class Boot : IVehuurable
    {
        public enum Type { Kano = 1, Valk = 2, Laser = 3, Cruiser = 4};

        public int ID { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public Type BootType { get; set; }

        public Boot()
        {

        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
