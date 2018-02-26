using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_tabanı_oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\asus\documents\visual studio 2013\Projects\veri tabanı oluşturma\veri tabanı oluşturma\ogrenciisleri.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                MessageBox.Show("bağlantı başarılı");
            }
            catch(Exception)
            {
                MessageBox.Show("bağlantı hatası");
            }
            SqlCommand komut = new SqlCommand("select * from bolumler", con);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr[1]);

            }
            //else
            //{
            //    MessageBox.Show("okunamadıı");
            //}
               
        }
    }
}
