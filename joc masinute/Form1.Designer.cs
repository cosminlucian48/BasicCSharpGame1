namespace joc_masinute
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stanga = new System.Windows.Forms.Timer(this.components);
            this.dreapta = new System.Windows.Forms.Timer(this.components);
            this.masina1 = new System.Windows.Forms.Timer(this.components);
            this.masina2 = new System.Windows.Forms.Timer(this.components);
            this.masina3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inamic3 = new System.Windows.Forms.PictureBox();
            this.inamic2 = new System.Windows.Forms.PictureBox();
            this.inamic1 = new System.Windows.Forms.PictureBox();
            this.masina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inamic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inamic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inamic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masina)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stanga
            // 
            this.stanga.Interval = 10;
            this.stanga.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dreapta
            // 
            this.dreapta.Interval = 10;
            this.dreapta.Tick += new System.EventHandler(this.dreapta_Tick);
            // 
            // masina1
            // 
            this.masina1.Enabled = true;
            this.masina1.Interval = 10;
            this.masina1.Tick += new System.EventHandler(this.masina1_Tick);
            // 
            // masina2
            // 
            this.masina2.Enabled = true;
            this.masina2.Interval = 10;
            this.masina2.Tick += new System.EventHandler(this.masina2_Tick);
            // 
            // masina3
            // 
            this.masina3.Enabled = true;
            this.masina3.Interval = 10;
            this.masina3.Tick += new System.EventHandler(this.masina3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Viteza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(52, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ai pierdut!";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // inamic3
            // 
            this.inamic3.Image = global::joc_masinute.Properties.Resources.masin3;
            this.inamic3.Location = new System.Drawing.Point(200, -52);
            this.inamic3.Name = "inamic3";
            this.inamic3.Size = new System.Drawing.Size(35, 62);
            this.inamic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inamic3.TabIndex = 3;
            this.inamic3.TabStop = false;
            // 
            // inamic2
            // 
            this.inamic2.Image = global::joc_masinute.Properties.Resources.masina1;
            this.inamic2.Location = new System.Drawing.Point(106, -52);
            this.inamic2.Name = "inamic2";
            this.inamic2.Size = new System.Drawing.Size(35, 62);
            this.inamic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inamic2.TabIndex = 2;
            this.inamic2.TabStop = false;
            // 
            // inamic1
            // 
            this.inamic1.Image = global::joc_masinute.Properties.Resources.masina2;
            this.inamic1.Location = new System.Drawing.Point(12, -52);
            this.inamic1.Name = "inamic1";
            this.inamic1.Size = new System.Drawing.Size(35, 62);
            this.inamic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inamic1.TabIndex = 1;
            this.inamic1.TabStop = false;
            // 
            // masina
            // 
            this.masina.BackColor = System.Drawing.Color.Transparent;
            this.masina.Image = global::joc_masinute.Properties.Resources.eu;
            this.masina.Location = new System.Drawing.Point(106, 337);
            this.masina.Name = "masina";
            this.masina.Size = new System.Drawing.Size(35, 62);
            this.masina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.masina.TabIndex = 0;
            this.masina.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(264, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inamic3);
            this.Controls.Add(this.inamic2);
            this.Controls.Add(this.inamic1);
            this.Controls.Add(this.masina);
            this.MaximumSize = new System.Drawing.Size(280, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.inamic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inamic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inamic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox masina;
        private System.Windows.Forms.Timer stanga;
        private System.Windows.Forms.Timer dreapta;
        private System.Windows.Forms.PictureBox inamic1;
        private System.Windows.Forms.Timer masina1;
        private System.Windows.Forms.PictureBox inamic2;
        private System.Windows.Forms.PictureBox inamic3;
        private System.Windows.Forms.Timer masina2;
        private System.Windows.Forms.Timer masina3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

