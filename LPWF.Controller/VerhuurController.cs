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

        public double Berekenen(int Boot, int Motorboot, int product, int zee, double bedrag)
        {
            double total = ((bedrag - (10 * Boot) - (15 * Motorboot) - (1.25 * product) - (zee * 2)) / 1);
            if(total > 12)
            {
                return 12;
            }
            return total;
        }
    }
}
