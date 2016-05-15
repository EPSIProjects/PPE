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
    public partial class ModifierFormation : Form
    {
        private MySqlConnection connection;

        public ModifierFormation()
        {
            InitializeComponent();
            PassData();
            this.Open();

            try // tout les nom_personnel dans la combobox
            {
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = ("select nom_personnel from personnel;");
                MySqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    comboBox1_personnel.Items.Add(Reader["nom_personnel"]);
                }
                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur1");
            }



           this.Open();

            try // selectionner le nom avec l'id
            {
                this.connection.Open();
                MySqlCommand cmd5 = this.connection.CreateCommand();
                cmd5.CommandText = "select nom_personnel from personnel where id_personnel= \"" + textBox1.Text + "\";";
                MySqlDataReader Reader5 = cmd5.ExecuteReader();
                Reader5.Read();
                string nom_perso = Reader5[0] +"";
                comboBox1_personnel.SelectedIndex = comboBox1_personnel.FindStringExact(nom_perso);

                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
        }

        private void PassData() // recuperation des données de la formation à modifier
        {
            textBox1_id.Text = Formations.modifForm;

            this.Open();

            try
            {
                this.connection.Open();

                MySqlCommand cmd2 = this.connection.CreateCommand();
                cmd2.CommandText = "select id_formation, libelle_formation, id_personnel_formation, code_formation, date_debut_formation, date_fin_formation from formation where id_formation = \"" + textBox1_id.Text + "\";";
                MySqlDataReader Reader2 = cmd2.ExecuteReader();

                while (Reader2.Read())
                {
                    string id = Reader2[0] + "";
                    string libelle = Reader2[1] + "";
                    string code = Reader2[3] + "";
                    string id_personnel = Reader2[2] + "";

                    string dateRecup = Reader2[4]+"";
                    string dateRecup2 = Reader2[5]+"";

                    textBox1_id.Text = id;
                    textBox1_libelle.Text = libelle;
                    textBox2_code.Text = code;
                    textBox1.Text=id_personnel;
                    dateTimePicker1.Text = dateRecup;
                    dateTimePicker2.Text = dateRecup2;
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

        private void ModifierFormation_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) // retour
        {
            
            Formations afficher = new Formations();
            afficher.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_libelle_TextChanged(object sender, EventArgs e) // libelle
        {

        }

        private void textBox2_code_TextChanged(object sender, EventArgs e) // code
        {

        }

        private void comboBox1_personnel_SelectedIndexChanged(object sender, EventArgs e) // combobox
        {

        }

        private void button1_Click(object sender, EventArgs e) // valider
        {
            string id2 = textBox1_id.Text;
            string nom2 = textBox1_libelle.Text;
            string code = textBox2_code.Text;
            string comboBox2 = comboBox1_personnel.SelectedItem.ToString(); // personnel

            string dateRecup = dateTimePicker1.Text; // date debut
            string dateRecup2 = dateTimePicker2.Text; // date fin

            this.Open();

            this.connection.Open();

            MySqlCommand cmdPers = this.connection.CreateCommand();
            cmdPers.CommandText = "select id_personnel from personnel where nom_personnel=\"" + comboBox2 + "\";";
            MySqlDataReader readPers = cmdPers.ExecuteReader();
            readPers.Read();
            int stringPers = readPers.GetInt32(0);

            this.connection.Close();

            try
            {
                this.connection.Open();

                MySqlCommand cmd3 = this.connection.CreateCommand();
                cmd3.CommandText = "UPDATE formation SET libelle_formation=\"" + nom2 + "\",code_formation=\"" + code + "\",id_personnel_formation=\"" + stringPers + "\",date_debut_formation=\"" + dateRecup + "\",date_fin_formation=\"" + dateRecup2 + "\" WHERE id_formation=\"" + id2 + "\";";
                cmd3.ExecuteNonQuery();
                this.connection.Close();
            }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée2");
            }

            
            Formations afficher = new Formations();
            afficher.Show();
            this.Hide();
        }

        private void textBox2_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)  // autoriser que les chiffres
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
