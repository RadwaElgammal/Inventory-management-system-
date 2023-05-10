using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
	public partial class ImportPermitForm : Form
	{
		Context context = new Context();
		public ImportPermitForm()
		{
			InitializeComponent();
			var allStores = from store in context.Stores
							where store != null
							select store;
			foreach (var store in allStores)
			{
				if (store != null)
				{
					listBox2.Items.Add(store.Name);
				}
			}
			var allSupplier = from supplier in context.Suppliers
							where supplier != null
							select supplier;
			foreach (var supplier in allSupplier)
			{
				if (supplier != null)
				{
					listBox3.Items.Add(supplier.Name);
				}
			}
			var allProducts = from product in context.Products
							  where product != null
							  select product;
			foreach (var product in allProducts)
			{
				if (product != null)
				{
					dataGridView1.Rows.Add(product.Name);
				}
			}
			textBox2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FillImportPermit();
		}

		private void FillImportPermit()
		{
			listBox1.Items.Clear();
			var allPermits = from permit in context.ImportPermit
							 where permit != null
							 select permit;
			foreach (var permit in allPermits)
			{
				if (permit != null)
				{
					listBox1.Items.Add(permit.PermitNumber);
				}
			}
		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string store = listBox2.SelectedItem?.ToString();
			string permitNumber = textBox1.Text;
			DateTime permitDate = dateTimePicker1.Value;
			string supplier = listBox3.SelectedItem.ToString();
			DateTime productionDate = dateTimePicker2.Value;
			DateTime expireDate = dateTimePicker3.Value;

			var selectedSupplier = context.Suppliers.FirstOrDefault(x => x.Name == supplier);
			var selectedStore = context.Stores.FirstOrDefault(x => x.Name == store);

			List<ImportPermitItem> permitItems = new List<ImportPermitItem>();
			List<Product> products = context.Products.ToList();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[1].Value != null)
				{
					var productName = row.Cells[0].Value.ToString();
					var product = products.FirstOrDefault(x => x.Name == productName);
					if (product != null)
					{
						ImportPermitItem importPermitItem = new ImportPermitItem()
						{
							Item = product,
							ItemId = product.Id,
							Quantity = int.Parse(row.Cells[1].Value.ToString())
						};
						permitItems.Add(importPermitItem);
					}
				}
			}

			ImportPermit importPermit = new ImportPermit()
			{
				ExpirationDate = expireDate,
				Items = permitItems,
				PermitDate = permitDate,
				PermitNumber = permitNumber,
				ProductionDate = productionDate,
				Store = selectedStore,
				StoreId = selectedStore.Id,
				Supplier = selectedSupplier,
				SupplierId = selectedSupplier.Id
			};
			context.ImportPermit.Add(importPermit);
			context.SaveChanges();

			MessageBox.Show("Added Successfully");
			FillImportPermit();
			textBox1.Text = string.Empty;
			listBox3.SetSelected(0, false);
			listBox2.SetSelected(0, false);
			RemoveGridViewCell();
		}

		private void RemoveGridViewCell()
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[1].Value != null)
				{
					row.Cells[1].Value = null;
				}
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RemoveGridViewCell();

			var selectedImportPermit = listBox1.SelectedItem?.ToString();
			var importPermit = context.ImportPermit
				.Include(w => w.Items)
				.Include(w=>w.Store)
				.Include(x=>x.Supplier)
				.FirstOrDefault(x=>x.PermitNumber == selectedImportPermit);
			if (importPermit != null)
			{
				listBox2.SelectedItem = importPermit.Store.Name;
				textBox1.Text = importPermit.PermitNumber;
				dateTimePicker1.Value = importPermit.PermitDate;
				listBox3.SelectedItem = importPermit.Supplier.Name;
				dateTimePicker2.Value = importPermit.ProductionDate;
				dateTimePicker3.Value = importPermit.ExpirationDate;
				textBox2.Text = importPermit.Id.ToString();

				foreach(var item in importPermit.Items)
				{
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						if (row.Cells[0].Value != null && row.Cells[0].Value == item.Item.Name)
						{
							row.Cells[1].Value = item.Quantity;
						}
					}
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string store = listBox2.SelectedItem?.ToString();
			string permitNumber = textBox1.Text;
			DateTime permitDate = dateTimePicker1.Value;
			string supplier = listBox3.SelectedItem.ToString();
			DateTime productionDate = dateTimePicker2.Value;
			DateTime expireDate = dateTimePicker3.Value;
			int importPermit = int.Parse(textBox2?.Text);

			ImportPermit importPermitToEdit = context.ImportPermit.FirstOrDefault(x => x.Id == importPermit);
			Suppliers selectedSupplier = context.Suppliers.FirstOrDefault(x => x.Name == supplier);
			Store selectedStore = context.Stores.FirstOrDefault(x => x.Name == store);

			List<ImportPermitItem> permitItems = new List<ImportPermitItem>();
			List<Product> products = context.Products.ToList();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells[1].Value != null)
				{
					var productName = row.Cells[0].Value.ToString();
					ImportPermitItem product =importPermitToEdit.Items.FirstOrDefault(x => x.Item.Name == productName);
					if (product != null)
					{
						product.Quantity = int.Parse(row.Cells[1].Value.ToString());
						permitItems.Add(product);
					}
					else
					{
						ImportPermitItem exhangePermitItem = new ImportPermitItem()
						{
							Item = context.Products.FirstOrDefault(x => x.Name == productName),
							ItemId = context.Products.FirstOrDefault(x => x.Name == productName).Id,
							Quantity = int.Parse(row.Cells[1].Value.ToString()),
							ImportPermitId = importPermitToEdit.Id,
							ImportPermit = importPermitToEdit
						};
						permitItems.Add(exhangePermitItem);
					}
				}
			}
			importPermitToEdit.PermitDate = permitDate;
			importPermitToEdit.ProductionDate = productionDate;
			importPermitToEdit.PermitNumber= permitNumber;
			importPermitToEdit.ExpirationDate = expireDate;
			importPermitToEdit.Items = permitItems;
			importPermitToEdit.Supplier = selectedSupplier;
			importPermitToEdit.SupplierId = selectedSupplier.Id;
			importPermitToEdit.Store = selectedStore;
			importPermitToEdit.StoreId = selectedStore.Id;

			context.ImportPermit.AddOrUpdate(importPermitToEdit);
			context.SaveChanges();

			MessageBox.Show("Updates Successfully");
			FillImportPermit();
			textBox1.Text = string.Empty;
			listBox3.SetSelected(0, false);
			listBox2.SetSelected(0, false);
			RemoveGridViewCell();
		}

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

