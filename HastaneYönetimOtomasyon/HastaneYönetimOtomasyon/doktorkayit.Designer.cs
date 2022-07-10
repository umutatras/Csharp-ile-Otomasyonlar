namespace HastaneYönetimOtomasyon
{
    partial class doktorkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorkayit));
            this.doktorkaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.doktorcinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.doktortel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doktorad = new System.Windows.Forms.TextBox();
            this.doktorsoyad = new System.Windows.Forms.TextBox();
            this.doktorsifre = new System.Windows.Forms.TextBox();
            this.doktortc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.doktorbrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // doktorkaydet
            // 
            this.doktorkaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.doktorkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.doktorkaydet.Location = new System.Drawing.Point(365, 476);
            this.doktorkaydet.Name = "doktorkaydet";
            this.doktorkaydet.Size = new System.Drawing.Size(162, 61);
            this.doktorkaydet.TabIndex = 8;
            this.doktorkaydet.Text = "KAYDET";
            this.doktorkaydet.UseVisualStyleBackColor = false;
            this.doktorkaydet.Click += new System.EventHandler(this.doktorkaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(94, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "CİNSİYET :";
            // 
            // doktorcinsiyet
            // 
            this.doktorcinsiyet.FormattingEnabled = true;
            this.doktorcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.doktorcinsiyet.Location = new System.Drawing.Point(239, 371);
            this.doktorcinsiyet.Name = "doktorcinsiyet";
            this.doktorcinsiyet.Size = new System.Drawing.Size(415, 24);
            this.doktorcinsiyet.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(95, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "TELEFON :";
            // 
            // doktortel
            // 
            this.doktortel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktortel.Location = new System.Drawing.Point(239, 238);
            this.doktortel.Mask = "(9990) 000-0000";
            this.doktortel.Name = "doktortel";
            this.doktortel.Size = new System.Drawing.Size(415, 22);
            this.doktortel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "AD :";
            // 
            // doktorad
            // 
            this.doktorad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorad.Location = new System.Drawing.Point(239, 155);
            this.doktorad.Name = "doktorad";
            this.doktorad.Size = new System.Drawing.Size(415, 22);
            this.doktorad.TabIndex = 1;
            // 
            // doktorsoyad
            // 
            this.doktorsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorsoyad.Location = new System.Drawing.Point(239, 197);
            this.doktorsoyad.Name = "doktorsoyad";
            this.doktorsoyad.Size = new System.Drawing.Size(415, 22);
            this.doktorsoyad.TabIndex = 2;
            // 
            // doktorsifre
            // 
            this.doktorsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorsifre.Location = new System.Drawing.Point(239, 324);
            this.doktorsifre.Name = "doktorsifre";
            this.doktorsifre.PasswordChar = '•';
            this.doktorsifre.Size = new System.Drawing.Size(415, 22);
            this.doktorsifre.TabIndex = 5;
            // 
            // doktortc
            // 
            this.doktortc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktortc.Location = new System.Drawing.Point(239, 280);
            this.doktortc.Mask = "00000000000";
            this.doktortc.Name = "doktortc";
            this.doktortc.Size = new System.Drawing.Size(415, 22);
            this.doktortc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(847, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(875, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(725, 69);
            this.label3.TabIndex = 61;
            this.label3.Text = "DOKTOR KAYIT PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "TC :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(95, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "BRANŞ :";
            // 
            // doktorbrans
            // 
            this.doktorbrans.FormattingEnabled = true;
            this.doktorbrans.Location = new System.Drawing.Point(239, 416);
            this.doktorbrans.Name = "doktorbrans";
            this.doktorbrans.Size = new System.Drawing.Size(415, 24);
            this.doktorbrans.TabIndex = 7;
            // 
            // doktorkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.doktorbrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.doktorkaydet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.doktorcinsiyet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doktortel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doktorad);
            this.Controls.Add(this.doktorsoyad);
            this.Controls.Add(this.doktorsifre);
            this.Controls.Add(this.doktortc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doktorkayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktorkayit";
            this.Load += new System.EventHandler(this.doktorkayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doktorkaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox doktorcinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox doktortel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doktorad;
        private System.Windows.Forms.TextBox doktorsoyad;
        private System.Windows.Forms.TextBox doktorsifre;
        private System.Windows.Forms.MaskedTextBox doktortc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox doktorbrans;
    }
}