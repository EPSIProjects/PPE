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
    public partial class    Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil afficher = new Accueil();
            afficher.Show();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            this.listView1.BackgroundImage = Para_Vent.Properties.Resources.graph1;
        }

        private void listView4_Enter(object sender, EventArgs e)
        {
            this.listView1.BackgroundImage = Para_Vent.Properties.Resources.graph3;
        }

        private void listView3_Enter(object sender, EventArgs e)
        {
            this.listView1.BackgroundImage = Para_Vent.Properties.Resources.graph2;
        }

        private void listView2_Enter(object sender, EventArgs e)
        {
            this.listView1.BackgroundImage = Para_Vent.Properties.Resources.graph1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
