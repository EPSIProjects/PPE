using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_Vent
{
    public class uneFormation
    {
        private string p_libelle;
        private string p_code;
        private int p_id_client;
        private int p_id_personnel;
        private DateTime p_date_debut;
        private DateTime p_date_fin;

        public string libelle
        {
            get { return p_libelle; }
            set { p_libelle = value; }
        }
        public string code
        {
            get { return p_code; }
            set { p_code = value; }
        }
        public int id_client
        {
            get { return p_id_client; }
            set { p_id_client = value; }
        }
        public int id_personnel
        {
            get { return p_id_personnel; }
            set { p_id_personnel = value; }
        }
        public DateTime date_debut
        {
            get { return p_date_debut; }
            set { p_date_debut = value; }
        }
        public DateTime date_fin
        {
            get { return p_date_fin; }
            set { p_date_fin = value; }
        }
        public bool Terminee()
        {
            bool reponse;
            if (date_fin < DateTime.Today)
            {
                reponse = true;
            }
            else
                reponse = false;

            return reponse;
        }
    }
}
