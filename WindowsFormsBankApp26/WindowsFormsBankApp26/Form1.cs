using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewBankClaLibrary;
namespace WindowsFormsBankApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            int actno = int.Parse(textBox1.Text);
            int amt = int.Parse(textBox2.Text);
            string acttype = textBox3.Text;
            if(acttype=="Saving")
            {
                act = new Account.Saving();
            }
            else if(acttype=="Current")
            {
                act = new Account();
            }
            else
            {
                MessageBox.Show("enter saving or current");
                textBox3.Clear();
                textBox3.Focus();
            }
            if(act!=null)
            {
                act.ANumber = actno;
                string result = act.Deposite(amt);
                label4.Text = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(act!=null)
            {
                string result = act.Showdata();
                label4.Text = result;
            }
        }
    }
}
