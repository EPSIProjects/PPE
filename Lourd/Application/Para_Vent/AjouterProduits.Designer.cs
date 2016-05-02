namespace Para_Vent
{
    partial class AjouterProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterProduits));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox2_stock = new System.Windows.Forms.TextBox();
            this.comboBox1_fournisseur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un produit";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(166, 110);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 1;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_nom.Enter += new System.EventHandler(this.textBox_nom_Enter);
            this.textBox_nom.Leave += new System.EventHandler(this.textBox_nom_Leave);
            // 
            // textBox2_stock
            // 
            this.textBox2_stock.Location = new System.Drawing.Point(272, 110);
            this.textBox2_stock.Name = "textBox2_stock";
            this.textBox2_stock.Size = new System.Drawing.Size(100, 20);
            this.textBox2_stock.TabIndex = 2;
            this.textBox2_stock.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2_stock.Enter += new System.EventHandler(this.textBox2_stock_Enter);
            this.textBox2_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_stock_KeyPress);
            this.textBox2_stock.Leave += new System.EventHandler(this.textBox2_stock_Leave);
            // 
            // comboBox1_fournisseur
            // 
            this.comboBox1_fournisseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_fournisseur.FormattingEnabled = true;
            this.comboBox1_fournisseur.Items.AddRange(new object[] {
            "Fournisseur"});
            this.comboBox1_fournisseur.Location = new System.Drawing.Point(379, 110);
            this.comboBox1_fournisseur.Name = "comboBox1_fournisseur";
            this.comboBox1_fournisseur.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_fournisseur.TabIndex = 2;
            this.comboBox1_fournisseur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "← retour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AjouterProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1_fournisseur);
            this.Controls.Add(this.textBox2_stock);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterProduits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox2_stock;
        private System.Windows.Forms.ComboBox comboBox1_fournisseur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}