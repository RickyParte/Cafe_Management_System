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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void arcafeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arcafeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.arcafe);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arcafe._arcafe' table. You can move, or remove it, as needed.
            this.arcafeTableAdapter.Fill(this.arcafe._arcafe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fd = new Form1();
            fd.Show();
            this.Hide();
        }
    }
}
