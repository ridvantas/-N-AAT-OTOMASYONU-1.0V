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
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Text = "Giriş";
            label3.Text = "HOŞGELDİNİZ...";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANA_MENÜ a=new ANA_MENÜ();
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text[0].ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            KAYIT a = new KAYIT();
            a.Show();
            this.Hide();
        }
    }
}
