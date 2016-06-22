using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPWF.Model;

namespace LPWF.Database.Repository
{
    public class AdminRepository : Repository<Admin>
    {
        public override void Alter(Admin entity)
        {
            throw new NotImplementedException();
        }

        public override void Create(Admin entity)
        {
            throw new NotImplementedException();
        }

        public override List<Admin> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Admin FindByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
