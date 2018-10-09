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
    public partial class Aldigiisguncelle : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        public ALDIGI_İS_ANA_MENU a;
        public Aldigiisguncelle()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aldigiisguncelle_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBox5.Text = a.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = a.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = a.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = a.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = a.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP = MessageBox.Show("Güncellemek istermisiniz...","mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (CVP == DialogResult.Yes)
            {
                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "Update aldigi_is set  pernonel_no='" + textBox1.Text + "',insaat_kodu='" + textBox2.Text + "',ise_baslama_tarihi='" + textBox3.Text + "',bitis_tarihi='" + textBox4.Text + "'  where id='" + textBox5.Text + "'";
                kmt.ExecuteNonQuery();
                con.Close();
                a.listele();
                MessageBox.Show("Güncelleme başarılı..");
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
