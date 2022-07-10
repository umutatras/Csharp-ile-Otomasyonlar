namespace HastaneYönetimOtomasyon
{
    partial class sekreterguncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sekreterguncelleme));
            this.sekretergun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sekretertelgun = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sekreteradgun = new System.Windows.Forms.TextBox();
            this.sekretersoyadgun = new System.Windows.Forms.TextBox();
            this.sekretersifregun = new System.Windows.Forms.TextBox();
            this.sekretertcgun = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sekretergun
            // 
            this.sekretergun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sekretergun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekretergun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekretergun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.sekretergun.Location = new System.Drawing.Point(243, 394);
            this.sekretergun.Name = "sekretergun";
            this.sekretergun.Size = new System.Drawing.Size(415, 61);
            this.sekretergun.TabIndex = 6;
            this.sekretergun.Text = "GÜNCELLE";
            this.sekretergun.UseVisualStyleBackColor = false;
            this.sekretergun.Click += new System.EventHandler(this.sekretergun_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(99, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "TELEFON :";
            // 
            // sekretertelgun
            // 
            this.sekretertelgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretertelgun.Location = new System.Drawing.Point(243, 243);
            this.sekretertelgun.Mask = "(9990) 000-0000";
            this.sekretertelgun.Name = "sekretertelgun";
            this.sekretertelgun.Size = new System.Drawing.Size(415, 22);
            this.sekretertelgun.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(99, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "AD :";
            // 
            // sekreteradgun
            // 
            this.sekreteradgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekreteradgun.Location = new System.Drawing.Point(243, 160);
            this.sekreteradgun.Name = "sekreteradgun";
            this.sekreteradgun.Size = new System.Drawing.Size(415, 22);
            this.sekreteradgun.TabIndex = 1;
            // 
            // sekretersoyadgun
            // 
            this.sekretersoyadgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretersoyadgun.Location = new System.Drawing.Point(243, 202);
            this.sekretersoyadgun.Name = "sekretersoyadgun";
            this.sekretersoyadgun.Size = new System.Drawing.Size(415, 22);
            this.sekretersoyadgun.TabIndex = 2;
            // 
            // sekretersifregun
            // 
            this.sekretersifregun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretersifregun.Location = new System.Drawing.Point(243, 329);
            this.sekretersifregun.Name = "sekretersifregun";
            this.sekretersifregun.Size = new System.Drawing.Size(415, 22);
            this.sekretersifregun.TabIndex = 5;
            // 
            // sekretertcgun
            // 
            this.sekretertcgun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sekretertcgun.Location = new System.Drawing.Point(243, 285);
            this.sekretertcgun.Mask = "00000000000";
            this.sekretertcgun.Name = "sekretertcgun";
            this.sekretertcgun.Size = new System.Drawing.Size(415, 22);
            this.sekretertcgun.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(941, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 95;
            this.label6.Text = "-";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(969, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(943, 55);
            this.label3.TabIndex = 93;
            this.label3.Text = "SEKRETER BİLGİ DÜZENLEME PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "ŞİFRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "TC :";
            // 
            // sekreterguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(995, 474);
            this.Controls.Add(this.sekretergun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sekretertelgun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sekreteradgun);
            this.Controls.Add(this.sekretersoyadgun);
            this.Controls.Add(this.sekretersifregun);
            this.Controls.Add(this.sekretertcgun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sekreterguncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sekreterguncelleme";
            this.Load += new System.EventHandler(this.sekreterguncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekretergun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox sekretertelgun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sekreteradgun;
        private System.Windows.Forms.TextBox sekretersoyadgun;
        private System.Windows.Forms.TextBox sekretersifregun;
        private System.Windows.Forms.MaskedTextBox sekretertcgun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}