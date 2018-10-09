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
    public partial class YASADIGI_YER_ANA_MENU : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        public yasadigiyerrapor rpr;
        public yasadigiyerguncelle b;
        public YASADIGI_YER_ANA_MENU()
        {
            InitializeComponent();
            b = new yasadigiyerguncelle();
            b.a = this;
            rpr = new yasadigiyerrapor();
            rpr.x = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yasadigi_Yer p = new Yasadigi_Yer();
            p.Show();
            //this.Hide();
        }

        private void YASADIGI_YER_ANA_MENU_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            textBox2.Text = tablo.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANA_MENÜ z = new ANA_MENÜ();
            z.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // int sayac;
            //sayac = dataGridView1.Rows.Count;
           // textBox2.Text = sayac.ToString();
        }
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP = MessageBox.Show("silmek istediğinizden eminmisiniz","mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (CVP == DialogResult.Yes)
            {
                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "Delete from peryasyer where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt silindi...");
            }
                listele();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            b.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer where personelno like '%" + textBox1.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer where adres like '%" + textBox3.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryasyer where telefonno like '%" + textBox4.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rpr.ShowDialog();
        }
    }
}
