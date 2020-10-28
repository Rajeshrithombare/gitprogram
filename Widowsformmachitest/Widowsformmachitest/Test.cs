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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        string subans;
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"data source=DESKTOP-6RGINGV\SQLEXPRESS;integrated security=true;database=TestDatabase");
            SqlCommand com = new SqlCommand(@"INSERT INTO [TestDatabase].[dbo].[Subanswers]
           ([submit])
            VALUES
           ('"+subans+"')",con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your answer is submited successfully");

            this.Hide();
            Test2 cs = new Test2();
            cs.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            subans = "It is an abstract class";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            subans = "It is an Concrete class";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            subans = "Both Option one and two";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            subans = "None";
        }
    }
}
