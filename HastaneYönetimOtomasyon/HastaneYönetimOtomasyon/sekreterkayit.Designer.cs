namespace HastaneYönetimOtomasyon
{
    partial class sekreterkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterkayit));
            this.sekreterkaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sekretertel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sekreterad = new System.Windows.Forms.TextBox();
            this.sekretersoyad = new System.Windows.Forms.TextBox();
            this.sekretersifre = new System.Windows.Forms.TextBox();
            this.sekretertc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sekreterkaydet
            // 
            this.sekreterkaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sekreterkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekreterkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekreterkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sekreterkaydet.Location = new System.Drawing.Point(285, 388);
            this.sekreterkaydet.Name = "sekreterkaydet";
            this.sekreterkaydet.Size = new System.Drawing.Size(415, 61);
            this.sekreterkaydet.TabIndex = 76;
            this.sekreterkaydet.Text = "KAYDET";
            this.sekreterkaydet.UseVisualStyleBackColor = false;
            this.sekreterkaydet.Click += new System.EventHandler(this.sekreterkaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(141, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "TELEFON :";
            // 
            // sekretertel
            // 
            this.sekretertel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretertel.Location = new System.Drawing.Point(285, 237);
            this.sekretertel.Mask = "(9990) 000-0000";
            this.sekretertel.Name = "sekretertel";
            this.sekretertel.Size = new System.Drawing.Size(415, 22);
            this.sekretertel.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(141, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(141, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "AD :";
            // 
            // sekreterad
            // 
            this.sekreterad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekreterad.Location = new System.Drawing.Point(285, 154);
            this.sekreterad.Name = "sekreterad";
            this.sekreterad.Size = new System.Drawing.Size(415, 22);
            this.sekreterad.TabIndex = 69;
            // 
            // sekretersoyad
            // 
            this.sekretersoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretersoyad.Location = new System.Drawing.Point(285, 196);
            this.sekretersoyad.Name = "sekretersoyad";
            this.sekretersoyad.Size = new System.Drawing.Size(415, 22);
            this.sekretersoyad.TabIndex = 70;
            // 
            // sekretersifre
            // 
            this.sekretersifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretersifre.Location = new System.Drawing.Point(285, 323);
            this.sekretersifre.Name = "sekretersifre";
            this.sekretersifre.PasswordChar = '•';
            this.sekretersifre.Size = new System.Drawing.Size(415, 22);
            this.sekretersifre.TabIndex = 73;
            // 
            // sekretertc
            // 
            this.sekretertc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretertc.Location = new System.Drawing.Point(285, 279);
            this.sekretertc.Mask = "00000000000";
            this.sekretertc.Name = "sekretertc";
            this.sekretertc.Size = new System.Drawing.Size(415, 22);
            this.sekretertc.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(930, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 81;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(958, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(132, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(793, 69);
            this.label3.TabIndex = 79;
            this.label3.Text = "SEKRETER KAYIT PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "TC :";
            // 
            // sekreterkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 468);
            this.Controls.Add(this.sekreterkaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sekretertel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sekreterad);
            this.Controls.Add(this.sekretersoyad);
            this.Controls.Add(this.sekretersifre);
            this.Controls.Add(this.sekretertc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sekreterkayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sekreterkayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekreterkaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox sekretertel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sekreterad;
        private System.Windows.Forms.TextBox sekretersoyad;
        private System.Windows.Forms.TextBox sekretersifre;
        private System.Windows.Forms.MaskedTextBox sekretertc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}