using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_Vent
{
    public class unProduit
    {
        private string p_libelle;
        private int p_stock;
        private int p_id_fournisseur; 

        public string libelle
        {
            get { return p_libelle; }
            set { p_libelle = value;}
        }
        public int stock
        {
            get { return p_stock; }
            set { p_stock = value; }
        }
        public int fournisseur
        {
            get { return p_id_fournisseur; }
            set { p_id_fournisseur = value; }
        }

        public bool StockVide()
        {
            bool reponse;

            if (p_stock == 0) {
                reponse = true;
            }
            else
            {
                reponse = false;
            }
            return (reponse);
        }
    }
}


