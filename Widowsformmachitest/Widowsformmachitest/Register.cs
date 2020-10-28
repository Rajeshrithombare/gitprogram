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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"data source=DESKTOP-6RGINGV\SQLEXPRESS;integrated security=true;database=TestDatabase");
            string fn = textBox1.Text;
            string ln = textBox2.Text;
            string email = textBox3.Text;
            string add = textBox4.Text;
            string pass = textBox5.Text;
            string pno = textBox6.Text;
            string sub = "";
            if(grp.Checked)
            {
                sub = grp.Text;
            }
            else if(radioButton2.Checked)
            {
                sub = radioButton2.Text;
            }
            else
            {
                sub = radioButton3.Text;
            }


            string tech = "";
            if(checkBox1.Checked)
            {
                tech = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                tech = checkBox2.Text;
            }
            else if(checkBox3.Checked)
            {
                tech = checkBox3.Text;
            }
            else
            {
                tech = checkBox4.Text;
            }
           
            string exp = comboBox1.Text;
            try
            {
                con2.Open();
                string qr= "insert into RegisterWindo(First_Name,Last_Name,Email_Id,Address,Password,Phone_No,Subcription,Technology,Experience) values('" + fn+"','"+ln+"','"+email+"','"+add+"','"+pass+"','"+pno+"','"+sub+"','"+tech+"','"+exp+"')";
                SqlCommand com = new SqlCommand(qr, con2);
                com.ExecuteNonQuery();
                this.Hide();
                Test cs = new Test();
                cs.Show();
               

            }
            catch (Exception ee)
            {
                
                ee.ToString();

            }
            finally
            {
                con2.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            grp.Checked=false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            comboBox1.SelectedItem = false;

        }
    }
}
