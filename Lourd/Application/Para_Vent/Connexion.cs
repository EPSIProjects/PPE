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
    public partial class Connexion : Form
    {
        private MySqlConnection connection;
        public Connexion(){
            InitializeComponent();
        }
        public void Open() //ouverture connexion
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=para-vent; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        private void Form1_Load(object sender, EventArgs e){

        }
        private void label1_Click(object sender, EventArgs e){
       
        }

        private void label2_Click(object sender, EventArgs e){

        }

        private void label3_Click(object sender, EventArgs e){

        }

        private void textBox2_TextChanged(object sender, EventArgs e){
            ActiveForm.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e){
            ActiveForm.AcceptButton = button1;
        }
        private void button1_Click(object sender, EventArgs e){

            this.Open(); //ouverture connexion
            try{
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "SELECT mot_de_passe_personnel FROM personnel WHERE identifiant_personnel=\""+idt.Text+"\"";

                // Récupération du mot de passe en fonction de l'utilisateur donné
                object result2 = cmd.ExecuteScalar();
                string mdpbdd = (string)result2;

                //Verrification des identifiants
                if (mdpbdd==mdp.Text){
                    this.Hide();
                    Accueil afficher = new Accueil();
                    afficher.Show();
                }
                else{
                    MessageBox.Show("Erreur de saisie!");
                    idt.Text = "";
                    mdp.Text = "";
                }

                // Fermeture de la connexion
                this.connection.Close();
            }
            catch{
                MessageBox.Show("Erreur de connexion à la base de donnée");
            }
            
         }
    }
}
