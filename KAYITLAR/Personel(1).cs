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
    public partial class Personel : Form
    {
        public SqlConnection bag =new SqlConnection("data source=.;database=insaat;Integrated security=True");
        public SqlCommand kmt = new SqlCommand();
        public Personel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " " && textBox3.Text != " " && textBox5.Text != " ")
            {
            DialogResult CEVAP;
            CEVAP = MessageBox.Show("kaydetmek istediğinizden eminmisiniz", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CEVAP == DialogResult.Yes)
            {
               
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "insert into personel(personel_no,adi,soyadi,yas) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            kmt.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("kayıt başarılı...");
            this.Close();
                }
                else
                    MessageBox.Show("boş alanları doldurun?");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
