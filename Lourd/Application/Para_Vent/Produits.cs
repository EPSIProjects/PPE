using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Para_Vent
{
    public partial class Produits : Form
    {
        public static string modifProd;

        private MySqlConnection connection;
        // liste de produits
        List<string> prods = new List<string>();

        public Produits()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;

            this.Open();

            try
            {
            
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT *, nom_fournisseur, tel_fournisseur from article, fournisseur where id_fournisseur_article = id_fournisseur order by libelle_article asc";


                this.connection.Open();

                MySqlDataReader listprod = cmd.ExecuteReader();
                    

                while (listprod.Read())
                {
                    string id = listprod[0] + ""; // id produit
                    string libelle = listprod[1] + ""; //libelle produit
                    string stock = listprod[2] + ""; // stock produit
                    string fournisseur = listprod[5] + ""; // fournisseur
                    string telfournisseur = listprod[6] + ""; // tel fournisseur

                    System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
        id, libelle, stock, fournisseur, telfournisseur}, -1);
                    this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
        listViewItem1});
                }
                // Fermeture de la connexion
                this.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
        }

        private void Produits_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Open() //ouverture connexion
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=para-vent; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        private void Neufs_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection select = this.listView1.SelectedItems;
            if (select.Count > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil afficher = new Accueil();
            afficher.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // ajouter
        {
            this.Hide();
            AjouterProduits afficher = new AjouterProduits();
            afficher.Show();
        }

        private void button1_Click(object sender, EventArgs e) // supprimer
        {
            this.Open(); //Initialisation de la connexion

            string idSup = listView1.SelectedItems[0].Text;

            try
            {
                this.connection.Open();
                MySqlCommand cmd2 = this.connection.CreateCommand();

                cmd2.CommandText = "delete FROM article WHERE id_article = \"" + idSup + "\"";
                cmd2.ExecuteNonQuery();

                

                this.connection.Close(); // on ferme la connexion
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }

            this.Hide();
            Produits afficher = new Produits();
            afficher.Show();
        }

        private void button2_Click(object sender, EventArgs e) // modifier
        {
            modifProd = listView1.SelectedItems[0].SubItems[0].Text;
            this.Hide();
            ModifierProduits afficher = new ModifierProduits();
            afficher.Show();
        }
    }
}