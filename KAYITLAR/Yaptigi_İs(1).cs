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
    public partial class Yaptigi_İs : Form
    {
        public SqlConnection sen = new SqlConnection("data source=.;database=insaat;Integrated security=SSPI");
        public SqlCommand ben = new SqlCommand();
        public Yaptigi_İs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yaptigi_İs_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                DialogResult X;
                X = MessageBox.Show("KAYDETMEK İSTEDİGİNİZDEN EMİNMİSİNİZ", "mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {

                    sen.Open();
                    ben.Connection = sen;
                    ben.CommandText = "insert into peryapis(personel_no,ruhsat_no,baslama_tarihi,bitis_tarihi) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                    ben.ExecuteNonQuery();
                    sen.Close();
                    MessageBox.Show("kayıt başarılı..");
                    this.Close();
                }
                else
                    MessageBox.Show("boş yerleri doldurun");
            }
        }
    


    }
}
    
    
