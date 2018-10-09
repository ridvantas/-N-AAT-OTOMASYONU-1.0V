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
    public partial class YAPTIGI_IS_ANA_MENU : Form
    {
        SqlConnection con = new SqlConnection("data source=.;database=insaat;Integrated security=true");
        DataTable tablo = new DataTable();
        SqlCommand kmt = new SqlCommand();
        public yaptigiisrapor rpr;
        public Yaptigiisguncelle b;
        public YAPTIGI_IS_ANA_MENU()
        {
            InitializeComponent();
            b = new Yaptigiisguncelle();
            b.a = this;
            rpr = new yaptigiisrapor();
            rpr.x = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Yaptigi_İs m = new Yaptigi_İs();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANA_MENÜ p = new ANA_MENÜ();
            p.Show();
            this.Hide();
        }

        private void YAPTIGI_IS_ANA_MENU_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis",con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

            textBox2.Text = tablo.Rows.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int sayac;
            //sayac = dataGridView1.Rows.Count;
            //textBox2.Text = sayac.ToString();
        }
        public void listele()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult CVP;
            CVP=MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ?","mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(CVP==DialogResult.Yes){
            con.Open();
            kmt.Connection = con;
            kmt.CommandText = "delete from peryapis where id='"+ dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis where personel_no like '%" + textBox1.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from peryapis where ruhsat_no like '%" + textBox3.Text + "%'", con);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rpr.ShowDialog();

        }
    }
}
