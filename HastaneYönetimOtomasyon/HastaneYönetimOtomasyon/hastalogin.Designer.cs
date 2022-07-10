namespace HastaneYönetimOtomasyon
{
    partial class hastalogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastalogin));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastatc = new System.Windows.Forms.MaskedTextBox();
            this.hastagiris = new System.Windows.Forms.Button();
            this.hastauye = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.hastasifrelogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(755, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(783, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ŞİFRE :";
            // 
            // hastatc
            // 
            this.hastatc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hastatc.Location = new System.Drawing.Point(246, 182);
            this.hastatc.Mask = "00000000000";
            this.hastatc.Name = "hastatc";
            this.hastatc.Size = new System.Drawing.Size(309, 22);
            this.hastatc.TabIndex = 1;
            // 
            // hastagiris
            // 
            this.hastagiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hastagiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastagiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastagiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.hastagiris.Location = new System.Drawing.Point(246, 320);
            this.hastagiris.Name = "hastagiris";
            this.hastagiris.Size = new System.Drawing.Size(309, 61);
            this.hastagiris.TabIndex = 4;
            this.hastagiris.Text = "GİRİŞ";
            this.hastagiris.UseVisualStyleBackColor = false;
            this.hastagiris.Click += new System.EventHandler(this.hastagiris_Click);
            // 
            // hastauye
            // 
            this.hastauye.ActiveLinkColor = System.Drawing.Color.Blue;
            this.hastauye.AutoSize = true;
            this.hastauye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.hastauye.LinkColor = System.Drawing.Color.Black;
            this.hastauye.Location = new System.Drawing.Point(242, 268);
            this.hastauye.Name = "hastauye";
            this.hastauye.Size = new System.Drawing.Size(66, 20);
            this.hastauye.TabIndex = 3;
            this.hastauye.TabStop = true;
            this.hastauye.Text = "Üye Ol";
            this.hastauye.VisitedLinkColor = System.Drawing.Color.Black;
            this.hastauye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hastauye_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(657, 69);
            this.label3.TabIndex = 19;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            // 
            // hastasifrelogin
            // 
            this.hastasifrelogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hastasifrelogin.Location = new System.Drawing.Point(246, 224);
            this.hastasifrelogin.Name = "hastasifrelogin";
            this.hastasifrelogin.PasswordChar = '•';
            this.hastasifrelogin.Size = new System.Drawing.Size(309, 22);
            this.hastasifrelogin.TabIndex = 2;
            // 
            // hastalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(816, 404);
            this.Controls.Add(this.hastasifrelogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hastauye);
            this.Controls.Add(this.hastagiris);
            this.Controls.Add(this.hastatc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hastalogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hastalogin";
            this.Load += new System.EventHandler(this.hastalogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox hastatc;
        private System.Windows.Forms.Button hastagiris;
        private System.Windows.Forms.LinkLabel hastauye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hastasifrelogin;
    }
}