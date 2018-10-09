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
    public partial class gorevirapor : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public GOREVİ_ANA_MENU x;
        public gorevirapor()
        {
            InitializeComponent();
        }

        private void gorevirapor_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi", con);
            adtr.Fill(tablo);
            CrystalReportgorevi rapor = new CrystalReportgorevi();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi where no='"+textBox1.Text+"'", con);
            adtr.Fill(tablo);
            CrystalReportgorevi rapor = new CrystalReportgorevi();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
           
        }
    }
}
