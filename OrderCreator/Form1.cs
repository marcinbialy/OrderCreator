using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderCreator
{
    public partial class OrderCreator : Form
    {
        public OrderCreator()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int row = dataGridView.Rows.Add();
            dataGridView.Rows[row].Cells[0].Value = productName.Text;
            dataGridView.Rows[row].Cells[1].Value = productQuantity.Text;
            dataGridView.Rows[row].Cells[2].Value = productPrice.Text;
        }

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

            string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            dataSet.WriteXml(Path + "\\Zamówienie.xml");
        }

    }
}
