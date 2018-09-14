using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreBaeltBilletLibrary.tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void MainProgramTest()
        {
            //Arrange
            StoreBaeltBilletLibrary.Program.Main();
            var c = StoreBaeltBilletLibrary.Program.IsRunning;

            //Act
            bool test = true;

            //Assert
            Assert.AreEqual(c, test);
        }
    }
}
