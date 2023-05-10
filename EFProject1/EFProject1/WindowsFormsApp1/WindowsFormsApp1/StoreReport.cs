using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Data.Entity;


namespace WindowsFormsApp1
{
    public partial class StoreReport : Form
    {
        Context context = new Context();
        public StoreReport()
        {
            InitializeComponent();
            ListAllStores();
        }

        public void ListAllStores()
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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStore = listBox1.SelectedItem as string;
            if (selectedStore != null)
            {
                var item = context.Stores.Include(a => a.ResponsiblePerson).FirstOrDefault(s => s.Name == selectedStore);
                if (item != null)
                {
                    textBox1.Text = item.Id.ToString();
                    textBox2.Text = item.Name;
                    textBox3.Text = item.Address;
                    textBox4.Text = item.ResponsiblePerson.Name;
                }
                DataGridViewRow row = new DataGridViewRow();
                

                var expermit = from ex in context.ExchangePermit
                               where ex.StoreId == item.Id
                               select ex;
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewCell cell2 = new DataGridViewTextBoxCell();


                if (expermit != null)
                {
                    foreach (var i in expermit)
                    {
                        cell1.Value = i.ExchangeNumber;
                        cell2.Value = i.ExchangeDate;
                        row.Cells.Add(cell1);
                        row.Cells.Add(cell2);
                    }

                
                }
                else
                {
                    return;
                }
                DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                DataGridViewCell cell4 = new DataGridViewTextBoxCell();

                var impPermit = from import in context.ImportPermit
                                where import.StoreId == item.Id
                                select import;
                if(impPermit!=null)
                {
                    foreach(var importitem in impPermit)
                    {
                        cell3.Value = importitem.PermitNumber;
                        cell4.Value = importitem.PermitDate;
                        row.Cells.Add(cell3);
                        row.Cells.Add(cell4);
                    }
                
                    dataGridView1.Rows.Add(row);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
