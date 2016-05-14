using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Para_Vent;

namespace Para_Vent___TestUnitaire
{
    [TestClass]
    public class TestUnitaire
    {
        /// <summary>
        /// Retourne vrai quand le stock d'un produit est vide
        /// </summary>
        [TestMethod]
        public void QuandLeStockDunProduitEstEpuise()
        {
            unProduit p = new unProduit();
            p.libelle = "casquette";
            p.stock = 0;
            p.fournisseur = 2;
            Assert.IsTrue(p.StockVide());
        }

        /// <summary>
        /// Retourne vrai quand une formation est passée
        /// </summary>
        [TestMethod]
        public void QuandUneFormationEstPassee()
        {
            uneFormation f = new uneFormation();
            f.code = "FOPAD15";
            f.date_debut = new DateTime(2015,12,13);
            f.date_fin = new DateTime(2015, 12, 18);
            f.id_client = 1;
            f.id_personnel = 2;
            f.libelle = "TestFormation";

            Assert.IsTrue(f.Terminee());
        }
    }
}
