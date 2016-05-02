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
    public partial class AjouterFormations : Form
    {
        private MySqlConnection connection;

        public AjouterFormations()
        {
            InitializeComponent();
            TexteLeaveEntry();
            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_personnel from personnel;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read()){
                    comboBox1_personnel.Items.Add(Reader["nom_personnel"]);
                }

                Reader.Close();
            }
            catch
            {  
                MessageBox.Show("Erreur");
            }
            this.connection.Close();
        }

        public void TexteLeaveEntry()
        {
            textBox1_code.ForeColor = Color.Gray;
            textBox1_code.Text = "Code Formation";
            this.textBox1_code.Leave += new System.EventHandler(this.textBox_code_Leave);
            this.textBox1_code.Enter += new System.EventHandler(this.textBox_code_Enter);

            textBox1_libelle.ForeColor = Color.Gray;
            textBox1_libelle.Text = "Libelle";
            this.textBox1_libelle.Leave += new System.EventHandler(this.textBox_libelle_Leave);
            this.textBox1_libelle.Enter += new System.EventHandler(this.textBox_libelle_Enter);
        }

        private void textBox_code_Leave(object sender, EventArgs e)
        {
            if (textBox1_code.Text == "")
            {
                textBox1_code.Text = "Code Formation";
                textBox1_code.ForeColor = Color.Gray;
            }
        }

        private void textBox_code_Enter(object sender, EventArgs e)
        {
            if (textBox1_code.Text == "Code Formation")
            {
                textBox1_code.Text = "";
                textBox1_code.ForeColor = Color.Black;
            }
        }

        private void textBox_libelle_Leave(object sender, EventArgs e)
        {
            if (textBox1_libelle.Text == "")
            {
                textBox1_libelle.Text = "Libelle";
                textBox1_libelle.ForeColor = Color.Gray;
            }
        }

        private void textBox_libelle_Enter(object sender, EventArgs e)
        {
            if (textBox1_code.Text == "Libelle")
            {
                textBox1_code.Text = "";
                textBox1_code.ForeColor = Color.Black;
            }
        }

        public void Open()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=para-vent; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // libelle
        {
            this.textBox1_libelle.MaxLength = 50;
            this.textBox1_libelle.SelectionStart = this.textBox1_libelle.Text.Length;

        }

        private void comboBox1_personnel_SelectedIndexChanged(object sender, EventArgs e) // combobox
        {

        }

        private void AjouterFormations_Load(object sender, EventArgs e) // code formation
        {
            this.textBox1_code.MaxLength = 50;
            this.textBox1_code.SelectionStart = this.textBox1_code.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e) // valider
        {
            string libelle = textBox1_libelle.Text;
            string code = textBox1_code.Text;

            string comboBox1 = comboBox1_personnel.SelectedItem.ToString();

            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                MessageBox.Show(cmd.ToString());

                cmd.CommandText = "INSERT INTO formation ( libelle_formation, code_formation, id_personnel_formation) VALUES ( \""
                    + libelle + "\", \"" + code + "\", \"" + comboBox1 + "\")";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Produits afficher = new Produits();
            afficher.Show();
        }
    }
}
