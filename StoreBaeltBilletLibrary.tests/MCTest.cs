using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreBaeltBilletLibrary.tests
{
    [TestClass]
    public class MCTest
    {
       
        [TestMethod]
        public void Pris()
        {
            //Arrange
            var mc = new MC();

            //Act
            var pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]

        public void Køretøj()
        {
            //Arrange
            var mc = new MC();

            //Act
            string køretøj = "MC";

            //Assert
            Assert.AreSame(køretøj, mc.Køretøj());
        }
        /// <summary>
        /// Efter lang tids google søgning fandt jeg frem til at dette er nok for at en test for argumentexception kan udføres. Når testen køres testes der for at der smides en exception. Hvis det ikke er tilfældet fejler testen.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nummerpladen du har indtastet indeholder for mange cifre")]

        public void ForLangNummerPlade()
        {
            //Arrange
            var mc = new MC("cb123456", new DateTime(2018, 9, 14));
        }

        [TestMethod]

        public void NummerPlade()
        {

            //Arrange
            var mc = new MC("cd12345", new DateTime(2018, 9, 14));

            //Act
            string nummerPlade = mc.NummerPlade;

            //Assert
            Assert.AreEqual(7, nummerPlade.Length);
        }

        [TestMethod]

        public void BroBizzRabat()
        {
            //Arrange
            var mc = new MC();

            //Act
            decimal prisMedRabat = mc.BroBizz();

            //Assert
            Assert.AreEqual(118.75m, prisMedRabat);
        }

        //[TestMethod]

        //public void BroBizzRabat()
        //{
        //    //Arrange
        //    double mc1 = 125;
        //    double mc2 = 0.95;

        //    //Act
        //    double mc = mc1 * mc2;

        //    //Assert
        //    Assert.AreEqual(118.75, mc, 118.7);
        //}

    }
}
