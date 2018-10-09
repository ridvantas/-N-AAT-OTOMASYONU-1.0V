using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace İNŞAAT_OTOMASYONU_1._0V
{
    public partial class ANA_MENÜ : Form
    {

        public ANA_MENÜ()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ALDIGI_İS_ANA_MENU b = new ALDIGI_İS_ANA_MENU();
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ANA_MENÜ_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GOREVİ_ANA_MENU d = new GOREVİ_ANA_MENU();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PERSONEL_ANA_MENU j = new PERSONEL_ANA_MENU();
            j.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YAPTIGI_IS_ANA_MENU l = new YAPTIGI_IS_ANA_MENU();
            l.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YASADIGI_YER_ANA_MENU n = new YASADIGI_YER_ANA_MENU();
            n.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            YAPI_ANA_MENU o = new YAPI_ANA_MENU();
            o.Show();
            this.Hide();
        }
    }
}
