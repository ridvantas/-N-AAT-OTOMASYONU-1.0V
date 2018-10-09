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
    public partial class Aldigi_is : Form
    {
        public SqlConnection bag = new SqlConnection("data source=.;database=insaat;Integrated security=True");
        public SqlCommand kmt = new SqlCommand();
        public Aldigi_is()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aldigi_is_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //Text = "Kayıt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                DialogResult CEVAP;
                CEVAP = MessageBox.Show("KAYDEDİLSİN Mİ?", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (CEVAP == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into aldigi_is(pernonel_no,insaat_kodu,ise_baslama_tarihi,bitis_tarihi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("kayıt başarılı");
                    this.Close();
                }
                else
                    MessageBox.Show("boş yerleri doldurun");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
