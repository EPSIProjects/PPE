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
    public partial class ModifierProduits : Form
    {
        private MySqlConnection connection;

        public ModifierProduits()
        {
            InitializeComponent();
            PassData();
            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_fournisseur from fournisseur;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    string nom_fournisseur = Reader[0] + "";
                    comboBox1_fournisseur.Items.Add(nom_fournisseur);
                }
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
            this.Open();
            try
            {
                this.connection.Open();
                MySqlCommand cmd9 = this.connection.CreateCommand();
                cmd9.CommandText = "select nom_fournisseur from fournisseur where id_fournisseur = \"" + textBox1.Text + "\";";
                MySqlDataReader Reader3 = cmd9.ExecuteReader();
                Reader3.Read();
                string nom_four = Reader3[0] + "";
                comboBox1_fournisseur.SelectedIndex = comboBox1_fournisseur.FindStringExact(nom_four);
                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
        }

    private void PassData() // recuperation des données du produits à modifier
    {
        textBox1_id.Text = Produits.modifProd;

            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "select id_article, libelle_article, stock_article, id_fournisseur_article from article where id_article = \"" + textBox1_id.Text + "\";";
                MySqlDataReader Reader2 = cmd.ExecuteReader();

                while (Reader2.Read())
                {
                    string id = Reader2[0] + "";
                    string libelle = Reader2[1] + "";
                    string stock = Reader2[2] + "";
                    string id_fournisseur = Reader2[3] + "";

                    textBox1_id.Text = id;
                    textBox1_nom.Text = libelle;
                    textBox1_stock.Text = stock;
                    textBox1.Text = id_fournisseur;

                }
                this.connection.Close();
            }

            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }



        }

    public void Open()
        {
            string connectionString = "server=sql.franceserv.fr; database=darkmath_db2; uid=paravent; pwd=paravent1234";
            this.connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e) // valider
        {
            string id2 = textBox1_id.Text;
            string nom2 = textBox1_nom.Text;
            string stock2 = textBox1_stock.Text;
            string comboBox2 = comboBox1_fournisseur.SelectedItem.ToString(); // nom du fournisseur

            this.Open();

            this.connection.Open();

            MySqlCommand cmdFour = this.connection.CreateCommand();
            cmdFour.CommandText = "select id_fournisseur from fournisseur where nom_fournisseur=\"" + comboBox2 + "\";";
            MySqlDataReader readFour = cmdFour.ExecuteReader();
            readFour.Read();
            int stringFour = readFour.GetInt32(0);

            this.connection.Close();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "UPDATE article SET libelle_article=\"" + nom2 + "\",stock_article=\"" + stock2 + "\",id_fournisseur_article=\"" + stringFour + "\" WHERE id_article=\"" + id2 +"\";";
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée2");
            }

            
            Produits afficher = new Produits();
            afficher.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // fournisseur
        {
            
        }

        private void textBox1_nom_TextChanged(object sender, EventArgs e) // nom
        {
            this.textBox1_nom.MaxLength = 50;
            this.textBox1_nom.SelectionStart = this.textBox1_nom.Text.Length;
        }

        private void textBox1_stock_TextChanged(object sender, EventArgs e) // stock
        {
            this.textBox1_stock.MaxLength = 50;
            this.textBox1_stock.SelectionStart = this.textBox1_stock.Text.Length;
        }

        private void textBox1_id_TextChanged(object sender, EventArgs e) // id
        {
            this.textBox1_id.MaxLength = 50;
            this.textBox1_id.SelectionStart = this.textBox1_id.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e) // retour
        {
            
            Produits afficher = new Produits();
            afficher.Show();
            this.Hide();
        }

        private void ModifierProduits_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)  // autoriser que les chiffres
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            Produits afficher = new Produits();
            afficher.Show();
            this.Hide();
        }
    }
}