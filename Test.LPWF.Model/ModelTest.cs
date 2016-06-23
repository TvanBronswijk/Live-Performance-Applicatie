using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LPWF.Model;

namespace Test.LPWF.Model
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void MotorbootTest()
        {
            MotorBoot mboot = new MotorBoot();
            mboot.TankInhoud = 100;
            Assert.AreEqual(1500, mboot.ActieRadius);
        }

        [TestMethod]
        public void AdminLoginTest()
        {
            Admin admin = new Admin();
            admin.Password = "ww";
            Assert.AreEqual(true, admin.Login("ww"));
            Assert.AreEqual(false, admin.Login("123"));
        }
    }
}
