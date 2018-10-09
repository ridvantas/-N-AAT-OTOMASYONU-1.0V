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
    public partial class Rapor3 : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public YAPTIGI_IS_ANA_MENU a;
        public Rapor3()
        {
            InitializeComponent();
        }

        private void Rapor3_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis", con);
            adtr.Fill(tablo);
            CrystalReport1 rapor3 = new CrystalReport1();
            rapor3.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor3;

        }
    }
}
