using LPWF.Database.Repository;
using LPWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Controller
{
    public class BijkomendProductController
    {
        BijkomendProductRepository BPRepo = new BijkomendProductRepository();

        public List<BijkomendProduct> GetAll()
        {
            return BPRepo.FindAll();
        }
    }
}
