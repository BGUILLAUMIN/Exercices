using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Compte_Bancaire;

namespace Tests
{
    [TestClass]
    public class TestCompteBancaire
    {
        [TestMethod]
        public void TestDébitOrdinaire()    //Test unitaire pour le cas standard
        {
            CompteBancaire cb = new CompteBancaire(DateTime.Today, 500);
            cb.Débiter(100);
            Assert.AreEqual(400, cb.SoldeCourant); //Test la valeur à laquelle on s'attend.
        }
        [TestMethod]
        public void TestDébitAvecDécouvert()    //Test unitaire pour le cas du découvert
        {
            CompteBancaire cb = new CompteBancaire(DateTime.Today, 500);
            cb.DécouvertAutorisé = -500;
            cb.Débiter(700);
            Assert.AreEqual(-200, cb.SoldeCourant); 
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]      //Je m'attends à une exception levé.
        public void TestDébitAuDelaDécouvert()    
        {
            CompteBancaire cb = new CompteBancaire(DateTime.Today, 500);
            cb.DécouvertAutorisé = -500;
            cb.Débiter(1200);
            Assert.AreEqual(-705, cb.SoldeCourant);
        }

    }
}
