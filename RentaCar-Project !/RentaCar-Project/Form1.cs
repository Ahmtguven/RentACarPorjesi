using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentaCar_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();

        public bool CLogin(string username, string password)
        {
            var customers = from user in coon.Customers where user.NameSurname == username && user.Password == password select user;

            if (customers.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ELogin(string username, string password)
        {
            var Employe = from admin in coon.Employees where admin.Name == username && admin.Password == password select admin;

            if (Employe.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CLogin(textBox1.Text, textBox2.Text))
            {
                Customerss page = new Customerss();
                page.Show();
                this.Hide();

            }
            else if (ELogin(textBox1.Text, textBox2.Text))
            {
                Employeess page1 = new Employeess();
                page1.Show();
                this.Hide();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
