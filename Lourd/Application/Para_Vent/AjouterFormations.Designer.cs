namespace Para_Vent
{
    partial class AjouterFormations
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
            this.textBox1_libelle = new System.Windows.Forms.TextBox();
            this.textBox1_code = new System.Windows.Forms.TextBox();
            this.comboBox1_personnel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_libelle
            // 
            this.textBox1_libelle.Location = new System.Drawing.Point(146, 102);
            this.textBox1_libelle.Name = "textBox1_libelle";
            this.textBox1_libelle.Size = new System.Drawing.Size(100, 20);
            this.textBox1_libelle.TabIndex = 0;
            this.textBox1_libelle.Text = "Libelle";
            this.textBox1_libelle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1_code
            // 
            this.textBox1_code.Location = new System.Drawing.Point(266, 102);
            this.textBox1_code.Name = "textBox1_code";
            this.textBox1_code.Size = new System.Drawing.Size(100, 20);
            this.textBox1_code.TabIndex = 0;
            this.textBox1_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1_personnel
            // 
            this.comboBox1_personnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_personnel.FormattingEnabled = true;
            this.comboBox1_personnel.Location = new System.Drawing.Point(384, 101);
            this.comboBox1_personnel.Name = "comboBox1_personnel";
            this.comboBox1_personnel.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_personnel.TabIndex = 1;
            this.comboBox1_personnel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_personnel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une formation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AjouterFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_personnel);
            this.Controls.Add(this.textBox1_code);
            this.Controls.Add(this.textBox1_libelle);
            this.Name = "AjouterFormations";
            this.Text = "AjouterFormations";
            this.Load += new System.EventHandler(this.AjouterFormations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_libelle;
        private System.Windows.Forms.TextBox textBox1_code;
        private System.Windows.Forms.ComboBox comboBox1_personnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}