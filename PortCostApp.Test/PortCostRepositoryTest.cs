using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortCostApp.Core;
using PortCostApp.Infrastructure;

namespace PortCostApp.Test
{
    [TestClass]
    public class PortCostRepositoryTest
    {
        PortCostRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            PortCostInitializeDB db = new PortCostInitializeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new PortCostRepository();
        }

        [TestMethod]
        public void IsRepositoryInitializeWithValidNumberOfData()
        {
            var result = Repo.GetPortCost();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }

        [TestMethod]
        public void IsRepositoryAddsPortCost()
        {
            PortCost portCostInsert = new PortCost
            {
                VesselCode = "AUEC",
                PortCode = "BEZEE",
                PortCostCategory = "CostCategory3",
                PortCostSubCategory = "Subcategory3",
                Cost = 300
            };
            Repo.Add(portCostInsert);
            var result = Repo.GetPortCost();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(3, numberOfRecords);
        }
    }
}
