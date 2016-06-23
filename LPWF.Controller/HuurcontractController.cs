using LPWF.Database.Repository;
using LPWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Controller
{
    public class HuurcontractController
    {
        HuurcontractRepository HuurRepo = new HuurcontractRepository();

        public List<Huurcontract> GetAll()
        {
            return HuurRepo.FindAll();
        }
    }
}
