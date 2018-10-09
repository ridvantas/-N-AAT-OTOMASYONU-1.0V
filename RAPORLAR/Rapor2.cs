using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İNŞAAT_OTOMASYONU_1._0V
{
    public partial class Rapor2 : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public PERSONEL_ANA_MENU a;
        public Rapor2()
        {
            InitializeComponent();
        }

        private void Rapor2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from personel", con);
            adtr.Fill(tablo);
            CrystalReport2 rapor2 = new CrystalReport2();
            rapor2.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor2;


        }
    }
}
