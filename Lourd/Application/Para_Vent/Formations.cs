using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_Vent
{
    public partial class Formations : Form
    {
        private MySqlConnection connection;

        public static string modifForm;
        
        public Formations()
        {
            InitializeComponent();
            button3.Enabled = false;
            button2.Enabled = false;
            this.Open();

            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * from formation";
                MySqlDataReader listprod = cmd.ExecuteReader();
                while (listprod.Read())
                {
                    string id = listprod[0] + "";
                    string libelle = listprod[1] + "";
                    string code = listprod[2] + "";
                    string dateD = listprod[5] + "";
                    string dateF = listprod[6] + "";
                    System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {id, libelle, code, dateD, dateF}, -1);
                    this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {listViewItem1});
                }

                this.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion à la base de donnée2");
            }
        }
        /// <summary>
        /// Ouvre la connexion au serveur
        /// </summary>
        public void Open()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=para-vent; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil afficher = new Accueil();
            afficher.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection select = this.listView1.SelectedItems;
            if (select.Count > 0)
            {
                button3.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Supprime une formation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Open();

            string idSup = listView1.SelectedItems[0].Text;

            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "delete FROM formation WHERE id_formation = \"" + idSup + "\"";
                cmd.ExecuteNonQuery();

                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }

            this.Hide();
            Formations afficher = new Formations();
            afficher.Show();
        }

        /// <summary>
        /// Ajoute une formation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterFormation afficher = new AjouterFormation();
            afficher.Show();
        }

        /// <summary>
        /// Modifie une formation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            modifForm = listView1.SelectedItems[0].SubItems[0].Text;
            this.Hide();
            ModifierFormation afficher = new ModifierFormation();
            afficher.Show();
        }
    }
}
