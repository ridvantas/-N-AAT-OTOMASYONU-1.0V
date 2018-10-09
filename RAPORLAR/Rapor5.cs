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
    public partial class Rapor5 : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public YASADIGI_YER_ANA_MENU a;
        public Rapor5()
        {
            InitializeComponent();
        }

        private void Rapor5_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr=new SqlDataAdapter("select * from peryasyer",con);
            adtr.Fill(tablo);
            CrystalReport1 rapor5=new CrystalReport1();
            rapor5.SetDataSource(tablo);
            crystalReportViewer1.ReportSource=rapor5;

        }
    }
}
