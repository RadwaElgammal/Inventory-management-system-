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

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        Context context = new Context();
        public Customers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AllCustomers();
        }

        private void AllCustomers()
        {
            var customers = from customer in context.Customers
                            where customer != null
                            select customer;
            foreach (var customer in customers)
            {
                if (customer != null)
                {
                    listBox1.Items.Add(customer.Name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            string tele = textBox3.Text;
            string fax = textBox4.Text;
            string mob= textBox5.Text;
            string email = textBox6.Text;
            string website = textBox7.Text;
            Customer cts = new Customer()
            {
                Name = Name,
                Telephone = tele,
                Fax = fax,
                Email = email,
                Website = website
            };
            context.Customers.Add(cts);
            context.SaveChanges();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text= textBox6.Text=textBox7.Text= "";
            AllCustomers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id =int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string tele = textBox3.Text;
            string fax = textBox4.Text;
            string mob = textBox5.Text;
            string email = textBox6.Text;
            string website = textBox7.Text;

            var selectedcust = context.Customers.FirstOrDefault(x=> x.Id == id);
            if (selectedcust!= null)
            {
                selectedcust.Name= name;
                selectedcust.Telephone= tele;
                selectedcust.Mobile= mob;
                selectedcust.Fax= fax;
                selectedcust.Email= email;
                selectedcust.Website= website;

                context.Customers.AddOrUpdate(selectedcust);
                context.SaveChanges();
                MessageBox.Show("updated Customer");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                var item = context.Customers.FirstOrDefault(x => x.Name == selectedItem);
                if (item != null)
                {
                    textBox1.Text =item.Id.ToString();
                    textBox2.Text= item.Name;
                    textBox3.Text= item.Telephone;
                    textBox4.Text= item.Fax;
                    textBox5.Text= item.Mobile;
                    textBox6.Text= item.Email;
                    textBox7.Text= item.Website;
                   
                }
            }
        }
    }
}
