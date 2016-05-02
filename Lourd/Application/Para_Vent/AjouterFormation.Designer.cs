namespace Para_Vent
{
    partial class AjouterFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterFormation));
            this.textBox1_libelle = new System.Windows.Forms.TextBox();
            this.textBox1_code = new System.Windows.Forms.TextBox();
            this.comboBox1_personnel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_client = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1_libelle
            // 
            this.textBox1_libelle.Location = new System.Drawing.Point(122, 129);
            this.textBox1_libelle.Name = "textBox1_libelle";
            this.textBox1_libelle.Size = new System.Drawing.Size(100, 20);
            this.textBox1_libelle.TabIndex = 0;
            this.textBox1_libelle.Text = "Libelle";
            this.textBox1_libelle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1_code
            // 
            this.textBox1_code.Location = new System.Drawing.Point(242, 129);
            this.textBox1_code.Name = "textBox1_code";
            this.textBox1_code.Size = new System.Drawing.Size(100, 20);
            this.textBox1_code.TabIndex = 0;
            this.textBox1_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_code_KeyPress);
            // 
            // comboBox1_personnel
            // 
            this.comboBox1_personnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_personnel.FormattingEnabled = true;
            this.comboBox1_personnel.Location = new System.Drawing.Point(479, 128);
            this.comboBox1_personnel.Name = "comboBox1_personnel";
            this.comboBox1_personnel.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_personnel.TabIndex = 1;
            this.comboBox1_personnel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_personnel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une formation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "← retour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1_client
            // 
            this.comboBox1_client.FormattingEnabled = true;
            this.comboBox1_client.Location = new System.Drawing.Point(352, 128);
            this.comboBox1_client.Name = "comboBox1_client";
            this.comboBox1_client.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_client.TabIndex = 12;
            this.comboBox1_client.SelectedIndexChanged += new System.EventHandler(this.comboBox1_client_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.Location = new System.Drawing.Point(352, 186);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // AjouterFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_personnel);
            this.Controls.Add(this.textBox1_code);
            this.Controls.Add(this.textBox1_libelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_client;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}