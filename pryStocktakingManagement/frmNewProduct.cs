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
    public partial class frmNewProduct : Form
    {
        clsDataHandler handler = new clsDataHandler();
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            lblCreateTitle.Text = "REGISTER NEW PRODUCT";
            lblCode.Text = "Code";
            lblName.Text = "Name";
            lblDescription.Text = "Description";
            lblCategory.Text = "Category";
            lblPrice.Text = "Price";
            lblStock.Text = "Stock";
            lblUpdateTitle.Text = "UPDATE PRODUCT INFORMATION";
            lblChangeCode.Text = "Code";
            lblField.Text = "Field to Update";
            lblNewData.Text = "Enter new data";
            lblSearchForm.Text = "Are you looking for a kind of products?";
            lblReportBtn.Text = "Do you want to make a report?";
            lblRemovalTitle.Text = "DELETE PRODUCT";
            lblRemovalCode.Text = "Enter the code";

            btnCreate.Text = "Register";
            btnUpdate.Text = "Update";
            btnSearchForm.Text = "Start Searching";
            btnReportForm.Text = "Go to Report Form";
            btnDelete.Text = "Delete";

            cboCategory.Items.Clear();
            cboCategory.Items.Add("Bebidas");
            cboCategory.Items.Add("Mobiliario");
            cboCategory.Items.Add("Electrónica");
            cboCategory.Items.Add("Libros");
            cboCategory.Items.Add("Ropa");
            cboCategory.Items.Add("Calzado");
            cboCategory.Items.Add("Accesorios");
            cboCategory.Items.Add("Juguetes");
            cboCategory.Items.Add("Cosméticos");

            cboField.Items.Clear();
            cboField.Items.Add("Código");
            cboField.Items.Add("Nombre");
            cboField.Items.Add("Descripción");
            cboField.Items.Add("Categoría");
            cboField.Items.Add("Precio");
            cboField.Items.Add("Stock");

            cboNewData.Items.Clear();
            cboNewData.Items.Add("Bebidas");
            cboNewData.Items.Add("Mobiliario");
            cboNewData.Items.Add("Electrónica");
            cboNewData.Items.Add("Libros");
            cboNewData.Items.Add("Ropa");
            cboNewData.Items.Add("Calzado");
            cboNewData.Items.Add("Accesorios");
            cboNewData.Items.Add("Juguetes");
            cboNewData.Items.Add("Cosméticos");

            txtNewData.Enabled = false;
            cboNewData.Enabled = false;
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            frmSearch form = new frmSearch();
            form.Show();
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            frmReport form = new frmReport();
            form.Show();
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboField.Text == "Categoría")
            {
                txtNewData.Enabled = false;
                cboNewData.Enabled = true;
            }
            else
            {
                cboNewData.Enabled = false;
                txtNewData.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (
                txtCode.Text == "" ||
                txtName.Text == "" ||
                rtxtDescription.Text == "" ||
                cboCategory.SelectedIndex == -1 ||
                txtPrice.Text == "" ||
                nudStock.Value < 0
                )
            {
                MessageBox.Show("All fields need to be filled ", "Product Registration: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                handler.createProduct(
                int.Parse(txtCode.Text),
                txtName.Text,
                rtxtDescription.Text,
                cboCategory.Text,
                double.Parse(txtPrice.Text),
                (int)nudStock.Value
                );
            }

            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            rtxtDescription.Text = string.Empty;
            cboCategory.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            nudStock.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboField.Text == "Categoría")
            {
                if (
                    txtChangeCode.Text == "" || 
                    cboField.SelectedIndex == -1 || 
                    cboNewData.SelectedIndex == -1
                    )
                {
                    MessageBox.Show("Please provide the needed information", "Product Update: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    handler.updateProduct(
                    int.Parse(txtChangeCode.Text),
                    cboField.Text,
                    cboNewData.Text
                    );
                }    
            }
            else
            {
                if (
                    txtChangeCode.Text == "" ||
                    cboField.SelectedIndex == -1 ||
                    txtNewData.Text == ""
                    )
                {
                    MessageBox.Show("Please provide the needed information", "Product Update: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    handler.updateProduct(
                    int.Parse(txtChangeCode.Text),
                    cboField.Text,
                    txtNewData.Text
                    );
                }     
            }

            txtChangeCode.Text = string.Empty;
            cboField.SelectedIndex = -1;
            cboNewData.SelectedIndex = -1;
            txtNewData.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteCode.Text == "")
            {
                MessageBox.Show("Please enter a code", "Product Removal: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                handler.deleteProduct(int.Parse(txtDeleteCode.Text));
            }
          
            txtDeleteCode.Text = string.Empty;
        }
    }
}
