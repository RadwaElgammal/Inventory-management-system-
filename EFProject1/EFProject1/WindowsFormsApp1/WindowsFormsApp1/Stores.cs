using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace WindowsFormsApp1
{
    public partial class Stores : Form
    {
        Context context = new Context();

        public Stores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AllStores();
        }

        private void AllStores()
        {
            var stores = from store in context.Stores
                         where store != null
                         select store;


            foreach (var store in stores)
            {
                if (store != null)
                {
                    listBox1.Items.Add(store.Name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string Name = textBox1.Text;
            string address = textBox2.Text;
            int employeeid = int.Parse(textBox3.Text);
            Employee emp = context.Employees.FirstOrDefault(x => x.ID == employeeid);

            Store store = new Store()
            {
                Name = Name,
                Address = address,
                ResponsiblePerson = emp
            };

            context.Stores.Add(store);
            context.SaveChanges();
            MessageBox.Show("Successfuly added");
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            AllStores();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string address = textBox2.Text;
            int employeeid = int.Parse(textBox3.Text);
            int storeID = int.Parse(textBox4.Text);

            Employee emp = context.Employees.FirstOrDefault(x => x.ID == employeeid);
            var selectedStor = context.Stores.FirstOrDefault(x => x.Id == storeID);

            if (emp != null && storeID != null)
            {
                selectedStor.Name = Name;
                selectedStor.Address = address;
                selectedStor.ResponsiblePerson = emp;

                context.Stores.AddOrUpdate(selectedStor);
                MessageBox.Show("Updated");
                context.SaveChanges();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                var item = context.Stores.Include(a => a.ResponsiblePerson).FirstOrDefault(x => x.Name == selectedItem);
                if (item != null)
                {
                    textBox1.Text = item.Name;
                    textBox2.Text = item.Address;
                    textBox3.Text = item.ResponsiblePerson.ID.ToString();
                    textBox4.Text= item.Id.ToString();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
