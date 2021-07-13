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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        public static int buckle = 30, vanila = 20, snickerdoodle = 35, raspberry = 40, chocolatecake = 40, coffecake = 25, walnut = 50, banana = 40, mud = 45, velevet = 60;
        public static int butter = 80, pound = 70, carrot = 50, sponge = 90, genoise = 100, chiffon = 100, flourless = 90, devils = 80, hummingbird = 70, fruit = 60;
        public static int brew = 100, cafelait = 120, mocha = 130, flatwhite = 100, latte = 90, chocolate = 100, machiato = 150, eggnog = 100, americano = 200, caramel = 120;
        public static int coke = 20, sprite = 30, lift = 60, cokes = 50, pepsi = 35, fanta = 30, lemon = 20, vanilla = 50, strawb = 60, coffee = 30;

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
        }

        public static int totalcakeprice,totaldrinkprice,total;
        private void button1_Click(object sender, EventArgs e)
        {
            Receipt r = new Receipt();
            r.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            int cakeprice = int.Parse(textBox6.Text) * buckle + int.Parse(textBox1.Text) * vanila + int.Parse(textBox2.Text) * snickerdoodle + int.Parse(textBox3.Text) * raspberry + int.Parse(textBox4.Text) * coffecake + int.Parse(textBox5.Text) * chocolatecake + int.Parse(textBox7.Text) * walnut + int.Parse(textBox8.Text) * banana + int.Parse(textBox9.Text) * mud + int.Parse(textBox10.Text) * velevet;
            int cakeprices = int.Parse(textBox30.Text) * butter + int.Parse(textBox29.Text) * pound + int.Parse(textBox18.Text) * carrot + int.Parse(textBox17.Text) * genoise + int.Parse(textBox16.Text) * chiffon + int.Parse(textBox15.Text) * flourless + int.Parse(textBox14.Text) * devils + int.Parse(textBox13.Text) * hummingbird + int.Parse(textBox12.Text) * fruit + int.Parse(textBox11.Text) * sponge;
            int drink = int.Parse(textBox28.Text) * brew + int.Parse(textBox27.Text) * cafelait + int.Parse(textBox26.Text) * mocha + int.Parse(textBox25.Text) * flatwhite + int.Parse(textBox24.Text) * latte + int.Parse(textBox23.Text) * chocolate + int.Parse(textBox22.Text) * machiato + int.Parse(textBox21.Text) * eggnog + int.Parse(textBox20.Text) * americano + int.Parse(textBox19.Text) * caramel;
            int drinks = int.Parse(textBox40.Text) * coke + int.Parse(textBox39.Text) * sprite + int.Parse(textBox38.Text) * lift + int.Parse(textBox37.Text) * cokes + int.Parse(textBox36.Text) * pepsi + int.Parse(textBox35.Text) * fanta + int.Parse(textBox34.Text) * lemon + int.Parse(textBox33.Text) * vanilla + int.Parse(textBox32.Text) * strawb + int.Parse(textBox31.Text) * coffee;
            totalcakeprice = cakeprice + cakeprices;
            totaldrinkprice = drink + drinks;
            total = totalcakeprice + totaldrinkprice;
            textBox44.Text = Convert.ToString(totalcakeprice);
            textBox46.Text = Convert.ToString(totaldrinkprice);
            textBox45.Text = Convert.ToString(total);
            
        }
        
    
    }
}
