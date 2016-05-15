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
    public partial class AjouterProduits : Form
    {
        private MySqlConnection connection;

        public AjouterProduits()
        {
            InitializeComponent();
            TexteLeaveEntry();
            comboBox1_fournisseur.SelectedIndex = 0;
            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_fournisseur from fournisseur;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    comboBox1_fournisseur.Items.Add(Reader["nom_fournisseur"]);
                }
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
        }

        public void TexteLeaveEntry()
        {
            textBox2_stock.ForeColor = Color.Gray;
            textBox2_stock.Text = "Stock";
            this.textBox2_stock.Leave += new System.EventHandler(this.textBox2_stock_Leave);
            this.textBox2_stock.Enter += new System.EventHandler(this.textBox2_stock_Enter);

            textBox_nom.ForeColor = Color.Gray;
            textBox_nom.Text = "Libelle";
            this.textBox_nom.Leave += new System.EventHandler(this.textBox_nom_Leave);
            this.textBox_nom.Enter += new System.EventHandler(this.textBox_nom_Enter);
        }

        public void Open()
        {

            string connectionString = "SERVER=paravent127@gmail.com; DATABASE=u974738375_para; UID=u974738375_para; PASSWORD=BTSPPE@127";
            this.connection = new MySqlConnection(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // libelle
        {
            this.textBox_nom.MaxLength = 50;
            this.textBox_nom.SelectionStart = this.textBox_nom.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // stock
        {
            this.textBox2_stock.MaxLength = 50;
            this.textBox2_stock.SelectionStart = this.textBox2_stock.Text.Length;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // fournisseur
        {

        }

        private void button1_Click(object sender, EventArgs e) // valider l'ajout
        {
            string comboBox1sais = comboBox1_fournisseur.SelectedItem.ToString();
            int idfournisseur = 0;
            this.Open();
            try
            {
                this.connection.Open();

                MySqlCommand cmd6 = this.connection.CreateCommand();
                cmd6.CommandText = ("select id_fournisseur from fournisseur where nom_fournisseur=\"" + comboBox1sais + "\";");
                MySqlDataReader Reader = cmd6.ExecuteReader();

                while (Reader.Read())
                {
                    int id_four  = Convert.ToInt32(Reader["id_fournisseur"]);
                    idfournisseur = id_four;

                }
                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur");
            }

        if (comboBox1sais != "Fournisseur")
        {
            string nom = textBox_nom.Text;
            string stock = textBox2_stock.Text;

            this.Open();

                try
                {
                    this.connection.Open();

                    MySqlCommand cmd3 = this.connection.CreateCommand();

                    cmd3.CommandText = "INSERT INTO article (libelle_article, stock_article, id_fournisseur_article) VALUES ( \""
                        + nom + "\", \"" + stock + "\", \"" + idfournisseur + "\")";

                    cmd3.ExecuteNonQuery();
                    this.connection.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur de connexion à la base de donnée");
                }
                this.Hide();
                Produits afficher = new Produits();
                afficher.Show();

            }              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produits afficher = new Produits();
            afficher.Show();
        }

        private void textBox2_stock_Enter(object sender, EventArgs e)
        {
            if (textBox2_stock.Text == "Stock")
            {
                textBox2_stock.Text = "";
                textBox2_stock.ForeColor = Color.Black;
            }
        }

        private void textBox2_stock_Leave(object sender, EventArgs e)
        {
            if (textBox2_stock.Text == "")
            {
                textBox2_stock.Text = "Stock";
                textBox2_stock.ForeColor = Color.Gray;
            }
        }

        private void textBox_nom_Enter(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "Libelle")
            {
                textBox_nom.Text = "";
                textBox_nom.ForeColor = Color.Black;
            }
        }

        private void textBox_nom_Leave(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "")
            {
                textBox_nom.Text = "Libelle";
                textBox_nom.ForeColor = Color.Gray;
            }
        }

        private void textBox2_stock_KeyPress(object sender, KeyPressEventArgs e) 
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)  // autoriser que les chiffres
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produits afficher = new Produits();
            afficher.Show();
        }
    }
}
