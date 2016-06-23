using System;
using System.Collections.Generic;
using System.Diagnostics;
using LivePerformanceApplication.Classes;
using LivePerformanceApplication.Classes.Controllers;
using LivePerformanceApplication.Classes.SharedModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LivePerfomanceApplicationTests
{
    [TestClass]
    public class AlgemeneTests
    {
        [TestMethod]
        public void AddHuurContractTest()
        {
            HurenController ctrl = new HurenController();
            Assert.IsFalse(ctrl.AddHuurcontract("email@email.com", "naampje",
                new Huurcontract(0, DateTime.Today, DateTime.Today.AddDays(10), new List<IBoot>(), new List<Meer>(),
                    new List<Artikel>())));

        }

        [TestMethod]
        public void TestConnectionTest()
        {
            bool error = false;
            try
            {
                DatabaseManager.TestConnection();
            }
            catch (Exception)
            {
                error = true;
            }

            Assert.IsFalse(error);

        }

        [TestMethod]
        public void InlogTest()
        {
           
        }

    }
}
