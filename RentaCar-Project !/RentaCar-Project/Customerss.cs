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
    public partial class Customerss : Form
    {
        public Customerss()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();

        private void Customerss_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Cars.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["CarID"].Value.ToString();
            textBox1.Text = column.Cells["Brand"].Value.ToString();
            textBox2.Text = column.Cells["Model"].Value.ToString();
            textBox3.Text = column.Cells["GearType"].Value.ToString();
            textBox4.Text = column.Cells["Year"].Value.ToString();
            textBox5.Text = column.Cells["Colour"].Value.ToString();
            textBox6.Text = column.Cells["Fueltype"].Value.ToString();
            textBox7.Text = column.Cells["Cost"].Value.ToString();
            textBox8.Text = column.Cells["DownPayment"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculationss gonder = new Calculationss();
            //textBox1.Text = gonder.textBox1_TextChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Cars.Where(x => x.Brand.Contains(textBox1.Text)).ToList();
        }
    }
}
