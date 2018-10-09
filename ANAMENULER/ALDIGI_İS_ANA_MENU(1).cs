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
    public partial class ALDIGI_İS_ANA_MENU : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        public SqlCommand kmt = new SqlCommand();
        public Aligiisrapor rpr;
        public Aldigiisguncelle b;
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;



        }
        public void arama()
        {
            
        }
        public ALDIGI_İS_ANA_MENU()       
        {
            InitializeComponent();
            b = new Aldigiisguncelle();
            b.a = this;
            rpr = new Aligiisrapor();
            rpr.x = this;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANA_MENÜ k = new ANA_MENÜ();
            k.Show();
            this.Hide();
            //Aldigi_is l = new Aldigi_is();
            //l.Show();
            //this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aldigi_is l = new Aldigi_is();
            l.Show();
            this.Hide();
        }

        private void ALDIGI_İS_ANA_MENU_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayac;
            sayac = dataGridView1.Rows.Count-1;
            textBox2.Text = sayac.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is where pernonel_no like '%" + textBox1.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP = MessageBox.Show("silmek istediğinizden eminmisiniz?","mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (CVP == DialogResult.Yes)
            {

                con.Open();
                kmt.Connection = con;
                kmt.CommandText = "Delete from aldigi_is where insaat_kodu='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt silindi...");
                listele();
               
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            b.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from aldigi_is where insaat_kodu like '%"+textBox3.Text+"%'",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            rpr.ShowDialog();

        }
    }
}
