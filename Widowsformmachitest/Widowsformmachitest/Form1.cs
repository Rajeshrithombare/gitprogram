using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Widowsformmachitest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-6RGINGV\SQLEXPRESS;integrated security=true;database=TestDatabase");
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from LoginWindo where UserName='" + textBox1.Text + "'and Password='" + textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Register cs = new Register();
                cs.Show();
            }
            else
            {
                MessageBox.Show("Please check your name and password");
            }


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register cs = new Register();
            cs.Show();
        }
    }
}
