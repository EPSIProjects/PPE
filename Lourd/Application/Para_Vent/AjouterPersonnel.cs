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
    public partial class AjouterPersonnel : Form
    {
        private MySqlConnection connection;
        public AjouterPersonnel()
        {
            InitializeComponent();
            TexteLeaveEnter();

        }
        private void TexteLeaveEnter()
        {
            textBox_nom.ForeColor = Color.Black;
            comboBox1.Items.Add("Affectation");
            comboBox1.Items.Add("BORDEAUX");
            comboBox1.Items.Add("CLERMONT-FERRAND");
            comboBox1.Items.Add("TARBES");
            comboBox1.Items.Add("NANCY");
            comboBox1.Items.Add("RENNES");
            comboBox1.SelectedIndex = 0;

            textBox_nom.ForeColor = Color.Gray;
            textBox_nom.Text = "NOM";
            this.textBox_nom.Leave += new System.EventHandler(this.textBox_nom_Leave);
            this.textBox_nom.Enter += new System.EventHandler(this.textBox_nom_Enter);


            textBox_prenom.ForeColor = Color.Gray;
            textBox_prenom.Text = "Prénom";
            this.textBox_prenom.Leave += new System.EventHandler(this.textBox_prenom_Leave);
            this.textBox_prenom.Enter += new System.EventHandler(this.textBox_prenom_Enter);

            textBox_adresse.ForeColor = Color.Gray;
            textBox_adresse.Text = "Adresse";
            this.textBox_adresse.Leave += new System.EventHandler(this.textBox_adresse_Leave);
            this.textBox_adresse.Enter += new System.EventHandler(this.textBox_adresse_Enter);

            textBox_adresse2.ForeColor = Color.Gray;
            textBox_adresse2.Text = "Adresse ligne 2";
            this.textBox_adresse2.Leave += new System.EventHandler(this.textBox_adresse2_Leave);
            this.textBox_adresse2.Enter += new System.EventHandler(this.textBox_adresse2_Enter);

            textBox_codepostal.ForeColor = Color.Gray;
            textBox_codepostal.Text = "Code postal";
            this.textBox_codepostal.Leave += new System.EventHandler(this.textBox_codepostal_Leave);
            this.textBox_codepostal.Enter += new System.EventHandler(this.textBox_codepostal_Enter);

            textBox_telephone.ForeColor = Color.Gray;
            textBox_telephone.Text = "Téléphone";
            this.textBox_telephone.Leave += new System.EventHandler(this.textBox_telephone_Leave);
            this.textBox_telephone.Enter += new System.EventHandler(this.textBox_telephone_Enter);

            textBox_ville.ForeColor = Color.Gray;
            textBox_ville.Text = "VILLE";
            this.textBox_ville.Leave += new System.EventHandler(this.textBox_ville_Leave);
            this.textBox_ville.Enter += new System.EventHandler(this.textBox_ville_Enter);

            textBox8.ForeColor = Color.Gray;
            textBox8.Text = "FONCTION";
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
            this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);

            textBox10.ForeColor = Color.Gray;
            textBox10.Text = "Code personnel";
            this.textBox10.Leave += new System.EventHandler(this.textBox10_Leave);
            this.textBox10.Enter += new System.EventHandler(this.textBox10_Enter);

            textBox12.ForeColor = Color.Gray;
            textBox12.Text = "Identifiant";
            this.textBox12.Leave += new System.EventHandler(this.textBox12_Leave);
            this.textBox12.Enter += new System.EventHandler(this.textBox12_Enter);

            textBox11.ForeColor = Color.Gray;
            textBox11.Text = "Mot de passe";
            this.textBox11.Leave += new System.EventHandler(this.textBox11_Leave);
            this.textBox11.Enter += new System.EventHandler(this.textBox11_Enter);

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


            if (comboBox1sais != "Affectation")
            {


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
                        "INSERT INTO personnel (id_personnel, nom_personnel, prenom_personnel, fonction_personnel, telephone_personnel, adresse_ligne1_personnel, code_personnel, affectation_personnel, adresse_ligne2_personnel, code_postal_personnel, ville_personnel, mot_de_passe_personnel, identifiant_personnel,etat) VALUES (NULL, \"" + nomsais + "\", \"" + prenomsais + "\", \"" + fonctionsais + "\", \"" + telephonesais + "\", \"" + adressesais + "\", \"" + codepersosais + "\", \"" + comboBox1sais + "\", NULL, \"" + codepostalsais + "\",  \"" + villesais + "\",  \"" + mdpsais + "\",  \"" + idtsais + "\", 0)";
                    }
                    else
                    {
                        cmd3.CommandText =
                        "INSERT INTO personnel (id_personnel, nom_personnel, prenom_personnel, fonction_personnel, telephone_personnel, adresse_ligne1_personnel, code_personnel, affectation_personnel, adresse_ligne2_personnel, code_postal_personnel, ville_personnel, mot_de_passe_personnel, identifiant_personnel,etat) VALUES (NULL, \"" + nomsais + "\", \"" + prenomsais + "\", \"" + fonctionsais + "\", \"" + telephonesais + "\", \"" + adressesais + "\", \"" + codepersosais + "\", \"" + comboBox1sais + "\", \"" + adresse2sais + "\", \"" + codepostalsais + "\",  \"" + villesais + "\",  \"" + mdpsais + "\",  \"" + idtsais + "\", 0)";
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
            else
                MessageBox.Show("Tous les champs ne sont pas correctement remplis");

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

        private void textBox_nom_Enter(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "NOM")
            {
                textBox_nom.Text = "";
                textBox_nom.ForeColor = Color.Black;
            }
        }

        private void textBox_nom_Leave(object sender, EventArgs e)
        {
            if (textBox_nom.Text == "")
            {
                textBox_nom.Text = "NOM";
                textBox_nom.ForeColor = Color.Gray;
            }
        }

        private void textBox_prenom_Enter(object sender, EventArgs e)
        {
            if (textBox_prenom.Text == "Prénom")
            {
                textBox_prenom.Text = "";
                textBox_prenom.ForeColor = Color.Black;
            }
        }

        private void textBox_prenom_Leave(object sender, EventArgs e)
        {
            if (textBox_prenom.Text == "")
            {
                textBox_prenom.Text = "Prénom";
                textBox_prenom.ForeColor = Color.Gray;
            }
        }

        private void textBox_adresse_Enter(object sender, EventArgs e)
        {
            if (textBox_adresse.Text == "Adresse")
            {
                textBox_adresse.Text = "";
                textBox_adresse.ForeColor = Color.Black;
            }
        }

        private void textBox_adresse_Leave(object sender, EventArgs e)
        {
            if (textBox_adresse.Text == "")
            {
                textBox_adresse.Text = "Adresse";
                textBox_adresse.ForeColor = Color.Gray;
            }
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

        private void textBox_codepostal_Enter(object sender, EventArgs e)
        {
            if (textBox_codepostal.Text == "Code postal")
            {
                textBox_codepostal.Text = "";
                textBox_codepostal.ForeColor = Color.Black;
            }
        }

        private void textBox_codepostal_Leave(object sender, EventArgs e)
        {
            if (textBox_codepostal.Text == "")
            {
                textBox_codepostal.Text = "Code postal";
                textBox_codepostal.ForeColor = Color.Gray;
            }
        }



        private void textBox_telephone_Enter(object sender, EventArgs e)
        {
            if (textBox_telephone.Text == "Téléphone")
            {
                textBox_telephone.Text = "";
                textBox_telephone.ForeColor = Color.Black;
            }
        }
        private void textBox_telephone_Leave(object sender, EventArgs e)
        {
            if (textBox_telephone.Text == "")
            {
                textBox_telephone.Text = "Téléphone";
                textBox_telephone.ForeColor = Color.Gray;
            }
        }

        private void textBox_ville_Enter(object sender, EventArgs e)
        {
            if (textBox_ville.Text == "VILLE")
            {
                textBox_ville.Text = "";
                textBox_ville.ForeColor = Color.Black;
            }
        }

        private void textBox_ville_Leave(object sender, EventArgs e)
        {
            if (textBox_ville.Text == "")
            {
                textBox_ville.Text = "VILLE";
                textBox_ville.ForeColor = Color.Gray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "FONCTION")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "FONCTION";
                textBox8.ForeColor = Color.Gray;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Code personnel";
                textBox10.ForeColor = Color.Gray;
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Code personnel")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Identifiant")
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.Black;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Identifiant";
                textBox12.ForeColor = Color.Gray;
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Mot de passe")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Mot de passe";
                textBox11.ForeColor = Color.Gray;
            }
        }

        private void AjouterPersonnel_Load(object sender, EventArgs e)
        {

        }
    }
}
