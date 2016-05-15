using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Para_Vent;

namespace Para_Vent
{
    
    public partial class Personnel : Form
    {

        public static string PassingID;

        private MySqlConnection connection;
        List<string> _items = new List<string>(); // On initialise la variable qui remplira la ListBox
        public Personnel()
        {
            InitializeComponent();
            listView1_Load(null, null);
            button_activer.Enabled = false; // le rend non clickable
            button_desactiver.Enabled = false;
            button_modifier.Enabled = false;

        }



        /// <summary>
        /// Ouvre la connexion au serveur
        /// </summary>
        public void Open() //ouverture connexion
        {
            string connectionString = "server=sql.franceserv.fr; database=darkmath_db2; uid=paravent; pwd=paravent1234";
            this.connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Récupère les données de la table personnel dans la base de données
        /// et les affiche dans la listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;

            this.Open(); //Initialisation de la connexion
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // La requête SQL
                cmd.CommandText = "SELECT COUNT(*) FROM personnel";
                //On récupére le résultat sous la forme d'un entier "rows"
                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                int rowsINI = rows;
                //On ferme la premier connexion
                this.connection.Close();
                //Tant qu'il y a des elements ...
                while (rows > 0)
                {
                    int rowsACTU = (rowsINI - rows);
                    this.connection.Open();
                    // Création d'une commande SQL en fonction de l'objet connection
                    MySqlCommand cmd2 = this.connection.CreateCommand();
                    // Requête SQL
                    cmd2.CommandText = "SELECT nom_personnel, prenom_personnel, ville_personnel, adresse_ligne1_personnel, fonction_personnel, id_personnel, etat, affectation_personnel FROM personnel WHERE id_personnel=\"" + rows + "\"";
                    //On interprête le resultat sous la forme d'une variable de type MySqlDataReader
                    MySqlDataReader rdr = cmd2.ExecuteReader();
                    //On lis cette variable et on l'affiche
                    
                    while (rdr.Read())
                    {
                        string item = rdr[0] + "";
                        string item2 = rdr[1] + "";
                        string item3 = rdr[2] + "";
                        string item4 = rdr[3] + "";

                        string fonct = rdr[4] + "";

                        string id = rdr[5] + "";
                        string etat = rdr[6] + "";
                        string affectation = rdr[7] + "";

                        System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            item,
            item2,
            item3,
            item4,
            affectation,
            id,
            etat}, -1);
                        this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
                        if (etat=="1") {
                        listViewItem1.ForeColor = Color.Red;
                        }


                        if (fonct=="RSI" || fonct == "GERANT" || fonct == "DDS" || fonct == "DDM" || fonct == "DRH" || fonct == "GDF" || fonct == "RSC" || fonct == "SC" || fonct == "C" || fonct == "F")  {
                            listView1.Items[rowsACTU].Group = listView1.Groups[3];
                            if (fonct == "F")
                            {
                                listView1.Items[rowsACTU].Group = listView1.Groups[1];
                            }
                            if (fonct == "C")
                            {
                                listView1.Items[rowsACTU].Group = listView1.Groups[2];
                            }
                        }
                        else {
                            listView1.Items[rowsACTU].Group = listView1.Groups[0];
                        }
                    }
                    this.connection.Close(); // on ferme la connexion
                    rows--; // et on désincrémente Rows de 1 afin de passer à la donnée suivante
                }



            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Permet d'afficher les boutons "activer" et "désactiver"
        /// en fonction de l'état actuel d'une personne
        /// lorsque l'on clique sur la personne dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            ListView.SelectedListViewItemCollection select = this.listView1.SelectedItems;
            if (select.Count > 0) { 

            string etatstr = "null";
            button_modifier.Enabled = true;
            etatstr = listView1.SelectedItems[0].SubItems[6].Text;
            int etat = Int32.Parse(etatstr);
            if (etat == 1)
            {
                button_activer.Enabled = true; // le rend non clickable
                button_desactiver.Enabled = false;
            }
            else
            {
                button_activer.Enabled = false; // le rend non clickable
                button_desactiver.Enabled = true;
            }
        }
        }

        private void Personnel_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton Retour
        /// Renvoie l'utilisateur à l'accueil de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click_3(object sender, EventArgs e)
        {
            
            Accueil afficher = new Accueil();
            afficher.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton permettant d'ajouter une personne dans
        /// la liste du persoonel de l'entreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            
            AjouterPersonnel afficher = new AjouterPersonnel();
            afficher.Show();
            this.Hide();
        }

        /// <summary>
        /// Bouton permettant de modifier les informations personnelles
        /// d'une personne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            PassingID = listView1.SelectedItems[0].SubItems[5].Text;
            
            ModifierPersonnel afficher = new ModifierPersonnel();
            afficher.Show();
            this.Hide();
        }

        /// <summary>
        /// Bouton permettant d'activer une personne
        /// présente dans la liste du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_activer_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].SubItems[5].Text;
            textBox_id.Text = id;
            this.Open(); //Initialisation de la connexion
            try
            {
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd3 = this.connection.CreateCommand();
                // Requête SQL
                cmd3.CommandText = "UPDATE personnel SET etat=\"0\" WHERE id_personnel=\"" + id + "\"";
                cmd3.ExecuteNonQuery();
                this.connection.Close(); // on ferme la connexion
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
            
            Personnel afficher = new Personnel();
            afficher.Show();
            this.Hide();
        }

        /// <summary>
        /// Bouton permettant de désactiver une personne
        /// présente dans la liste du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_desactiver_Click(object sender, EventArgs e)
        {
            String id = listView1.SelectedItems[0].SubItems[5].Text;

            this.Open(); //Initialisation de la connexion
            try
            {
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd4 = this.connection.CreateCommand();
                // Requête SQL
                cmd4.CommandText = "UPDATE personnel SET etat=\"1\" WHERE id_personnel=\"" + id + "\"";
                cmd4.ExecuteNonQuery();
                this.connection.Close(); // on ferme la connexion
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }

            
            Personnel afficher = new Personnel();
            afficher.Show();
            this.Hide();
        }

        public void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Permet de faire une recherche dans la liste du personnel
        /// et affiche les résultats instantanément
        /// Le résultat sera basé sur le nom des personnes recherchées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(searchBox.Text.ToLower()))
                    {

                    }
                    else {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else {
                listView1.Items.Clear();
                listView1_Load(null, null);

            }

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {

        }
    }
    
}
