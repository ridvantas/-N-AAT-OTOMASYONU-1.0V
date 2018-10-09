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
    public partial class yasadigiyerrapor : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public YASADIGI_YER_ANA_MENU x;
        public yasadigiyerrapor()
        {
            InitializeComponent();
        }

        private void yasadigiyerrapor_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer", con);
            adtr.Fill(tablo);
            CrystalReportyasadigiyer rapor = new CrystalReportyasadigiyer();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
