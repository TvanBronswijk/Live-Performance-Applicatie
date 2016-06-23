using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Model
{
    public class Admin
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin()
        {

        }

        public bool Login(string TryPassword)
        {
            if(TryPassword == Password)
            {
                return true;
            }
            return false;
        }
    }
}
