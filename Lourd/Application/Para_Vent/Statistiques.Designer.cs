namespace Para_Vent
{
    partial class Statistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistiques));
            this.label2 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.label2.TabIndex = 10;
            this.label2.Text = "← retour";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView4
            // 
            this.listView4.BackgroundImage = global::Para_Vent.Properties.Resources.mini3;
            this.listView4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView4.Location = new System.Drawing.Point(482, 22);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(109, 67);
            this.listView4.TabIndex = 15;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.Enter += new System.EventHandler(this.listView4_Enter);
            // 
            // listView3
            // 
            this.listView3.BackgroundImage = global::Para_Vent.Properties.Resources.mini2;
            this.listView3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView3.Location = new System.Drawing.Point(343, 22);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(112, 67);
            this.listView3.TabIndex = 14;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.Enter += new System.EventHandler(this.listView3_Enter);
            // 
            // listView2
            // 
            this.listView2.BackgroundImage = global::Para_Vent.Properties.Resources.mini1;
            this.listView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView2.Location = new System.Drawing.Point(206, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(103, 67);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.Enter += new System.EventHandler(this.listView2_Enter);
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Location = new System.Drawing.Point(21, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 373);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formations";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
    }
}