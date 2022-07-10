namespace HastaneYönetimOtomasyon
{
    partial class doktorlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktorlogin));
            this.doktorsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doktorgiris = new System.Windows.Forms.Button();
            this.doktortc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hastauye = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // doktorsifre
            // 
            this.doktorsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktorsifre.Location = new System.Drawing.Point(270, 208);
            this.doktorsifre.Name = "doktorsifre";
            this.doktorsifre.PasswordChar = '•';
            this.doktorsifre.Size = new System.Drawing.Size(309, 22);
            this.doktorsifre.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(103, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(715, 69);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // doktorgiris
            // 
            this.doktorgiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.doktorgiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.doktorgiris.Location = new System.Drawing.Point(270, 307);
            this.doktorgiris.Name = "doktorgiris";
            this.doktorgiris.Size = new System.Drawing.Size(309, 61);
            this.doktorgiris.TabIndex = 23;
            this.doktorgiris.Text = "GİRİŞ";
            this.doktorgiris.UseVisualStyleBackColor = false;
            this.doktorgiris.Click += new System.EventHandler(this.doktorgiris_Click);
            // 
            // doktortc
            // 
            this.doktortc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doktortc.Location = new System.Drawing.Point(270, 166);
            this.doktortc.Mask = "00000000000";
            this.doktortc.Name = "doktortc";
            this.doktortc.Size = new System.Drawing.Size(309, 22);
            this.doktortc.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "TC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(801, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(829, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // hastauye
            // 
            this.hastauye.ActiveLinkColor = System.Drawing.Color.Blue;
            this.hastauye.AutoSize = true;
            this.hastauye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.hastauye.LinkColor = System.Drawing.Color.Black;
            this.hastauye.Location = new System.Drawing.Point(266, 251);
            this.hastauye.Name = "hastauye";
            this.hastauye.Size = new System.Drawing.Size(66, 20);
            this.hastauye.TabIndex = 29;
            this.hastauye.TabStop = true;
            this.hastauye.Text = "Üye Ol";
            this.hastauye.VisitedLinkColor = System.Drawing.Color.Black;
            this.hastauye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hastauye_LinkClicked);
            // 
            // doktorlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(862, 416);
            this.Controls.Add(this.hastauye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doktorsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doktorgiris);
            this.Controls.Add(this.doktortc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doktorlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktorlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doktorsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button doktorgiris;
        private System.Windows.Forms.MaskedTextBox doktortc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel hastauye;
    }
}