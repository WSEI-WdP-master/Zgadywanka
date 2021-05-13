using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogikaGry;

namespace TestProjectGra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KonstruktorBezargumentowy_MinZakresNa1()
        {
            // AAA  arrange-act-assert

            // Arrange
            int oczekiwanyMinZakres = 1;

            // Act
            var gra = new Gra();

            // Assert
            Assert.AreEqual(oczekiwanyMinZakres, gra.MinZakres);
        }

        [TestMethod]
        public void KonstruktorBezargumentowy_MaxZakresNa100()
        {
            // AAA  arrange-act-assert

            // Arrange
            int oczekiwanyMaxZakres = 100;

            // Act
            var gra = new Gra();

            // Assert
            Assert.AreEqual(oczekiwanyMaxZakres, gra.MaxZakres);
        }

        [DataTestMethod]
        [DataRow(10, 50)]
        [DataRow(-10, 50)]
        [DataRow(1, 100)]
        [DataRow(int.MinValue, int.MaxValue)]
        public void KonstruktorDwuargumentowy_MinZakres_i_MaxZakres_Poprawne(int min, int max)
        {
            // AAA  arrange-act-assert

            // Arrange
            int oczekiwanyMinZakres = min;
            int oczekiwanyMaxZakres = max;

            // Act
            var gra = new Gra(min, max);

            // Assert
            Assert.AreEqual(oczekiwanyMinZakres, gra.MinZakres);
            Assert.AreEqual(oczekiwanyMaxZakres, gra.MaxZakres);
        }

        [DataTestMethod]
        [DataRow(50, 10)]
        [DataRow(50, 50)]
        [ExpectedException(typeof(ArgumentException))]
        public void KonstruktorDwuargumentowy_MinZakres_i_MaxZakres_Niepoprawne(int min, int max)
        {
            var gra = new Gra(min, max);
        }


    }
}
