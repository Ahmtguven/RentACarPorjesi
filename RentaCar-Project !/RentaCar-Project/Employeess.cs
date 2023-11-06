using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar_Project
{
    public partial class Employeess : Form
    {
        public Employeess()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        public void CarList()
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["CarID"].Value.ToString();
            textBox1.Text = satir.Cells["Brand"].Value.ToString();
            textBox2.Text = satir.Cells["Model"].Value.ToString();
            textBox3.Text = satir.Cells["GearType"].Value.ToString();
            textBox4.Text = satir.Cells["Year"].Value.ToString();
            textBox5.Text = satir.Cells["Colour"].Value.ToString();
            textBox6.Text = satir.Cells["FuelType"].Value.ToString();
            textBox7.Text = satir.Cells["Cost"].Value.ToString();
            textBox8.Text = satir.Cells["DownPayment"].Value.ToString();

        }

        private void Employeess_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Cars.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            var update = coon.Cars.Where(c => c.CarID == ID).FirstOrDefault();

            update.Brand = textBox1.Text;
            update.Model = textBox2.Text;
            update.GearType=textBox3.Text;
            update.Year = int.Parse(textBox4.Text);
            update.Colour=textBox5.Text;
            update.FuelType = textBox6.Text;
            update.Cost=decimal.Parse(textBox7.Text);
            update.DownPayment = decimal.Parse(textBox8.Text);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Cars.ToList();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car newcar = new Car();
            newcar.Brand = textBox1.Text;
            newcar.Model = textBox2.Text;
            newcar.GearType = textBox3.Text;
            newcar.Year = int.Parse(textBox4.Text);
            newcar.Colour = textBox5.Text;
            newcar.FuelType = textBox6.Text;
            newcar.Cost = decimal.Parse(textBox7.Text);
            newcar.DownPayment = decimal.Parse(textBox8.Text);
            coon.Cars.Add(newcar);
            coon.SaveChanges();
            
            dataGridView1.DataSource = coon.Cars.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ID =Convert.ToInt32(textBox1.Tag);

            var delete = coon.Cars.Where(z => z.CarID == ID).FirstOrDefault();
            coon.Cars.Remove(delete);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Cars.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Substationss bayi = new Substationss();
            bayi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculationss page = new Calculationss();
            page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = coon.Cars.Where(x => x.Brand.Contains(textBox1.Text)).ToList();
        }
    }
}
