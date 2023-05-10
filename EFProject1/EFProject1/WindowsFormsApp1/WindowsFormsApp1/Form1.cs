using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stores store = new Stores();
            store.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers();
            cust.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supp suppliers= new Supp();
            suppliers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExchangePermitForm ex = new ExchangePermitForm();
            ex.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImportPermitForm im = new ImportPermitForm();
            im.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TransferForm trans = new TransferForm();
            trans.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductExpireDateForm prdex = new ProductExpireDateForm();
            prdex.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StoreReport storeReport= new StoreReport();
            storeReport.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TransferItemReportForm tReport = new TransferItemReportForm();
            tReport.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProductReportForm prd = new ProductReportForm();
            prd.Show();
        }
    }
}
