using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPWF.Model;
using Oracle.DataAccess.Client;

namespace LPWF.Database.Repository
{
    public class AdminRepository : Repository<Admin>
    {
        private new string Table = "\"Admin\"";

        public override void Alter(Admin entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("username", entity.Username);
                cmd.Parameters.Add("password", entity.Password);
                cmd.CommandText = $"UPDATE {Table} SET Username=:username, Password=:password WHERE ID=:id";
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }

        public override void Create(Admin entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("username", entity.Username);
                cmd.Parameters.Add("password", entity.Password);
                cmd.CommandText = $"INSERT INTO {Table} VALUES (:id, :username, :password)";
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }

        public override List<Admin> FindAll()
        {
            List<Admin> entities = new List<Admin> { };
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM {Table}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Admin entity = new Admin();
                        entity.ID = rdr.GetInt32(0);
                        entity.Username = rdr.GetString(1);
                        entity.Password = rdr.GetString(2);
                        entities.Add(entity);
                    }
                }
            }
            Db.Close();
            return entities;
        }

        public override Admin FindByID(int ID)
        {
            Admin entity = new Admin();
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM {Table} WHERE ID = {ID}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        entity.ID = rdr.GetInt32(0);
                        entity.Username = rdr.GetString(1);
                        entity.Password = rdr.GetString(2);
                    }
                }
            }
            Db.Close();
            return entity;
        }
    }
}
