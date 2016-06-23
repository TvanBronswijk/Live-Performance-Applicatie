using LPWF.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Database.Repository
{
    public class BijkomendProductRepository : Repository<BijkomendProduct>
    {
        private new string Table = "BijkomendProduct";

        public override void Alter(BijkomendProduct entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("naam", entity.Naam);
                cmd.CommandText = $"UPDATE {Table} SET Naam=:naam WHERE ID=:id";
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }
        public override void Create(BijkomendProduct entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("naam", entity.Naam);
                cmd.CommandText = $"INSERT INTO {Table} VALUES (:id, :naam)";
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }

        public override List<BijkomendProduct> FindAll()
        {
            List<BijkomendProduct> entities = new List<BijkomendProduct> { };
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT ID, Naam FROM {Table}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        BijkomendProduct entity = new BijkomendProduct();
                        entity.ID = rdr.GetInt32(0);
                        entity.Naam = rdr.GetString(1);
                        entities.Add(entity);
                    }
                }
            }
            Db.Close();
            return entities;
        }

        public override BijkomendProduct FindByID(int ID)
        {
            BijkomendProduct entity = new BijkomendProduct();
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT ID, Naam FROM {Table} WHERE ID = {ID}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        entity.ID = rdr.GetInt32(0);
                        entity.Naam = rdr.GetString(1);
                    }
                }
            }
            Db.Close();
            return entity;
        }
    }
}
