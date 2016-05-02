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

namespace Para_Vent
{
    public partial class AjouterFormation : Form
    {
        private MySqlConnection connection;

        public AjouterFormation()
        {
            InitializeComponent();
            TexteLeaveEntry();
            comboBox1_personnel.Items.Add("Formateur");
            comboBox1_personnel.SelectedIndex = 0;
            comboBox1_client.Items.Add("Client");
            comboBox1_client.SelectedIndex = 0;
            comboClient();
            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_personnel from personnel where etat = 0;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
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

        public void comboClient()
        {
            this.Open();
            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_client from client;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    comboBox1_client.Items.Add(Reader["nom_client"]);
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
            if (textBox1_libelle.Text == "Libelle")
            {
                textBox1_libelle.Text = "";
                textBox1_libelle.ForeColor = Color.Black;
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

            string dateRecup = dateTimePicker1.Text;
            string dateRecup2 = dateTimePicker2.Text;

            string comboBox1 = comboBox1_personnel.SelectedItem.ToString();
            string comboBoxClient = comboBox1_client.SelectedItem.ToString();

            this.Open();

            this.connection.Open();

            // recuperer l'id avec le nom
            MySqlCommand cmdPers = this.connection.CreateCommand();
            cmdPers.CommandText = "select id_personnel from personnel where nom_personnel=\"" + comboBox1 + "\";";
            MySqlDataReader readPers = cmdPers.ExecuteReader();
            readPers.Read();
            int stringPers = readPers.GetInt32(0);

            this.connection.Close();

            this.connection.Open();

            // recuperer l'id avec le nom
            MySqlCommand cmdCli = this.connection.CreateCommand();
            cmdCli.CommandText = "select id_client from client where nom_client=\"" + comboBoxClient + "\";";
            MySqlDataReader readCli = cmdCli.ExecuteReader();
            readCli.Read();
            int stringCli = readCli.GetInt32(0);

            this.connection.Close();

            try
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO formation ( libelle_formation, code_formation, id_client_formation, id_personnel_formation, date_debut_formation, date_fin_formation) VALUES ( \""
                    + libelle + "\", \"" + code + "\", \""+ stringCli + "\", \""  + stringPers + "\", \"" + dateRecup + "\", \"" + dateRecup2 + "\")";

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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formations afficher = new Formations();
            afficher.Show();
        }

        private void comboBox1_client_SelectedIndexChanged(object sender, EventArgs e) // client
        {

        }

        private void textBox1_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)  // autoriser que les chiffres
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // date debut
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) // date fin
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }
    }
}
