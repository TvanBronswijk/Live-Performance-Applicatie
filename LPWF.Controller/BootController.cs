using LPWF.Database.Repository;
using LPWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Controller
{
    public class BootController
    {
        BootRepository BootRepo = new BootRepository();

        public List<Boot> GetAll()
        {
            return BootRepo.FindAll();
        }
    }
}
