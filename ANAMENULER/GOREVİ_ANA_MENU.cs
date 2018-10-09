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
    public partial class GOREVİ_ANA_MENU : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        public gorevirapor rpr;
        public goreviguncelle b;
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        public GOREVİ_ANA_MENU()
        {
            InitializeComponent();
            b=new goreviguncelle();
            b.a=this;
            rpr = new gorevirapor();
            rpr.x = this;
        }

        private void GOREVİ_ANA_MENU_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GOREVİ f = new GOREVİ();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ANA_MENÜ i = new ANA_MENÜ();
            i.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac;
            sayac = dataGridView1.Rows.Count-1;
            textBox2.Text = sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP = MessageBox.Show("silmek istediğinizden eminmisiniz?","mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (CVP == DialogResult.Yes)
            {
                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "Delete  from gorevi where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("bilgiler silindi...");
                listele();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi where no like '%"+textBox1.Text+"%'",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi where gorev_kodu like '%" + textBox3.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from gorevi where gorev_adi like '%" + textBox4.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rpr.ShowDialog();

        }
    }
}
