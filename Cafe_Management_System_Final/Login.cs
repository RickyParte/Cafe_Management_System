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

namespace Cafe_Management_System_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void arcafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arcafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arcafe);

        }
      
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arcafe._arcafe' table. You can move, or remove it, as needed.
            this.arcafeTableAdapter.Fill(this.arcafe._arcafe);

            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registeration r = new Registeration();
            this.Hide();
            r.Show();
        }
        public static String n;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omkar_000\source\repos\Cafe_Management_System_Final\Cafe_Management_System_Final\Database1.mdf;Integrated Security=True");
            sn.Open();
            String quey = "Select * from arcafe  where username='" + usernameTextBox.Text.Trim() + "' and password='" + passwordTextBox.Text.Trim() + "'";
            SqlDataAdapter sd = new SqlDataAdapter(quey, sn);
            DataTable dbt = new DataTable();
            sd.Fill(dbt);
            n = usernameTextBox.Text;
            if (dbt.Rows.Count == 1)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();

            }
            else
            {
                MessageBox.Show("please check your uname and pass");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 ads = new Form1();
            ads.Show();
            this.Hide();
        }
    }
}
