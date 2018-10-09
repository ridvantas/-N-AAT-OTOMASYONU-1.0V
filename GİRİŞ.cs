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
    public partial class GİRİŞ : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                con.Open();
                SqlCommand kmt = new SqlCommand("select * from kullanici where kullanici_adi=@isim and parola=@sifre",con);
                //kmt.Connection = con;
                kmt.Parameters.AddWithValue("@isim", textBox1.Text);
                kmt.Parameters.AddWithValue("@sifre", textBox2.Text);
                object id = kmt.ExecuteScalar();
                con.Close();
                if (Convert.ToInt32(id) >= 1)
                {

                    ANA_MENÜ k = new ANA_MENÜ();
                    k.Show();
                }
                    
                else
                    MessageBox.Show("hatalı giriş");
                this.Hide();
            }
                else
                MessageBox.Show("boş alanları doldurnuz");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
