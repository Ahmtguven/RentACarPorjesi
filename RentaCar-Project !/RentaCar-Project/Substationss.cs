using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentaCar_Project
{
    public partial class Substationss : Form
    {
        public Substationss()
        {
            InitializeComponent();
        }
        RentaCarEntities coon = new RentaCarEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);

            var substation = coon.Substations.Where(z => z.SubstationID == ID).FirstOrDefault();

            substation.Name = textBox1.Text;
            substation.NOEmployees = int.Parse(textBox2.Text);
            substation.Endorsement = decimal.Parse(textBox3.Text);
            coon.Substations.Add(substation);
            coon.SaveChanges();

            dataGridView1.DataSource = coon.Substations.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            Substation update = coon.Substations.Where(a =>a.SubstationID == ID).FirstOrDefault();

            update.Name = textBox1.Text;
            update.NOEmployees= int.Parse(textBox2.Text);
            update.Endorsement= decimal.Parse(textBox3.Text);
            coon.Substations.AddOrUpdate(update);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Substations.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Tag);
            Substation delete = coon.Substations.Where(x =>x.SubstationID==ID).FirstOrDefault();
            coon.Substations.Remove(delete);
            coon.SaveChanges();
            dataGridView1.DataSource = coon.Substations.ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["SubstationID"].Value.ToString();
            textBox1.Text = column.Cells["Name"].Value.ToString();
            textBox2.Text = column.Cells["NOEmployees"].Value.ToString();
            textBox3.Text = column.Cells["Endorsement"].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
