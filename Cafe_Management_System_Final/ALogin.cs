using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System_Final
{
    public partial class ALogin : Form
    {
        public ALogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Arcafe" && textBox2.Text=="Arcafe")
            {
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
           

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
