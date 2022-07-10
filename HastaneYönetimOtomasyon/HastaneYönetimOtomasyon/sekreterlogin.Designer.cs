namespace HastaneYönetimOtomasyon
{
    partial class sekreterlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterlogin));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sekretersifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sekreteruyeol = new System.Windows.Forms.LinkLabel();
            this.sekretergiris = new System.Windows.Forms.Button();
            this.sekretertc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(911, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(939, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sekretersifre
            // 
            this.sekretersifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretersifre.Location = new System.Drawing.Point(281, 234);
            this.sekretersifre.Name = "sekretersifre";
            this.sekretersifre.PasswordChar = '•';
            this.sekretersifre.Size = new System.Drawing.Size(309, 22);
            this.sekretersifre.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(114, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(783, 69);
            this.label3.TabIndex = 35;
            this.label3.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // sekreteruyeol
            // 
            this.sekreteruyeol.ActiveLinkColor = System.Drawing.Color.Blue;
            this.sekreteruyeol.AutoSize = true;
            this.sekreteruyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sekreteruyeol.LinkColor = System.Drawing.Color.Black;
            this.sekreteruyeol.Location = new System.Drawing.Point(277, 278);
            this.sekreteruyeol.Name = "sekreteruyeol";
            this.sekreteruyeol.Size = new System.Drawing.Size(66, 20);
            this.sekreteruyeol.TabIndex = 31;
            this.sekreteruyeol.TabStop = true;
            this.sekreteruyeol.Text = "Üye Ol";
            this.sekreteruyeol.VisitedLinkColor = System.Drawing.Color.Black;
            this.sekreteruyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sekreteruyeol_LinkClicked);
            // 
            // sekretergiris
            // 
            this.sekretergiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sekretergiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekretergiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekretergiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sekretergiris.Location = new System.Drawing.Point(281, 330);
            this.sekretergiris.Name = "sekretergiris";
            this.sekretergiris.Size = new System.Drawing.Size(309, 61);
            this.sekretergiris.TabIndex = 32;
            this.sekretergiris.Text = "GİRİŞ";
            this.sekretergiris.UseVisualStyleBackColor = false;
            this.sekretergiris.Click += new System.EventHandler(this.sekretergiris_Click);
            // 
            // sekretertc
            // 
            this.sekretertc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretertc.Location = new System.Drawing.Point(281, 192);
            this.sekretertc.Mask = "00000000000";
            this.sekretertc.Name = "sekretertc";
            this.sekretertc.Size = new System.Drawing.Size(309, 22);
            this.sekretertc.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "TC :";
            // 
            // sekreterlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(966, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sekretersifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sekreteruyeol);
            this.Controls.Add(this.sekretergiris);
            this.Controls.Add(this.sekretertc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sekreterlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sekreterlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sekretersifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel sekreteruyeol;
        private System.Windows.Forms.Button sekretergiris;
        private System.Windows.Forms.MaskedTextBox sekretertc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}