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
    public partial class Test2 : Form
    {
        public Test2()
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
           ('" + subans + "')", con);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your answer is submited successfully");

            //this.Hide();
            //Test2 cs = new Test2();
            //cs.Show();
        }
    }
}
