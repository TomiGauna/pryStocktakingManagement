using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Data;

namespace pryStocktakingManagement
{
    internal class clsSQLHandler
    {
        SqlConnection connection;

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

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@valor", data);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable prods = new DataTable();

            da.Fill(prods);
            Console.WriteLine(prods.Rows.Count);
            return prods;
        }

    }
}
