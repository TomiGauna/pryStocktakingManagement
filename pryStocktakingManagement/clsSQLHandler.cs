using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace pryStocktakingManagement
{
    internal class clsSQLHandler
    {
        SqlConnection connection;
        SqlCommand command;

        public clsSQLHandler() 
        {
            string connString = "Server=localhost;Database=Products;Trusted_Connection=True;";
            connection = new SqlConnection(connString);

            try
            {
                connection.Open();
                MessageBox.Show("Database connection established successfully!", "Connection Information: DB Plug-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to connect to DB: " + ex.Message, "Connection Information: DB Plug-In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Reader(string field, string data)
        {
            string query = $"SELECT * FROM Productos WHERE {field} = @valor";

            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@valor", data);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable prods = new DataTable();

            da.Fill(prods);
            return prods;
        }

        public void Creator(
            int code, 
            string name,
            string description,
            string category,
            double price,
            int stock
            )
        {
            try
            {
                string query = $"INSERT INTO Productos (Id, Código, Nombre, Descripción, Categoría, Precio, Stock) VALUES (@Id, @Código, @Nombre, @Descripción, @Categoría, @Precio, @Stock)";
                DataTable table = GetAll();
                int id = table.Rows.Count + 2;
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Código", code);
                command.Parameters.AddWithValue("@Nombre", name);
                command.Parameters.AddWithValue("@Descripción", description);
                command.Parameters.AddWithValue("@Categoría", category);
                command.Parameters.AddWithValue("@Precio", price);
                command.Parameters.AddWithValue("@Stock", stock);
                command.ExecuteNonQuery();

                MessageBox.Show("Product registered successfully!", "Product Registration: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail to register new product: {ex.Message}", "Product Registration: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void Updater(int code, string field, string value)
        {
            try
            {
                string query = $"UPDATE Productos SET {field} = @valor WHERE Código = @código";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@valor", value);
                command.Parameters.AddWithValue("@código", code);
                command.ExecuteNonQuery();
                MessageBox.Show("Product updated successfully!", "Product Update: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail to update product: {ex.Message}", "Product Update: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Remover(int code)
        {
            try
            {
                string query = "DELETE FROM Productos WHERE Código = @código";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@código", code);
                command.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully!", "Product Removal: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fail to delete product: {ex.Message}", "Product Removal: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Productos";

            command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable all = new DataTable();

            da.Fill(all);
            return all;
        }

        //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
    }
}
