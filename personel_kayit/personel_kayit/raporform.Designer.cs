namespace personel_kayit
{
    partial class raporform
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonelVeriTabaniDataSet = new personel_kayit.PersonelVeriTabaniDataSet();
            this.personel_tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_tabloTableAdapter = new personel_kayit.PersonelVeriTabaniDataSetTableAdapters.personel_tabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_tabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personel_tabloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "personel_kayit.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1159, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonelVeriTabaniDataSet
            // 
            this.PersonelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.PersonelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_tabloBindingSource
            // 
            this.personel_tabloBindingSource.DataMember = "personel_tablo";
            this.personel_tabloBindingSource.DataSource = this.PersonelVeriTabaniDataSet;
            // 
            // personel_tabloTableAdapter
            // 
            this.personel_tabloTableAdapter.ClearBeforeFill = true;
            // 
            // raporform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 521);
            this.Controls.Add(this.reportViewer1);
            this.Name = "raporform";
            this.Text = "raporform";
            this.Load += new System.EventHandler(this.raporform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_tabloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personel_tabloBindingSource;
        private PersonelVeriTabaniDataSet PersonelVeriTabaniDataSet;
        private PersonelVeriTabaniDataSetTableAdapters.personel_tabloTableAdapter personel_tabloTableAdapter;
    }
}