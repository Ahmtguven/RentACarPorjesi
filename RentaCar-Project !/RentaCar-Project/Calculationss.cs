using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar_Project
{
    public partial class Calculationss : Form
    {
        public Calculationss()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Calculationss_Load(object sender, EventArgs e)
        {
            Employeess select = new Employeess();
 

            // var query = from user in coon.customers where user.customerNo == yoneticiKadi.ıd select user;

            //var query = from Car in coon.Cars where Car.CarID == textBox1.Text.ToString select Car;

            //foreach (var item in query)
            //{
            //    textBox1.Tag = Employeess.textBox1;
            //    textBox1.Text = item.Brand;
            //    textBox2.Text = item.Model;
            //    textBox3.Text = item.GearType;
            //    textBox4.Text = item.Year.ToString();
            //    textBox5.Text = item.Colour;
            //    textBox6.Text = item.FuelType;
            //    textBox7.Text = item.Cost.ToString();
            //    textBox8.Text = item.DonwPayment.ToString();

            //    textBox1.ReadOnly = true;
            //    textBox2.ReadOnly = true;
            //    textBox3.ReadOnly = true;
            //    textBox4.ReadOnly = true;
            //    textBox5.ReadOnly = true;
            //    textBox6.ReadOnly = true;
            //    textBox7.ReadOnly = true;
            //    textBox8.ReadOnly = true;
            //    textBox10.ReadOnly = true;


            //}
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double Day = Convert.ToDouble(textBox9.Text);
            double Dpayment = Convert.ToDouble(textBox8.Text);
            double Cst = Convert.ToDouble(textBox7.Text);

            double Sum = Day * Cst + Dpayment;

            textBox10.Text = Sum.ToString();
        }
    }
}
