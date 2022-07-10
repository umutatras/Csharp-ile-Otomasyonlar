using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_kayit
{
    public partial class raporform : Form
    {
        public raporform()
        {
            InitializeComponent();
        }

        private void raporform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PersonelVeriTabaniDataSet.personel_tablo' table. You can move, or remove it, as needed.
            this.personel_tabloTableAdapter.Fill(this.PersonelVeriTabaniDataSet.personel_tablo);

            this.reportViewer1.RefreshReport();
        }
    }
}
