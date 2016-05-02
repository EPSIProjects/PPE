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
    public partial class ModifierPersonnel : Form
    {

        private MySqlConnection connection;
        public ModifierPersonnel()
        {
            InitializeComponent();
            PassData();
        }

        private void PassData()
        {
            textBox_id.Text = Personnel.PassingID;
            AutoRempl();
        }
        private void AutoRempl ()
        {
            this.Open(); //Initialisation de la connexion
            try
            {
                    this.connection.Open();
                    // Création d'une commande SQL en fonction de l'objet connection
                    MySqlCommand cmd5 = this.connection.CreateCommand();
                    // Requête SQL
                    cmd5.CommandText = "SELECT * FROM personnel WHERE id_personnel=\"" + textBox_id.Text + "\"";
                    //On interprête le resultat sous la forme d'une variable de type MySqlDataReader
                    MySqlDataReader rdr = cmd5.ExecuteReader();
                    //On lis cette variable et on l'affiche
                    while (rdr.Read())
                    {
                        string idbdd = rdr[0] + "";
                        string nombdd = rdr[1] + "";
                        string prenombdd = rdr[2] + "";
                        string fonctionbdd = rdr[3] + "";
                        string telephonebdd = rdr[4] + "";
                        string adressebdd = rdr[5] + "";
                        string codepersobdd = rdr[6] + "";
                        string affectationbdd = rdr[7] + "";
                        string adresse2bdd = rdr[8] + "";
                        string codepostalbdd = rdr[9] + "";
                        string villebdd = rdr[10] + "";
                        string mdpbdd = rdr[11] + "";
                        string idtbdd = rdr[12] + "";
                        textBox_nom.Text = nombdd;
                        textBox_prenom.Text = prenombdd;
                        textBox_adresse2.Text = adresse2bdd;

                    if (adresse2bdd=="") { 
                        textBox_adresse2.ForeColor = Color.Gray;
                        textBox_adresse2.Text = "Adresse ligne 2";
                        this.textBox_adresse2.Leave += new System.EventHandler(this.textBox_adresse2_Leave);
                        this.textBox_adresse2.Enter += new System.EventHandler(this.textBox_adresse2_Enter);
                    }
                        textBox_adresse.Text = adressebdd;
                        textBox8.Text = fonctionbdd;
                        textBox_telephone.Text = telephonebdd;
                        textBox10.Text = codepersobdd;
                        textBox_ville.Text = villebdd;
                        textBox_codepostal.Text = codepostalbdd;
                        textBox11.Text = mdpbdd;
                        textBox12.Text = idtbdd;
                        comboBox1.SelectedItem = affectationbdd;
                }
                    this.connection.Close(); // on ferme la connexion
                }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
        }
        public void Open() //ouverture connexion
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=para-vent; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personnel afficher = new Personnel();
            afficher.Show();
        }
        private void titre_Click(object sender, EventArgs e)
        {

        }
        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            this.textBox_nom.MaxLength = 50;
            this.textBox_nom.Text = this.textBox_nom.Text.ToUpper();
            this.textBox_nom.SelectionStart = this.textBox_nom.Text.Length;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            this.textBox_adresse2.MaxLength = 250;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;

            string nomsais = textBox_nom.Text;
            string prenomsais = textBox_prenom.Text;
            string adressesais = textBox_adresse.Text;
            string adresse2sais = textBox_adresse2.Text;
            string cp = textBox_codepostal.Text;
            int codepostalsais = Int32.Parse(cp);
            int codepersosais = Int32.Parse(textBox10.Text);
            string telephonesais = textBox_telephone.Text;
            string villesais = textBox_ville.Text;
            string comboBox1sais = comboBox1.SelectedItem.ToString();
            string fonctionsais = textBox8.Text; 
            string idtsais = textBox12.Text;
            string mdpsais = textBox11.Text;


            this.Open(); //Initialisation de la connexion

            try
            {
                this.connection.Open();
                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd3 = this.connection.CreateCommand();
                // Requête SQL
                if (adresse2sais == "" || adresse2sais == "Adresse 2" || adresse2sais == " ")
                {
                    
                    cmd3.CommandText =
                    "UPDATE personnel SET  nom_personnel=\"" + nomsais + "\", prenom_personnel=\"" + prenomsais + "\", fonction_personnel=\"" + fonctionsais + "\", telephone_personnel=\"" + telephonesais + "\", adresse_ligne1_personnel=\"" + adressesais + "\", code_personnel=\"" + codepersosais + "\", affectation_personnel=\"" + comboBox1sais + "\", adresse_ligne2_personnel=NULL, code_postal_personnel=\"" + codepostalsais + "\", ville_personnel=\"" + villesais + "\", mot_de_passe_personnel=\"" + mdpsais + "\", identifiant_personnel=\"" + idtsais + "\" WHERE id_personnel=\"" + id + "\"";
                }
                else
                {
                    cmd3.CommandText =
                    "UPDATE personnel SET  nom_personnel=\"" + nomsais + "\", prenom_personnel=\"" + prenomsais + "\", fonction_personnel=\"" + fonctionsais + "\", telephone_personnel=\"" + telephonesais + "\", adresse_ligne1_personnel=\"" + adressesais + "\", code_personnel=\"" + codepersosais + "\", affectation_personnel=\"" + comboBox1sais + "\", adresse_ligne2_personnel=\"" + adresse2sais + "\", code_postal_personnel=\"" + codepostalsais + "\", ville_personnel=\"" + villesais + "\", mot_de_passe_personnel=\"" + mdpsais + "\", identifiant_personnel=\"" + idtsais + "\"WHERE id_personnel=\"" + id + "\"";
                }
                cmd3.ExecuteNonQuery();
                this.connection.Close(); // on ferme la connexion
            
                }
            catch
            {
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
            this.Hide();
            Personnel afficher = new Personnel();
            afficher.Show();


        }

        private void textBox_adresse_TextChanged(object sender, EventArgs e)
        {
            this.textBox_adresse.MaxLength = 200;
        }

        private void textBox_ville_TextChanged(object sender, EventArgs e)
        {
            this.textBox_ville.MaxLength = 100;
            this.textBox_ville.Text = this.textBox_ville.Text.ToUpper();
            this.textBox_ville.SelectionStart = this.textBox_ville.Text.Length;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.textBox8.MaxLength = 50;
            this.textBox8.Text = this.textBox8.Text.ToUpper();
            this.textBox8.SelectionStart = this.textBox8.Text.Length;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            this.textBox10.MaxLength = 9;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            this.textBox12.MaxLength = 50;
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            this.textBox_prenom.MaxLength = 50;
        }

        private void textBox_codepostal_TextChanged(object sender, EventArgs e)
        {
            this.textBox_codepostal.MaxLength = 5;
        }

        private void textBox_telephone_TextChanged(object sender, EventArgs e)
        {
            this.textBox_telephone.MaxLength = 10;
        }


    private void textBox11_TextChanged(object sender, EventArgs e)
        {
            this.textBox11.MaxLength = 50;
        }

        private void textBox_codepostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        private void textBox_codeperso_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        private void textBox_telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_adresse2_Enter(object sender, EventArgs e)
        {
                if (textBox_adresse2.Text == "Adresse ligne 2")
            {
                textBox_adresse2.Text = "";
                textBox_adresse2.ForeColor = Color.Black;
            
       
            }
        }

        private void textBox_adresse2_Leave(object sender, EventArgs e)
        {

                if (textBox_adresse2.Text == "")
            {
                textBox_adresse2.Text = "Adresse ligne 2";
                textBox_adresse2.ForeColor = Color.Gray;
            }
            

        }

        private void ModifierPersonnel_Load(object sender, EventArgs e)
        {

        }
    }
}
