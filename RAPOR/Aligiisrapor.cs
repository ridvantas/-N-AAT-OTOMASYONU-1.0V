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
    public partial class Aligiisrapor : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public ALDIGI_İS_ANA_MENU x;
        public Aligiisrapor()
        {
            InitializeComponent();
        }

        private void Aligiisrapor_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is",con);
            adtr.Fill(tablo);
            CrystalReport1aldigiis rapor = new CrystalReport1aldigiis();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is where insaat_kodu='"+textBox1.Text+"'", con);
            adtr.Fill(tablo);
            CrystalReport1aldigiis rapor = new CrystalReport1aldigiis();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;

        }
    }
}
