using System;
using Boites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBoites
{
    [TestClass]
    public class TestBoites
    {
        [TestMethod]
        public void TestCompteur()                  //A faire en premier car le compteur compte aussi les 
                                                    //objets instancier dans la suite des tests
        {
            Boite[] Bt = new Boite[35];
            for (int i = 0; i < 35; i++)
            {
                Bt[i] = new Boite();
            }
            Assert.AreEqual(35, Boite.NbObjet);
        }

        [TestMethod]
        public void TestVolume()
        {
            Boite Bt = new Boite(10.0,20.0,30.0);         //Pour ce cas, la comparaison avec des nombres à virgule n'est pas précise
            Assert.AreEqual(6000, Bt.Volume,0.0001);       //Préconiser des decimal, on peut aussi avec la surcharge préciser un delta

        }

       
    }
}
