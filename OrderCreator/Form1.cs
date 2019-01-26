﻿using ModelLibrary;
using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderCreator
{
    public partial class OrderCreator : Form
    {
        //Customer customer = new Customer();
        //Order order = new Order();

        public OrderCreator()
        {
            InitializeComponent();
        }

        // CLEAR TEXT BOXSES
        private void Clear()
        {
            productName.Clear();
            productQuantity.Clear();
            productPrice.Clear();
        }

        // ADD PRODUCT TO DataGridView
        private void buttonAdd_Click(object sender, EventArgs e)
        {
          if (ValidateProductForm())
            {
                foreach (DataGridViewRow item in dataGridView.Rows) // if element exsist in data grid
                {
                    if (item.Cells[0].Value.ToString() == productName.Text)
                    {
                        MessageBox.Show("Produkt o tej nazwie został już dodany!");
                        return;
                    }
                }

                int row = dataGridView.Rows.Add();
                dataGridView.Rows[row].Cells[0].Value = productName.Text;
                dataGridView.Rows[row].Cells[1].Value = productQuantity.Text;
                dataGridView.Rows[row].Cells[2].Value = productPrice.Text;

                Clear();
            }
            else
            {
                MessageBox.Show("Wypełnij pola poprawnie!");
            }
        }

        // VALIDATION PRODUCT FORM
        private bool ValidateProductForm()
        {
            bool output = true;

            bool quantity = int.TryParse(productQuantity.Text, out int productQ); 
            bool price = float.TryParse(productPrice.Text, out float productP);

            if (!quantity || !price)
            {
                output = false;
            }

            if (productQuantity.Text.Length == 0 || productPrice.Text.Length == 0 || productName.Text.Length == 0)
            {
                output = false;
            }

            if (productQuantity.Text == "0" || productPrice.Text == "0")
            {
                output = false;
            }

            return output;
        }

        // SAVE TO XML FILE
        private void buttonSaveToXML_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            DataTable dataTable = new DataTable
            {
                TableName = groupBoxUser.Text 
            };

            dataTable.Columns.Add(labelFirstName.Text);
            dataTable.Columns.Add(labelLastName.Text);
            dataTable.Columns.Add(labelDateOfBirth.Text.Replace(" ",""));

            dataSet.Tables.Add(dataTable);

            DataRow rowUser = dataSet.Tables[groupBoxUser.Text].NewRow();
            rowUser[labelFirstName.Text] = firstName.Text;
            rowUser[labelLastName.Text] = lastName.Text;
            rowUser[labelDateOfBirth.Text.Replace(" ","")] = dateOfBirth.Text;
            dataSet.Tables[groupBoxUser.Text].Rows.Add(rowUser);

            DataTable dataTableProduct = new DataTable
            {
                TableName = groupBoxProduct.Text
            };

            dataTableProduct.Columns.Add(labelProductName.Text);
            dataTableProduct.Columns.Add(labelProductQuantity.Text);
            dataTableProduct.Columns.Add(labelProductPrice.Text);

            dataSet.Tables.Add(dataTableProduct);

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                DataRow rowProduct = dataSet.Tables[groupBoxProduct.Text].NewRow();
                rowProduct[labelProductName.Text] = item.Cells[0].Value.ToString();
                rowProduct[labelProductQuantity.Text] = item.Cells[1].Value.ToString();
                rowProduct[labelProductPrice.Text] = item.Cells[2].Value.ToString();
                dataSet.Tables[groupBoxProduct.Text].Rows.Add(rowProduct);
            }
            // save to XML
            string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            dataSet.WriteXml(Path + "\\Zamówienie.xml");
        }

        //SAVE TO DATABASE
        private void buttonSaveDataToDatabase_Click(object sender, EventArgs e)
        {
            DateTime.TryParseExact(dateOfBirth.Text, "yyyy-mm-dd",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime dateTime);

            using (ModelContext db = new ModelContext())
            {
                Customer customer = new Customer
                {
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Birthdate = dateTime
                };

                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    Order order = new Order
                    {
                        Id = item.Index,
                        ProductName = item.Cells[0].Value.ToString(),
                        Quantity = int.Parse(item.Cells[1].Value.ToString()),
                        Price = double.Parse(item.Cells[2].Value.ToString()),
                        Customer = customer
                    };
                     
                    db.Orders.Add(order);

                    db.SaveChanges();
                }
            }
        }

        //SELECT ROW TO UPDATE
        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            productName.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            productQuantity.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            productPrice.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        // UPDATE ROW
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Lista jest pusta!");
            }
            else
            {
                if (ValidateProductForm())
                {
                    dataGridView.SelectedRows[0].Cells[0].Value = productName.Text;
                    dataGridView.SelectedRows[0].Cells[1].Value = productQuantity.Text;
                    dataGridView.SelectedRows[0].Cells[2].Value = productPrice.Text;

                    Clear();
                }
                else
                {
                    MessageBox.Show("Wypełnij pola poprawnie!");
                }
            }
        }

        //DELETE ROW
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                Clear();
            }
            else
            {
                MessageBox.Show("Lista jest pusta!");
            }
            
        }
    }
}
