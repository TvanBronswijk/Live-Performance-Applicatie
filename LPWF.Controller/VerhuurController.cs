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

        public double Berekenen()
        {

        }
    }
}
