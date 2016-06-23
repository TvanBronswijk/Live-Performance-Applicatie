using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace LPWF.Database.Repository
{
    public abstract class Repository<T>
    {
        private string LocalDB = "DATA SOURCE=Localhost;USER ID=SYSTEM;PASSWORD=Oracle123";
        private string AthenaDB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));User ID=dbi294604;PASSWORD=Passcode123;";
        protected string Table = "";

        protected OracleConnection Db;
        public Repository()
        {
            Db = new OracleConnection(AthenaDB);
        }

        public abstract void Alter(T entity);

        public abstract void Create(T entity);

        public virtual void Delete(int ID)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", ID.ToString());
                cmd.CommandText = $"DELETE FROM {Table} WHERE ID = :id";
                cmd.ExecuteNonQuery();
            }
            Db.Close();

        }

        public abstract List<T> FindAll();

        public abstract T FindByID(int ID);

        public virtual int GetNextID()
        {
            int ID = 0;
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT MAX(ID) FROM {Table}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        ID = rdr.GetInt32(0);
                    }
                }
            }
            Db.Close();
            return ID + 1;
        }
    }
}
