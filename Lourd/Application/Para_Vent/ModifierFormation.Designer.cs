﻿namespace Para_Vent
{
    partial class ModifierFormation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierFormation));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_libelle = new System.Windows.Forms.TextBox();
            this.textBox2_code = new System.Windows.Forms.TextBox();
            this.comboBox1_personnel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            this.label2.TabIndex = 12;
            this.label2.Text = "← retour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1_libelle
            // 
            this.textBox1_libelle.Location = new System.Drawing.Point(172, 143);
            this.textBox1_libelle.Name = "textBox1_libelle";
            this.textBox1_libelle.Size = new System.Drawing.Size(100, 20);
            this.textBox1_libelle.TabIndex = 13;
            this.textBox1_libelle.TextChanged += new System.EventHandler(this.textBox1_libelle_TextChanged);
            // 
            // textBox2_code
            // 
            this.textBox2_code.Location = new System.Drawing.Point(298, 143);
            this.textBox2_code.Name = "textBox2_code";
            this.textBox2_code.Size = new System.Drawing.Size(100, 20);
            this.textBox2_code.TabIndex = 14;
            this.textBox2_code.TextChanged += new System.EventHandler(this.textBox2_code_TextChanged);
            this.textBox2_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_code_KeyPress);
            // 
            // comboBox1_personnel
            // 
            this.comboBox1_personnel.FormattingEnabled = true;
            this.comboBox1_personnel.Location = new System.Drawing.Point(417, 143);
            this.comboBox1_personnel.Name = "comboBox1_personnel";
            this.comboBox1_personnel.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_personnel.TabIndex = 15;
            this.comboBox1_personnel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_personnel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modification d\'une formation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(20, 278);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(100, 20);
            this.textBox1_id.TabIndex = 18;
            this.textBox1_id.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 192);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // ModifierFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(690, 369);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_personnel);
            this.Controls.Add(this.textBox2_code);
            this.Controls.Add(this.textBox1_libelle);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterFormation";
            this.Load += new System.EventHandler(this.ModifierFormation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_libelle;
        private System.Windows.Forms.TextBox textBox2_code;
        private System.Windows.Forms.ComboBox comboBox1_personnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}