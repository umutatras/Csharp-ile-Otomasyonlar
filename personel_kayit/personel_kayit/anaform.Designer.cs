namespace personel_kayit
{
    partial class anaform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.textmaas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiobekar = new System.Windows.Forms.RadioButton();
            this.radioevli = new System.Windows.Forms.RadioButton();
            this.textmeslek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnist = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet1 = new personel_kayit.PersonelVeriTabaniDataSet1();
            this.personel_tabloTableAdapter = new personel_kayit.PersonelVeriTabaniDataSet1TableAdapters.personel_tabloTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combosehir);
            this.groupBox1.Controls.Add(this.textmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radiobekar);
            this.groupBox1.Controls.Add(this.radioevli);
            this.groupBox1.Controls.Add(this.textmeslek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt Alanı";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(227, 49);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(278, 30);
            this.textid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Personel İD :";
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Items.AddRange(new object[] {
            "Ankara ",
            "İstanbul",
            "Hatay",
            "Çankırı",
            "Balıkesir",
            "Çanakkale",
            "Adana",
            "Antalya",
            "Kars",
            "Mardin",
            "Malatya",
            "Zonguldak"});
            this.combosehir.Location = new System.Drawing.Point(227, 188);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(278, 33);
            this.combosehir.TabIndex = 4;
            // 
            // textmaas
            // 
            this.textmaas.Location = new System.Drawing.Point(227, 236);
            this.textmaas.Name = "textmaas";
            this.textmaas.Size = new System.Drawing.Size(278, 30);
            this.textmaas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Personel Maaş :";
            // 
            // radiobekar
            // 
            this.radiobekar.AutoSize = true;
            this.radiobekar.Location = new System.Drawing.Point(300, 272);
            this.radiobekar.Name = "radiobekar";
            this.radiobekar.Size = new System.Drawing.Size(89, 29);
            this.radiobekar.TabIndex = 7;
            this.radiobekar.TabStop = true;
            this.radiobekar.Text = "Bekar";
            this.radiobekar.UseVisualStyleBackColor = true;
            this.radiobekar.CheckedChanged += new System.EventHandler(this.radiobekar_CheckedChanged);
            // 
            // radioevli
            // 
            this.radioevli.AutoSize = true;
            this.radioevli.Location = new System.Drawing.Point(226, 272);
            this.radioevli.Name = "radioevli";
            this.radioevli.Size = new System.Drawing.Size(68, 29);
            this.radioevli.TabIndex = 6;
            this.radioevli.TabStop = true;
            this.radioevli.Text = "Evli";
            this.radioevli.UseVisualStyleBackColor = true;
            this.radioevli.CheckedChanged += new System.EventHandler(this.radioevli_CheckedChanged);
            // 
            // textmeslek
            // 
            this.textmeslek.Location = new System.Drawing.Point(227, 316);
            this.textmeslek.Name = "textmeslek";
            this.textmeslek.Size = new System.Drawing.Size(278, 30);
            this.textmeslek.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Personel Meslek :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personel Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Personel Şehir :";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(227, 140);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(278, 30);
            this.textsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Soyad :";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(227, 95);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(278, 30);
            this.textad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel AD :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btngrafik);
            this.groupBox2.Controls.Add(this.btnist);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(569, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // btngrafik
            // 
            this.btngrafik.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrafik.Location = new System.Drawing.Point(288, 110);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(204, 40);
            this.btngrafik.TabIndex = 7;
            this.btngrafik.Text = "GRAFİKLER";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnist
            // 
            this.btnist.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnist.Location = new System.Drawing.Point(78, 110);
            this.btnist.Name = "btnist";
            this.btnist.Size = new System.Drawing.Size(204, 39);
            this.btnist.TabIndex = 6;
            this.btnist.Text = "İSTATİSTİK";
            this.btnist.UseVisualStyleBackColor = true;
            this.btnist.Click += new System.EventHandler(this.btnist_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Location = new System.Drawing.Point(288, 29);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(204, 33);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(78, 71);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(204, 33);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Location = new System.Drawing.Point(288, 71);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(204, 33);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistele.Location = new System.Drawing.Point(78, 29);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(204, 33);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1058, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personeltabloBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "per_ad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "per_sehir";
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "per_maas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "per_maas";
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "per_durum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "per_durum";
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "per_meslek";
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            // 
            // personeltabloBindingSource
            // 
            this.personeltabloBindingSource.DataMember = "personel_tablo";
            this.personeltabloBindingSource.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_tabloTableAdapter
            // 
            this.personel_tabloTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(288, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "RAPORLAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1081, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textmeslek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobekar;
        private System.Windows.Forms.RadioButton radioevli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnist;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox textmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combosehir;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource personeltabloBindingSource;
        private PersonelVeriTabaniDataSet1TableAdapters.personel_tabloTableAdapter personel_tabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

