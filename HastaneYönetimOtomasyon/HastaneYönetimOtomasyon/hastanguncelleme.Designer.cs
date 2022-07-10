namespace HastaneYönetimOtomasyon
{
    partial class hastanguncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastanguncelleme));
            this.gunbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guncinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guntel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunad = new System.Windows.Forms.TextBox();
            this.gunsoyad = new System.Windows.Forms.TextBox();
            this.gunsifre = new System.Windows.Forms.TextBox();
            this.guntc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunbtn
            // 
            this.gunbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gunbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunbtn.Location = new System.Drawing.Point(257, 445);
            this.gunbtn.Name = "gunbtn";
            this.gunbtn.Size = new System.Drawing.Size(415, 61);
            this.gunbtn.TabIndex = 7;
            this.gunbtn.Text = "GÜNCELLE";
            this.gunbtn.UseVisualStyleBackColor = false;
            this.gunbtn.Click += new System.EventHandler(this.gunbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(112, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "CİNSİYET :";
            // 
            // guncinsiyet
            // 
            this.guncinsiyet.FormattingEnabled = true;
            this.guncinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.guncinsiyet.Location = new System.Drawing.Point(257, 400);
            this.guncinsiyet.Name = "guncinsiyet";
            this.guncinsiyet.Size = new System.Drawing.Size(415, 24);
            this.guncinsiyet.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(113, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "TELEFON :";
            // 
            // guntel
            // 
            this.guntel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guntel.Location = new System.Drawing.Point(257, 267);
            this.guntel.Mask = "(9990) 000-0000";
            this.guntel.Name = "guntel";
            this.guntel.Size = new System.Drawing.Size(415, 22);
            this.guntel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(113, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "AD :";
            // 
            // gunad
            // 
            this.gunad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunad.Location = new System.Drawing.Point(257, 184);
            this.gunad.Name = "gunad";
            this.gunad.Size = new System.Drawing.Size(415, 22);
            this.gunad.TabIndex = 1;
            // 
            // gunsoyad
            // 
            this.gunsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunsoyad.Location = new System.Drawing.Point(257, 226);
            this.gunsoyad.Name = "gunsoyad";
            this.gunsoyad.Size = new System.Drawing.Size(415, 22);
            this.gunsoyad.TabIndex = 2;
            // 
            // gunsifre
            // 
            this.gunsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunsifre.Location = new System.Drawing.Point(257, 353);
            this.gunsifre.Name = "gunsifre";
            this.gunsifre.Size = new System.Drawing.Size(415, 22);
            this.gunsifre.TabIndex = 5;
            // 
            // guntc
            // 
            this.guntc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guntc.Location = new System.Drawing.Point(257, 309);
            this.guntc.Mask = "00000000000";
            this.guntc.Name = "guntc";
            this.guntc.Size = new System.Drawing.Size(415, 22);
            this.guntc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(841, 55);
            this.label3.TabIndex = 45;
            this.label3.Text = "HASTA BİLGİ DÜZENLEME PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(113, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "TC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(864, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(892, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // hastanguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 522);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guncinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guntel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunad);
            this.Controls.Add(this.gunsoyad);
            this.Controls.Add(this.gunsifre);
            this.Controls.Add(this.guntc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hastanguncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastanguncelleme";
            this.Load += new System.EventHandler(this.hastanguncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gunbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox guncinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox guntel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gunad;
        private System.Windows.Forms.TextBox gunsoyad;
        private System.Windows.Forms.TextBox gunsifre;
        private System.Windows.Forms.MaskedTextBox guntc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}