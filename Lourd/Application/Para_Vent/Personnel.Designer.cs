namespace Para_Vent
{
    partial class Personnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Salariés", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Formateurs", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Commerciaux", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Administration (centre de Bordeaux)", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personnel));
            this.titre = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_affectation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button_activer = new System.Windows.Forms.Button();
            this.button_desactiver = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(262, 31);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(321, 37);
            this.titre.TabIndex = 6;
            this.titre.Text = "Gestion du personnel";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_nom,
            this.column_prenom,
            this.column_ville,
            this.column_adresse,
            this.column_affectation,
            this.column_id});
            listViewGroup1.Header = "Salariés";
            listViewGroup1.Name = "listViewGroup_default";
            listViewGroup2.Header = "Formateurs";
            listViewGroup2.Name = "listViewGroup_formateurs";
            listViewGroup2.Tag = "";
            listViewGroup3.Header = "Commerciaux";
            listViewGroup3.Name = "listViewGroup-commerciaux";
            listViewGroup4.Header = "Administration (centre de Bordeaux)";
            listViewGroup4.Name = "listViewGroup_administration";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.Location = new System.Drawing.Point(35, 167);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(713, 308);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // column_nom
            // 
            this.column_nom.Text = "Nom";
            this.column_nom.Width = 95;
            // 
            // column_prenom
            // 
            this.column_prenom.Text = "Prenom";
            this.column_prenom.Width = 104;
            // 
            // column_ville
            // 
            this.column_ville.Text = "Ville";
            this.column_ville.Width = 78;
            // 
            // column_adresse
            // 
            this.column_adresse.Text = "Adresse";
            this.column_adresse.Width = 200;
            // 
            // column_affectation
            // 
            this.column_affectation.DisplayIndex = 5;
            this.column_affectation.Text = "Affecation";
            this.column_affectation.Width = 100;
            // 
            // column_id
            // 
            this.column_id.DisplayIndex = 4;
            this.column_id.Text = "id";
            this.column_id.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "← retour";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // button_activer
            // 
            this.button_activer.Location = new System.Drawing.Point(591, 138);
            this.button_activer.Name = "button_activer";
            this.button_activer.Size = new System.Drawing.Size(75, 23);
            this.button_activer.TabIndex = 9;
            this.button_activer.Text = "Activer";
            this.button_activer.UseVisualStyleBackColor = true;
            this.button_activer.Click += new System.EventHandler(this.button_activer_Click);
            // 
            // button_desactiver
            // 
            this.button_desactiver.Location = new System.Drawing.Point(663, 138);
            this.button_desactiver.Name = "button_desactiver";
            this.button_desactiver.Size = new System.Drawing.Size(75, 23);
            this.button_desactiver.TabIndex = 10;
            this.button_desactiver.Text = "Desactiver";
            this.button_desactiver.UseVisualStyleBackColor = true;
            this.button_desactiver.Click += new System.EventHandler(this.button_desactiver_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(351, 138);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 11;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(471, 138);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 12;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(638, 97);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 13;
            this.textBox_id.Visible = false;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(120, 141);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(128, 20);
            this.searchBox.TabIndex = 14;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rechercher :";
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_desactiver);
            this.Controls.Add(this.button_activer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "Personnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Personnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_nom;
        private System.Windows.Forms.ColumnHeader column_prenom;
        private System.Windows.Forms.ColumnHeader column_ville;
        private System.Windows.Forms.ColumnHeader column_adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_activer;
        private System.Windows.Forms.Button button_desactiver;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.ColumnHeader column_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ColumnHeader column_affectation;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
    }
}