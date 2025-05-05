using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace pryStocktakingManagement
{
    internal class clsDataHandler
    {
        public DataSet DS;
        public OleDbDataAdapter DA;

        public clsDataHandler()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Productos.mdb";
            connection.Open();

            DS = new DataSet();

            OleDbCommand command = new OleDbCommand();

            command.CommandType = CommandType.TableDirect;
            command.CommandText = "Productos";
            command.Connection = connection;

            DA = new OleDbDataAdapter();
            DA.SelectCommand = command;
            DA.Fill(DS, "Productos");

            DataColumn[] DC = new DataColumn[1];
            DC[0] = DS.Tables["Productos"].Columns["Id"];
            DS.Tables["Productos"].PrimaryKey = DC;

            OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
            connection.Close();
        }

        public void createProduct(int code, string name, string desc, string category, double price, int stock)
        {
            try
            {
                DataRow newRow = DS.Tables["Productos"].NewRow();
                newRow["Código"] = code;
                newRow["Nombre"] = name;
                newRow["Descripción"] = desc;
                newRow["Categoría"] = category;
                newRow["Precio"] = price;
                newRow["Stock"] = stock;
                newRow["Id"] = DS.Tables["Productos"].Rows.Count + 1;

                DS.Tables["Productos"].Rows.Add(newRow);
                DA.Update(DS, "Productos");
                MessageBox.Show("Product registered successfully", "Process Information: Product Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to register product: " + ex.Message, "Process Information: Product Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void updateProduct(int code, string field, string data)
        {
            try
            {
                for (int i = 0; i < DS.Tables["Productos"].Rows.Count; i++)
                {
                    DataRow row = DS.Tables["Productos"].Rows[i];

                    if (row["Código"].ToString() == code.ToString())
                    {
                        row.BeginEdit();
                        if (field == "Código" || field == "Stock")
                        {
                            row[field] = int.Parse(data);
                        }
                        else if (field == "Precio")
                        {
                            row[field] = double.Parse(data);
                        }
                        else
                        {
                            row[field] = data;
                        }
                        row.EndEdit();
                        break;
                    }
                }
                DA.Update(DS, "Productos");
                MessageBox.Show("Product updated successfully", "Process Information: Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to update product: " + ex.Message, "Process Information: Product Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<DataRow> productInquiry(string field, string data)
        {
            List<DataRow> list = new List<DataRow>();

            foreach (DataRow row in DS.Tables["Productos"].Rows)
            {
                if (row[field].ToString() == data)
                {
                    list.Add(row);
                }
            }
            return list;
        }

        public void deleteProduct(int code)
        {
            try
            {
                foreach (DataRow row in DS.Tables["Productos"].Rows)
                {
                    if (Convert.ToInt32(row["Código"]) == code)
                    {
                        row.Delete();
                        break;
                    }
                }
                DA.Update(DS, "Productos");
                MessageBox.Show("Product removed successfully", "Process Information: Product Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to delete product: " + ex.Message, "Process Information: Product Removal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
