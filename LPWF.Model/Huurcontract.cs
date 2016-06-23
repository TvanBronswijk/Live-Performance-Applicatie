using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Model
{
    public class Huurcontract
    {
        public int ID { get; set; }

        public List<Boot> Boten { get; set; }
        public List<BijkomendProduct> Producten { get; set; }

        public List<string> Zee { get; set; }
        public DateTime Van { get; set; }
        public DateTime Tot { get; set; }
        public int Meer { get; set; }
        public string[] Persoon { get; set; }

        public Huurcontract()
        {
            Boten = new List<Boot> { };
            Producten = new List<BijkomendProduct> { };
            Zee = new List<string> { };
            Persoon = new string[2];
        }

        public override string ToString()
        {
            string returnstring = "De volgende boten zijn gehuurd: ";
            foreach(Boot B in Boten)
            {
                returnstring += B.ToString() + ", ";
            }
            returnstring = returnstring.Remove(returnstring.Count() - 2);

            if(Producten.Count > 0)
            {
                returnstring += ". De volgende producten zijn gehuurd: ";
                foreach (BijkomendProduct P in Producten)
                {
                    returnstring += P.ToString() + ", ";
                }
                returnstring = returnstring.Remove(returnstring.Count() - 2);

            }
            if(Zee.Count > 0)
            {
                returnstring += ". Op de volgende locaties: ";
                foreach (string S in Zee)
                {
                    returnstring += S + ", ";
                }
                returnstring = returnstring.Remove(returnstring.Count() - 2);

            }
            returnstring += ". Van: " + Van.ToShortDateString() + " Tot: " + Tot.ToShortDateString() + " door: " + Persoon[0];
            return returnstring;
        }
    }
}
