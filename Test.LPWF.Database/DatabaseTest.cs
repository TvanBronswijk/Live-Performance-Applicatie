using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LPWF.Model;
using LPWF.Database.Repository;

namespace Test.LPWF.Database
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void HuurcontractRepositoryTest()
        {
            Huurcontract Huur = new Huurcontract();
            HuurcontractRepository HuurRepo = new HuurcontractRepository();
            BootRepository BootRepo = new BootRepository();
            BijkomendProductRepository ProductRepo = new BijkomendProductRepository();

            Huur.ID = HuurRepo.GetNextID();
            Huur.Boten.Add(BootRepo.FindAll()[0]);
            Huur.Producten.Add(ProductRepo.FindAll()[0]);
            Huur.Persoon[0] = "Jan";
            Huur.Persoon[1] = "dude";
            Huur.Meer = 1;
            Huur.Zee.Add("Waddenzee");
            Huur.Tot = new DateTime(1995, 12, 1);
            Huur.Van = new DateTime(1994, 12, 1);

            HuurRepo.Create(Huur);
            Assert.AreEqual(Huur.ID, (HuurRepo.FindAll().Find(y => y.ID == Huur.ID)).ID);
            Assert.AreEqual(Huur.Boten[0].ID, (HuurRepo.FindAll().Find(y => y.ID == Huur.ID)).Boten[0].ID);
            Assert.AreEqual(Huur.Producten[0].ID, (HuurRepo.FindAll().Find(y => y.ID == Huur.ID)).Producten[0].ID);
            Assert.AreEqual(Huur.Persoon[0], (HuurRepo.FindAll().Find(y => y.ID == Huur.ID)).Persoon[0]);
            Assert.AreEqual(Huur.Van, (HuurRepo.FindAll().Find(y => y.ID == Huur.ID)).Van);
        }

        [TestMethod]
        public void ProductRepositoryTest()
        {
            BijkomendProductRepository ProductRepo = new BijkomendProductRepository();

            Assert.AreEqual("Reddingsvest", ProductRepo.FindAll().Find(y => y.ID == 1).Naam);
        } 

        [TestMethod]
        public void BootRepositoryTest()
        {
            BootRepository BootRepo = new BootRepository();

            Assert.AreEqual("De Kameroen", BootRepo.FindAll().Find(y => y.ID == 1).Naam);
        }
    }
}
