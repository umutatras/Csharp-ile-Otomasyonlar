namespace HastaneYönetimOtomasyon
{
    partial class doktordetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doktordetay));
            this.randevulist = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.doktorbilgi = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sikayetric = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doktorbilgiad = new System.Windows.Forms.Label();
            this.labels2 = new System.Windows.Forms.Label();
            this.doktorbilgitc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.randevulist)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // randevulist
            // 
            this.randevulist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randevulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevulist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randevulist.Location = new System.Drawing.Point(3, 32);
            this.randevulist.Name = "randevulist";
            this.randevulist.RowTemplate.Height = 24;
            this.randevulist.Size = new System.Drawing.Size(622, 553);
            this.randevulist.TabIndex = 0;
            this.randevulist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevulist_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.randevulist);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.groupBox3.Location = new System.Drawing.Point(516, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 588);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU LİSTESİ";
            // 
            // doktorbilgi
            // 
            this.doktorbilgi.ActiveLinkColor = System.Drawing.Color.Blue;
            this.doktorbilgi.AutoSize = true;
            this.doktorbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.doktorbilgi.LinkColor = System.Drawing.Color.Black;
            this.doktorbilgi.Location = new System.Drawing.Point(23, 168);
            this.doktorbilgi.Name = "doktorbilgi";
            this.doktorbilgi.Size = new System.Drawing.Size(164, 20);
            this.doktorbilgi.TabIndex = 33;
            this.doktorbilgi.TabStop = true;
            this.doktorbilgi.Text = "Bilgilerini Düzenle";
            this.doktorbilgi.VisitedLinkColor = System.Drawing.Color.Black;
            this.doktorbilgi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.randevubilgi_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sikayetric);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(4, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 248);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // sikayetric
            // 
            this.sikayetric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sikayetric.Location = new System.Drawing.Point(3, 32);
            this.sikayetric.Name = "sikayetric";
            this.sikayetric.Size = new System.Drawing.Size(500, 213);
            this.sikayetric.TabIndex = 3;
            this.sikayetric.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 1;
            // 
            // doktorbilgiad
            // 
            this.doktorbilgiad.AutoSize = true;
            this.doktorbilgiad.Location = new System.Drawing.Point(202, 111);
            this.doktorbilgiad.Name = "doktorbilgiad";
            this.doktorbilgiad.Size = new System.Drawing.Size(0, 30);
            this.doktorbilgiad.TabIndex = 3;
            // 
            // labels2
            // 
            this.labels2.AutoSize = true;
            this.labels2.Location = new System.Drawing.Point(22, 111);
            this.labels2.Name = "labels2";
            this.labels2.Size = new System.Drawing.Size(153, 30);
            this.labels2.TabIndex = 2;
            this.labels2.Text = "AD SOYAD :";
            // 
            // doktorbilgitc
            // 
            this.doktorbilgitc.AutoSize = true;
            this.doktorbilgitc.Location = new System.Drawing.Point(202, 59);
            this.doktorbilgitc.Name = "doktorbilgitc";
            this.doktorbilgitc.Size = new System.Drawing.Size(0, 30);
            this.doktorbilgitc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doktorbilgi);
            this.groupBox1.Controls.Add(this.doktorbilgiad);
            this.groupBox1.Controls.Add(this.labels2);
            this.groupBox1.Controls.Add(this.doktorbilgitc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 206);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1123, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1095, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(6, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 122);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HIZLI ERİŞİM";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(205, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "İNTERNET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "DUYURULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doktordetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1160, 623);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doktordetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doktordetay";
            this.Load += new System.EventHandler(this.doktordetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevulist)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView randevulist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel doktorbilgi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox sikayetric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label doktorbilgiad;
        private System.Windows.Forms.Label labels2;
        private System.Windows.Forms.Label doktorbilgitc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}