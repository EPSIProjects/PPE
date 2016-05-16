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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Personnel afficher = new Personnel();
            afficher.Show();
            this.Hide();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            Produits afficher = new Produits();
            afficher.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Formations afficher = new Formations();
            afficher.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Statistiques afficher = new Statistiques();
            afficher.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
