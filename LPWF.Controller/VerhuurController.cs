using LPWF.Database.Repository;
using LPWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Controller
{
    public class VerhuurController
    {
        HuurcontractRepository HuurRepo = new HuurcontractRepository(); 

        public void Verhuren(Huurcontract huurcontract)
        {
            huurcontract.ID = HuurRepo.GetNextID();
            HuurRepo.Create(huurcontract);
        }

        public double Berekenen(int Kano, int Zeilboot, int Motorboot, int product, int zee, double bedrag, int dagen)
        {
            double total = bedrag;
            total -= Kano * 10 * dagen;
            total -= Zeilboot * 10 * dagen;
            total -= Motorboot * 15 * dagen;
            total -= product * 1.25 * dagen;
            total -= zee * 2;
            if (total > 10)
            {
                total -= Math.Floor(total - 10) * (Zeilboot + Motorboot) * .5;
            }

            if(total > 12)
            {
                return 12;
            }
            if(total < 0)
            {
                return 0;
            }
            return total;
        }
    }
}
