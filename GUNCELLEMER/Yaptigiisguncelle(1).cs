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
    public partial class Yaptigiisguncelle : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        public YAPTIGI_IS_ANA_MENU a;
        public Yaptigiisguncelle()
        {
            InitializeComponent();
        }

        private void Yaptigiisguncelle_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBox1.Text = a.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = a.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = a.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = a.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = a.dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP = MessageBox.Show("Güncellemek istermisiniz", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CVP == DialogResult.Yes)
            {
                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "update peryapis set personel_no='" + textBox2.Text + "',ruhsat_no='" + textBox3.Text + "',baslama_tarihi='" + textBox4.Text + "',bitis_tarihi='" + textBox5.Text + "' where id='" + textBox1.Text + "'";
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("güncelleme başarılı..");
                a.listele();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
