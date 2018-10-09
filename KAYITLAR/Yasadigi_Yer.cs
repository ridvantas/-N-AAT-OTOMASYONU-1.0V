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
    public partial class Yasadigi_Yer : Form
    {
        public SqlConnection bag = new SqlConnection("data source=.;database=insaat;Integrated security=True");
        public SqlCommand kmt = new SqlCommand();
        public Yasadigi_Yer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yasadigi_Yer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DialogResult CEVAP;
                CEVAP = MessageBox.Show("kaydetmek istediğinizden eminmisiniz", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (CEVAP == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "insert into peryasyer(personelno,adres,telefonno) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    MessageBox.Show("kayıt başarılı...");
                    this.Hide();
                }
                else
                    MessageBox.Show("boş alanları doldurun?");
            }
        }

    }
}

