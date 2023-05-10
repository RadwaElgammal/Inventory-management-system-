using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Supp : Form
    {
        Context context = new Context();

        public Supp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            string tele = textBox3.Text;
            string fax = textBox4.Text;
            string mob = textBox5.Text;
            string email = textBox6.Text;
            string website = textBox7.Text;
            Suppliers sup = new Suppliers()
            {
                Name = Name,
                Telephone = tele,
                Fax = fax,
                Email = email,
                Website = website
            };
            context.Suppliers.Add(sup);
            context.SaveChanges();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
            AllSuppliers();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            AllSuppliers();
        }

        private void AllSuppliers()
        {
            var Suppliers = from supplier in context.Suppliers
                            where supplier != null
                            select supplier;
            foreach (var supplier in Suppliers)
            {
                if (supplier != null)
                {
                    listBox1.Items.Add(supplier.Name);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string tele = textBox3.Text;
            string fax = textBox4.Text;
            string mob = textBox5.Text;
            string email = textBox6.Text;
            string website = textBox7.Text;

            var selectedsupp = context.Suppliers.FirstOrDefault(x => x.Id == id);
            if (selectedsupp != null)
            {
                selectedsupp.Name = name;
                selectedsupp.Telephone = tele;
                selectedsupp.Mobile = mob;
                selectedsupp.Fax = fax;
                selectedsupp.Email = email;
                selectedsupp.Website = website;

                context.Suppliers.AddOrUpdate(selectedsupp);
                context.SaveChanges();
                MessageBox.Show("updated Supplier");
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                var item = context.Suppliers.FirstOrDefault(x => x.Name == selectedItem);
                if (item != null)
                {
                    textBox1.Text = item.Id.ToString();
                    textBox2.Text = item.Name;
                    textBox3.Text = item.Telephone;
                    textBox4.Text = item.Fax;
                    textBox5.Text = item.Mobile;
                    textBox6.Text = item.Email;
                    textBox7.Text = item.Website;

                }
            }
        }

        private void Supp_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
