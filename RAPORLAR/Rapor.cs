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
    public partial class Rapor : Form
    {
        SqlConnection bag = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();

        public ALDIGI_İS_ANA_MENU a;
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is",bag);
            adtr.Fill(tablo);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource (tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
