namespace Para_Vent
{
    partial class ModifierPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierPersonnel));
            this.label1 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.textBox_adresse2 = new System.Windows.Forms.TextBox();
            this.textBox_codepostal = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "← retour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(248, 53);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(278, 37);
            this.titre.TabIndex = 9;
            this.titre.Text = "Modifier un salarié";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.AccessibleDescription = "";
            this.textBox_nom.Location = new System.Drawing.Point(255, 132);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.ReadOnly = true;
            this.textBox_nom.Size = new System.Drawing.Size(122, 20);
            this.textBox_nom.TabIndex = 11;
            this.textBox_nom.Tag = "";
            this.textBox_nom.Text = "Nom";
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.AccessibleDescription = "";
            this.textBox_prenom.Location = new System.Drawing.Point(393, 132);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.ReadOnly = true;
            this.textBox_prenom.Size = new System.Drawing.Size(132, 20);
            this.textBox_prenom.TabIndex = 12;
            this.textBox_prenom.Tag = "";
            this.textBox_prenom.Text = "Prénom";
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.AccessibleDescription = "";
            this.textBox_telephone.Location = new System.Drawing.Point(378, 215);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(147, 20);
            this.textBox_telephone.TabIndex = 14;
            this.textBox_telephone.Tag = "";
            this.textBox_telephone.Text = "Téléphone";
            this.textBox_telephone.TextChanged += new System.EventHandler(this.textBox_telephone_TextChanged);
            this.textBox_telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telephone_KeyPress);
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.AccessibleDescription = "";
            this.textBox_adresse.Location = new System.Drawing.Point(255, 162);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_adresse.Size = new System.Drawing.Size(270, 20);
            this.textBox_adresse.TabIndex = 15;
            this.textBox_adresse.Tag = "";
            this.textBox_adresse.Text = "Adresse";
            this.textBox_adresse.TextChanged += new System.EventHandler(this.textBox_adresse_TextChanged);
            // 
            // textBox_adresse2
            // 
            this.textBox_adresse2.AccessibleDescription = "";
            this.textBox_adresse2.Location = new System.Drawing.Point(255, 189);
            this.textBox_adresse2.Name = "textBox_adresse2";
            this.textBox_adresse2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_adresse2.Size = new System.Drawing.Size(270, 20);
            this.textBox_adresse2.TabIndex = 16;
            this.textBox_adresse2.Tag = "";
            this.textBox_adresse2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox_adresse2.Enter += new System.EventHandler(this.textBox_adresse2_Enter);
            this.textBox_adresse2.Leave += new System.EventHandler(this.textBox_adresse2_Leave);
            // 
            // textBox_codepostal
            // 
            this.textBox_codepostal.AccessibleDescription = "";
            this.textBox_codepostal.Location = new System.Drawing.Point(255, 215);
            this.textBox_codepostal.Name = "textBox_codepostal";
            this.textBox_codepostal.Size = new System.Drawing.Size(108, 20);
            this.textBox_codepostal.TabIndex = 17;
            this.textBox_codepostal.Tag = "";
            this.textBox_codepostal.Text = "Code postal";
            this.textBox_codepostal.TextChanged += new System.EventHandler(this.textBox_codepostal_TextChanged);
            this.textBox_codepostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codepostal_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.AccessibleDescription = "";
            this.textBox8.Location = new System.Drawing.Point(255, 267);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(98, 20);
            this.textBox8.TabIndex = 18;
            this.textBox8.Tag = "";
            this.textBox8.Text = "Fonction (abrégée)";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox_ville
            // 
            this.textBox_ville.AccessibleDescription = "";
            this.textBox_ville.Location = new System.Drawing.Point(255, 241);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(143, 20);
            this.textBox_ville.TabIndex = 19;
            this.textBox_ville.Tag = "";
            this.textBox_ville.Text = "Ville";
            this.textBox_ville.TextChanged += new System.EventHandler(this.textBox_ville_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.AccessibleDescription = "";
            this.textBox10.Location = new System.Drawing.Point(369, 269);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(156, 20);
            this.textBox10.TabIndex = 20;
            this.textBox10.Tag = "";
            this.textBox10.Text = "Code personnel";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codeperso_KeyPress);
            // 
            // textBox11
            // 
            this.textBox11.AccessibleDescription = "";
            this.textBox11.Location = new System.Drawing.Point(393, 349);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(132, 20);
            this.textBox11.TabIndex = 21;
            this.textBox11.Tag = "";
            this.textBox11.Text = "Mot de passe";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.AccessibleDescription = "";
            this.textBox12.Location = new System.Drawing.Point(255, 349);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(122, 20);
            this.textBox12.TabIndex = 22;
            this.textBox12.Tag = "";
            this.textBox12.Text = "Identifiant";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleDescription = "";
            this.comboBox1.AccessibleName = "";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BORDEAUX",
            "CLERMONT-FERRAND",
            "TARBES",
            "NANCY",
            "RENNES"});
            this.comboBox1.Location = new System.Drawing.Point(404, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(640, 107);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 25;
            this.textBox_id.Visible = false;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // ModifierPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox_codepostal);
            this.Controls.Add(this.textBox_adresse2);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.textBox_telephone);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierPersonnel";
            this.Load += new System.EventHandler(this.ModifierPersonnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.TextBox textBox_adresse2;
        private System.Windows.Forms.TextBox textBox_codepostal;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox_id;
    }
}