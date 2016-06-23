using LPWF.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Database.Repository
{
    public class BootRepository : Repository<Boot>
    {
        private new string Table = "Boot";

        public override void Alter(Boot entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("naam", entity.Naam);
                cmd.Parameters.Add("boottype", (int)entity.BootType);
                if (entity is MotorBoot)
                {
                    cmd.Parameters.Add("tankinhoud", ((MotorBoot)entity).TankInhoud);
                    cmd.CommandText = $"UPDATE {Table} SET Naam=:naam BootType=:boottype TankInhoud=:tankinhoud WHERE ID=:id";
                }
                else
                {
                    cmd.CommandText = $"UPDATE {Table} SET Naam=:naam BootType=:boottype WHERE ID=:id";
                }
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }

        public override void Create(Boot entity)
        {
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("naam", entity.Naam);
                cmd.Parameters.Add("boottype", (int)entity.BootType);
                if (entity is MotorBoot)
                {
                    cmd.Parameters.Add("tankinhoud", ((MotorBoot)entity).TankInhoud);
                    cmd.CommandText = $"INSERT INTO {Table} VALUES(:id, :naam, :boottype, :tankinhoud)";
                }
                else
                {
                    cmd.CommandText = $"INSERT INTO {Table} VALUES(:id, :naam, :boottype, null)";
                }
                cmd.ExecuteNonQuery();
            }
            Db.Close();
        }

        public override List<Boot> FindAll()
        {
            List<Boot> entities = new List<Boot> { };
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM {Table}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Boot entity;
                        if(rdr.GetValue(3) is DBNull)
                        {
                            entity = new Boot();
                        }
                        else
                        {
                            entity = new MotorBoot();
                            ((MotorBoot)entity).TankInhoud = rdr.GetInt32(3);
                        }

                        entity.ID = rdr.GetInt32(0);
                        entity.BootType = (Boot.Type)rdr.GetInt32(1);
                        entity.Naam = rdr.GetString(2);
                        entities.Add(entity);
                    }
                }
            }
            Db.Close();
            return entities;
        }

        public override Boot FindByID(int ID)
        {
            Boot entity = new Boot();
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM {Table} WHERE ID = {ID}";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {

                        if (rdr.GetValue(3) is DBNull)
                        {
                            entity = new Boot();
                        }
                        else
                        {
                            entity = new MotorBoot();
                            ((MotorBoot)entity).TankInhoud = rdr.GetInt32(3);
                        }

                        entity.ID = rdr.GetInt32(0);
                        entity.BootType = (Boot.Type)rdr.GetInt32(1);
                        entity.Naam = rdr.GetString(2);
                    }
                }
            }
            Db.Close();
            return entity;
        }
    }
}
