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
    public partial class yaptigiisrapor : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public YAPTIGI_IS_ANA_MENU x;
        public yaptigiisrapor()
        {
            InitializeComponent();
        }

        private void yaptigiisrapor_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis", con);
            adtr.Fill(tablo);
            CrystalReportyaptigiis rapor = new CrystalReportyaptigiis();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;


        }
    }
}
