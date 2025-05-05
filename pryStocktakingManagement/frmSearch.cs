using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryStocktakingManagement
{
    public partial class frmSearch : Form
    {
        clsDataHandler handler = new clsDataHandler();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            grbSearch.Text = "Product Inquiry";
            lblOptions.Text = "Choose the category or enter the name or code";
            lblSearchField.Text = "Choose the search option";
            btnSearch.Text = "Search";

            cboCategoryOptions.Enabled = false;
            txtCodeOrName.Enabled = false;

            cboSearchField.Items.Clear();
            cboSearchField.Items.Add("Nombre");
            cboSearchField.Items.Add("Código");
            cboSearchField.Items.Add("Categoría");

            cboCategoryOptions.Items.Clear();
            cboCategoryOptions.Items.Add("Bebidas");
            cboCategoryOptions.Items.Add("Mobiliario");
            cboCategoryOptions.Items.Add("Electrónica");
            cboCategoryOptions.Items.Add("Libros");
            cboCategoryOptions.Items.Add("Ropa");
            cboCategoryOptions.Items.Add("Calzado");
            cboCategoryOptions.Items.Add("Accesorios");
            cboCategoryOptions.Items.Add("Juguetes");
            cboCategoryOptions.Items.Add("Cosméticos");

            dgvProducts.Columns.Add("col1", "Code");
            dgvProducts.Columns.Add("col2", "Name");
            dgvProducts.Columns.Add("col3", "Description");
            dgvProducts.Columns.Add("col4", "Category");
            dgvProducts.Columns.Add("col5", "Price");
            dgvProducts.Columns.Add("col6", "Stock");

        }

        private void cboSearchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchField.SelectedIndex == -1 || cboSearchField.Text == "")
            {
                txtCodeOrName.Enabled = false;
                cboCategoryOptions.Enabled = false;
            }
            else
            {
                if (cboSearchField.Text == "Nombre" || cboSearchField.Text == "Código")
                {
                    txtCodeOrName.Enabled = true;
                    cboCategoryOptions.Enabled = false;
                }
                else if (cboSearchField.Text == "Categoría")
                {
                    txtCodeOrName.Enabled = false;
                    cboCategoryOptions.Enabled = true;
                }
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSearchField.Text == "Categoría")
            {
                List<DataRow> list= handler.productInquiry(
                    cboSearchField.Text, 
                    cboCategoryOptions.Text
                    );

                outputDisplay(list);
            }
            else
            {
                List<DataRow> list = handler.productInquiry(
                    cboSearchField.Text,
                    txtCodeOrName.Text
                    );

                outputDisplay(list);
            }
            cboCategoryOptions.SelectedIndex = -1;
            txtCodeOrName.Text = string.Empty;
        }

        public void outputDisplay(List<DataRow> list)
        {
            dgvProducts.Rows.Clear();
            foreach (DataRow rowShown in list)
            {
                dgvProducts.Rows.Add(
                        rowShown["Código"],
                        rowShown["Nombre"],
                        rowShown["Descripción"],
                        rowShown["Categoría"],
                        rowShown["Precio"],
                        rowShown["Stock"]
                        );
            };
        }
    }
}
