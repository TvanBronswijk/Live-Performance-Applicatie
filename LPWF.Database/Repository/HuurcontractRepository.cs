using LPWF.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPWF.Database.Repository
{
    public class HuurcontractRepository : Repository<Huurcontract>
    {
        private new string Table = "Huurcontract";

        public override void Alter(Huurcontract entity)
        {
            throw new NotImplementedException();
        }

        public override void Create(Huurcontract entity)
        {
            int PersoonID = GetPersoonID();
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", PersoonID);
                cmd.Parameters.Add("naam", entity.Persoon[0]);
                cmd.Parameters.Add("email", entity.Persoon[1]);
                cmd.CommandText = $"INSERT INTO Persoon VALUES (:id, :naam, :email)";
                cmd.ExecuteNonQuery();
            }
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.Parameters.Add("id", entity.ID);
                cmd.Parameters.Add("persoonid", PersoonID);
                cmd.Parameters.Add("meernr", entity.Meer);
                cmd.CommandText = $"INSERT INTO {Table} VALUES (:id, :persoonid, \'{entity.Van.ToString("dd-MMM-yy")}\', \'{entity.Tot.ToString("dd-MMM-yy")}\', :meernr)";
                cmd.ExecuteNonQuery();
            }
            foreach(Boot B in entity.Boten)
            {
                using (OracleCommand cmd = Db.CreateCommand())
                {
                    cmd.Parameters.Add("id", entity.ID);
                    cmd.Parameters.Add("bootid", B.ID);
                    cmd.CommandText = $"INSERT INTO BootHuurcontract VALUES (:id, :bootid)";
                    cmd.ExecuteNonQuery();
                }
            }
            foreach (BijkomendProduct P in entity.Producten)
            {
                using (OracleCommand cmd = Db.CreateCommand())
                {
                    cmd.Parameters.Add("id", entity.ID);
                    cmd.Parameters.Add("productid", P.ID);
                    cmd.Parameters.Add("aantal", P.Aantal);
                    cmd.CommandText = $"INSERT INTO HuurProduct VALUES (:id, :productid, :aantal)";
                    cmd.ExecuteNonQuery();
                }
            }
            foreach (string S in entity.Zee)
            {
                int zeeid = 0;
                using (OracleCommand cmd = Db.CreateCommand())
                {
                    cmd.Parameters.Add("naam", S);
                    cmd.CommandText = $"SELECT ID FROM Zee WHERE naam = :naam";

                    using (OracleDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            zeeid = rdr.GetInt32(0);
                        }
                    }
                }
                using (OracleCommand cmd = Db.CreateCommand())
                {
                    cmd.Parameters.Add("id", entity.ID);
                    cmd.Parameters.Add("zeeid", zeeid);
                    cmd.CommandText = $"INSERT INTO Huurzee VALUES (:id, :zeeid)";
                    cmd.ExecuteNonQuery();
                }
            }
            Db.Close();
        }

        private int GetPersoonID()
        {
            int ID = 0;
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT MAX(ID) FROM Persoon";

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

        public override List<Huurcontract> FindAll()
        {
            BootRepository BootRepo = new BootRepository();
            BijkomendProductRepository ProductRepo = new BijkomendProductRepository();

            List<Huurcontract> entities = new List<Huurcontract> { };
            Db.Open();
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT H.ID, H.Van, H.Tot, H.MeerNr, P.Naam, P.Email FROM {Table} H INNER JOIN Persoon P ON H.PersoonID = P.ID";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Huurcontract entity = new Huurcontract();
                        entity.ID = rdr.GetInt32(0);
                        entity.Van = rdr.GetDateTime(1);
                        entity.Tot = rdr.GetDateTime(2);
                        entity.Meer = rdr.GetInt32(3);
                        entity.Persoon[0] = rdr.GetString(4);
                        entity.Persoon[1] = rdr.GetString(5);
                        entities.Add(entity);
                    }
                }
            }
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM BootHuurcontract";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        entities.Find(y => y.ID == rdr.GetInt32(0)).Boten.Add(BootRepo.FindByID(rdr.GetInt32(1)));
                    }
                }
            }
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT * FROM HuurProduct";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        BijkomendProduct Product = ProductRepo.FindByID(rdr.GetInt32(1));
                        Product.Aantal = rdr.GetInt32(2);
                        entities.Find(y => y.ID == rdr.GetInt32(0)).Producten.Add(Product);
                    }
                }
            }
            using (OracleCommand cmd = Db.CreateCommand())
            {
                cmd.CommandText = $"SELECT HZ.HuurcontractID, Z.naam FROM Zee Z INNER JOIN HuurZee HZ ON HZ.ZeeID = Z.ID";

                using (OracleDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        entities.Find(y => y.ID == rdr.GetInt32(0)).Zee.Add(rdr.GetString(1));
                    }
                }
            }

            Db.Close();
            return entities;
        }

        public override Huurcontract FindByID(int ID)
        {
            throw new NotImplementedException();
        }

        public override int GetNextID()
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
