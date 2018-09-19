using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreBaeltBilletLibrary.tests
{
    [TestClass]
    public class BilTest
    {
    
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var bil = new Bil();

            //Act
            var pris = bil.Pris();

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]

        public void Køretøj()
        {
            //Arrange
            var bil = new Bil();

            //Act
            string køretøj = "Bil";

            //Assert
            Assert.AreSame(køretøj, bil.Køretøj());

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nummerpladen du har indtastet indeholder for mange cifre")]

        public void ForLangNummerPlade()
        {
            //Arrange
            var bil = new Bil("cb123456", new DateTime(2018, 9, 14));
        }

        [TestMethod]

        public void NummerPlade()
        {
            //Arrange
            var bil = new Bil("cd12345", new DateTime(2018, 9, 14));

            //Act
            string nummerPlade = bil.NummerPlade;

            //Assert
            Assert.AreEqual(7, nummerPlade.Length);
        }

        [TestMethod]

        public void BroBizzRabatWeekend()
        {
            //Arrange
            var bil = new Bil("cb12345", new DateTime(2018,9,16));

            //Act
            decimal prisMedRabat = bil.BroBizz();

            //Assert
            Assert.AreEqual(182.4m, prisMedRabat);
        }

        [TestMethod]

        public void BroBizzUdenRabatWeekend()
        {
            //Arrange
            var bil = new Bil("cb12345", new DateTime(2018, 9, 18));

            //Act
            decimal prisUdenRabat = bil.BroBizz();

            //Assert
            Assert.AreEqual(228m, prisUdenRabat);
        }

    }
}
