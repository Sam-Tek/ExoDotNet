using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class ElevesTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            var eleve = new Eleves();

            string res = eleve.ToString();

            Assert.AreEqual("Lupin 18 10", res);
        }

        [TestMethod()]
        public void MoyenneTest()
        {
            var eleve = new Eleves();

            Assert.AreEqual(10, eleve.Moyenne);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidNoteException))]
        public void MoyenneInTest()
        {
            var eleve = new Eleves();
            eleve.Moyenne = -1;

        }

    }
}