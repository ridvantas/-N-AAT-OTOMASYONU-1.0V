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
    public partial class GOREVİ : Form
    {
        public SqlConnection ben = new SqlConnection("data source=.;database=insaat;Integrated security=SSPI");
        public SqlCommand knt = new SqlCommand();
        public GOREVİ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GOREVİ_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if(textBox4.Text!="" && textBox3.Text!="" && textBox2.Text!="" && textBox1.Text!="")
                {
            DialogResult SORU;
            SORU=MessageBox.Show("kaydetmek istediğinizden eminmisiniz...","mesaj" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(SORU==DialogResult.Yes){
               

            ben.Open();
            knt.Connection = ben;
            knt.CommandText = "insert into gorevi(no,gorev_kodu,gorev_adi,maas) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' )";
            knt.ExecuteNonQuery();
            ben.Close();
                    MessageBox.Show("kayıt başarılı...");
                    this.Close();
             
            }
                 else
                    MessageBox.Show("boş alanları doldurun...");
                

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
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

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}
    }

       
}
