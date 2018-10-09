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
    public partial class yapirapor : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public YAPI_ANA_MENU x;
        public yapirapor()
        {
            InitializeComponent();
        }

        private void yapirapor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * from yapi", con);
            adtr.Fill(tablo);
            CrystalReportyapi rapor = new CrystalReportyapi();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;


        }
    }
}
