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
    public partial class KAYIT : Form
    {
        public SqlConnection bag = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        public SqlCommand kmt = new SqlCommand();
        public KAYIT()
        {
            InitializeComponent();
        }

        private void KAYIT_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                DialogResult cevap;
                cevap = MessageBox.Show("kayıt yapılsın mı?", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into kullanici(adi,soyadi,kullanici_adi,parola) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("kayıt başarılı");
                }
                else
                    MessageBox.Show("boş yerleri doldurun?");
            }
            GİRİŞ x=new GİRİŞ();
            x.Show();
            this.Hide();

        }
    }
}
