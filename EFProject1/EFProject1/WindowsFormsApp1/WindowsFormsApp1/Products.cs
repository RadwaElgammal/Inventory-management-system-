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
    public partial class Products : Form
    {
        Context context = new Context();
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AllProducts();
        }

        private void AllProducts()
        {
            var products = from product in context.Products
                           where product != null
                           select product;
            foreach (var product in products)
            {
                if (product != null)
                {
                    listBox1.Items.Add(product.Name);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string code = textBox2.Text;
            string measure = textBox3.Text;
            int storeid =int.Parse(textBox5.Text);
            int prdid =int.Parse(textBox4.Text);

            var selectedPrd = context.Products.FirstOrDefault(x => x.Id == prdid);
            var selectedstore = context.Stores.FirstOrDefault(x=>x.Id== storeid);
            if(selectedPrd!=null && selectedstore!=null)
            {
                selectedPrd.Name = name;
                selectedPrd.Code= code;
                selectedPrd.UnitOfMeasure = measure;
                selectedPrd.StoreID= storeid;
                context.Products.AddOrUpdate(selectedPrd);
                context.SaveChanges();
                MessageBox.Show("updated product");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Name = textBox1.Text;
            string code = textBox2.Text;
            string unitMeasure = textBox3.Text;
            int storeid = int.Parse(textBox5.Text);
            Store store = context.Stores.FirstOrDefault(x=>x.Id == storeid);

            Product prd = new Product()
            {
                Name= Name,
                Code= code,
                UnitOfMeasure= unitMeasure,
                StoreID= storeid,
                AddDate = DateTime.Now,
            };

            context.Products.Add(prd);
            context.SaveChanges();

            textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = "";
            AllProducts();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                var item = context.Products.FirstOrDefault(x => x.Name == selectedItem);
                if (item != null)
                {
                    textBox4.Text = item.Id.ToString();
                    textBox1.Text = item.Name;
                    textBox2.Text = item.Code;
                    textBox3.Text = item.UnitOfMeasure;
                    textBox5.Text = item.StoreID.ToString();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
