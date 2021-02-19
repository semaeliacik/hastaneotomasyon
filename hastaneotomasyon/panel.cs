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

namespace hastaneotomasyon
{
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
          
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = txtisim.Text;
                Int64 tc = Convert.ToInt64(txttc.Text);
                string adres = txtadres.Text;
                Int64 tel = Convert.ToInt64(txttel.Text);
                int yas = Convert.ToInt32(txtyas.Text);
                string cinsiyet = combocinsiyet.Text;
                string kan = txtkan.Text;
                string hastalık = txthastalık.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=.\\SQLEXPRESS;database=hastane2;integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values('"+isim+ "','" + tc + "','" + adres + "','" + tel + "','" + yas + "','" + cinsiyet + "','" + kan + "','" + hastalık + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }


            catch (Exception)
            {
                MessageBox.Show("Geçersiz veri girişi ");
            }








            MessageBox.Show("Kaydedildi");
            txtisim.Clear();
            txttc.Clear();
            txtadres.Clear();
            txttel.Clear();
            txtyas.Clear();
            combocinsiyet.ResetText();
            txtkan.Clear();
            txthastalık.Clear();





        





        }





        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=.\\SQLEXPRESS;database=hastane2;integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
