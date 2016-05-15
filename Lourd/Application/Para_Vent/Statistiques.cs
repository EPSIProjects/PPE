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
            
            Accueil afficher = new Accueil();
            afficher.Show();
            this.Hide();
        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            this.listView1.BackgroundImage = Para_Vent.Properties.Resources.graph1;
            this.listView2.BackgroundImage = Para_Vent.Properties.Resources.mini1;
            this.listView3.BackgroundImage = Para_Vent.Properties.Resources.mini2;
            this.listView4.BackgroundImage = Para_Vent.Properties.Resources.mini3;
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

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
