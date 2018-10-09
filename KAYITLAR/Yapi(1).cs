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
    public partial class Yapi : Form
    {
        public SqlConnection bag = new SqlConnection("data source=.;database=insaat;Integrated security=True");
        public SqlCommand kmt = new SqlCommand();
        public Yapi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yapi_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult SORU;
            SORU = MessageBox.Show("kaydetmek istediğinizden eminmisiniz...", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SORU == DialogResult.Yes)
            {
                if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into yapi(ruhsat_no,yapi_adi,yapi_turu,mevkii) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("kayıt başarılı...");
                    this.Close();
                }
                else
                    MessageBox.Show("boş alanları doldurun...");
            }
            else
                this.Close();
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

       
