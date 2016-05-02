namespace Para_Vent
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.button_personnel = new System.Windows.Forms.Button();
            this.button_produits = new System.Windows.Forms.Button();
            this.button_formations = new System.Windows.Forms.Button();
            this.button_statistiques = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_personnel
            // 
            this.button_personnel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_personnel.BackgroundImage")));
            this.button_personnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_personnel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_personnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_personnel.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_personnel.Location = new System.Drawing.Point(83, 32);
            this.button_personnel.Name = "button_personnel";
            this.button_personnel.Size = new System.Drawing.Size(271, 195);
            this.button_personnel.TabIndex = 0;
            this.button_personnel.Text = "Personnel";
            this.button_personnel.UseVisualStyleBackColor = true;
            this.button_personnel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_produits
            // 
            this.button_produits.BackColor = System.Drawing.Color.White;
            this.button_produits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_produits.BackgroundImage")));
            this.button_produits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_produits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_produits.ForeColor = System.Drawing.Color.White;
            this.button_produits.Location = new System.Drawing.Point(403, 32);
            this.button_produits.Name = "button_produits";
            this.button_produits.Size = new System.Drawing.Size(271, 195);
            this.button_produits.TabIndex = 2;
            this.button_produits.Text = "Produits";
            this.button_produits.UseVisualStyleBackColor = false;
            this.button_produits.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_formations
            // 
            this.button_formations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_formations.BackgroundImage")));
            this.button_formations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_formations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_formations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_formations.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_formations.Location = new System.Drawing.Point(403, 263);
            this.button_formations.Margin = new System.Windows.Forms.Padding(0);
            this.button_formations.Name = "button_formations";
            this.button_formations.Size = new System.Drawing.Size(271, 195);
            this.button_formations.TabIndex = 3;
            this.button_formations.Text = "Formations";
            this.button_formations.UseVisualStyleBackColor = true;
            this.button_formations.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_statistiques
            // 
            this.button_statistiques.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_statistiques.BackgroundImage")));
            this.button_statistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_statistiques.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_statistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_statistiques.Location = new System.Drawing.Point(83, 263);
            this.button_statistiques.Name = "button_statistiques";
            this.button_statistiques.Size = new System.Drawing.Size(271, 195);
            this.button_statistiques.TabIndex = 4;
            this.button_statistiques.Text = "Statistiques";
            this.button_statistiques.UseVisualStyleBackColor = true;
            this.button_statistiques.Click += new System.EventHandler(this.button4_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 501);
            this.Controls.Add(this.button_statistiques);
            this.Controls.Add(this.button_formations);
            this.Controls.Add(this.button_produits);
            this.Controls.Add(this.button_personnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_personnel;
        private System.Windows.Forms.Button button_produits;
        private System.Windows.Forms.Button button_formations;
        private System.Windows.Forms.Button button_statistiques;
    }
}