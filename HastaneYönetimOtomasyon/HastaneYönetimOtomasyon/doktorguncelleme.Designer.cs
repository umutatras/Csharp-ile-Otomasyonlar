namespace HastaneYönetimOtomasyon
{
    partial class doktorguncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorguncelleme));
            this.doktorbransgun = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.doktorgun = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.doktorcinsiyetgun = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.doktortelgun = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doktoradgun = new System.Windows.Forms.TextBox();
            this.doktorsoyadgun = new System.Windows.Forms.TextBox();
            this.doktorsifregun = new System.Windows.Forms.TextBox();
            this.doktortcgun = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorbransgun
            // 
            this.doktorbransgun.FormattingEnabled = true;
            this.doktorbransgun.Location = new System.Drawing.Point(296, 411);
            this.doktorbransgun.Name = "doktorbransgun";
            this.doktorbransgun.Size = new System.Drawing.Size(415, 24);
            this.doktorbransgun.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(152, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 86;
            this.label10.Text = "BRANŞ :";
            // 
            // doktorgun
            // 
            this.doktorgun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.doktorgun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorgun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.doktorgun.Location = new System.Drawing.Point(231, 476);
            this.doktorgun.Name = "doktorgun";
            this.doktorgun.Size = new System.Drawing.Size(160, 61);
            this.doktorgun.TabIndex = 8;
            this.doktorgun.Text = "GÜNCELLE";
            this.doktorgun.UseVisualStyleBackColor = false;
            this.doktorgun.Click += new System.EventHandler(this.doktorgun_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(151, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "CİNSİYET :";
            // 
            // doktorcinsiyetgun
            // 
            this.doktorcinsiyetgun.FormattingEnabled = true;
            this.doktorcinsiyetgun.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.doktorcinsiyetgun.Location = new System.Drawing.Point(296, 366);
            this.doktorcinsiyetgun.Name = "doktorcinsiyetgun";
            this.doktorcinsiyetgun.Size = new System.Drawing.Size(415, 24);
            this.doktorcinsiyetgun.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(152, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "TELEFON :";
            // 
            // doktortelgun
            // 
            this.doktortelgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktortelgun.Location = new System.Drawing.Point(296, 233);
            this.doktortelgun.Mask = "(9990) 000-0000";
            this.doktortelgun.Name = "doktortelgun";
            this.doktortelgun.Size = new System.Drawing.Size(415, 22);
            this.doktortelgun.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(152, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(152, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "AD :";
            // 
            // doktoradgun
            // 
            this.doktoradgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktoradgun.Location = new System.Drawing.Point(296, 150);
            this.doktoradgun.Name = "doktoradgun";
            this.doktoradgun.Size = new System.Drawing.Size(415, 22);
            this.doktoradgun.TabIndex = 1;
            // 
            // doktorsoyadgun
            // 
            this.doktorsoyadgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorsoyadgun.Location = new System.Drawing.Point(296, 192);
            this.doktorsoyadgun.Name = "doktorsoyadgun";
            this.doktorsoyadgun.Size = new System.Drawing.Size(415, 22);
            this.doktorsoyadgun.TabIndex = 2;
            // 
            // doktorsifregun
            // 
            this.doktorsifregun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorsifregun.Location = new System.Drawing.Point(296, 319);
            this.doktorsifregun.Name = "doktorsifregun";
            this.doktorsifregun.Size = new System.Drawing.Size(415, 22);
            this.doktorsifregun.TabIndex = 5;
            // 
            // doktortcgun
            // 
            this.doktortcgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktortcgun.Location = new System.Drawing.Point(296, 275);
            this.doktortcgun.Mask = "00000000000";
            this.doktortcgun.Name = "doktortcgun";
            this.doktortcgun.Size = new System.Drawing.Size(415, 22);
            this.doktortcgun.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(904, -3);
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
            this.label5.Location = new System.Drawing.Point(932, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(887, 55);
            this.label3.TabIndex = 79;
            this.label3.Text = "DOKTOR BİLGİ DÜZENLEME PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "TC :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(397, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 61);
            this.button1.TabIndex = 87;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(563, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 61);
            this.button2.TabIndex = 88;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doktorguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doktorbransgun);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.doktorgun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.doktorcinsiyetgun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doktortelgun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doktoradgun);
            this.Controls.Add(this.doktorsoyadgun);
            this.Controls.Add(this.doktorsifregun);
            this.Controls.Add(this.doktortcgun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doktorguncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktorguncelleme";
            this.Load += new System.EventHandler(this.doktorguncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox doktorbransgun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button doktorgun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox doktorcinsiyetgun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox doktortelgun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doktoradgun;
        private System.Windows.Forms.TextBox doktorsoyadgun;
        private System.Windows.Forms.TextBox doktorsifregun;
        private System.Windows.Forms.MaskedTextBox doktortcgun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}