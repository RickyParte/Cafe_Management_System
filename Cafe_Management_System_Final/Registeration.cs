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
using System;

namespace Cafe_Management_System_Final
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void arcafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arcafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arcafe);

        }

        private void Registeration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arcafe._arcafe' table. You can move, or remove it, as needed.
            this.arcafeTableAdapter.Fill(this.arcafe._arcafe);
            nameTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            emailTextBox.Clear();
            mobilenoTextBox.Clear();
        }
        public static String n;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
          
                SqlConnection sn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\omkar_000\source\repos\Cafe_Management_System_Final\Cafe_Management_System_Final\Database1.mdf;Integrated Security=True");
                SqlCommand sc = new SqlCommand("Insert into arcafe  values ('" + nameTextBox.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "','" + emailTextBox.Text + "'," + mobilenoTextBox.Text + ")", sn);
                sn.Open();
                sc.ExecuteNonQuery();
                
                sn.Close();
                MessageBox.Show("SuccessFully Registered");
                nameTextBox.Clear();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                emailTextBox.Clear();
                mobilenoTextBox.Clear();

                

            }
            catch(Exception ex)
            {
                MessageBox.Show("exception");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
