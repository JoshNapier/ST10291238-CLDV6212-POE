using System.Data.SqlClient;

namespace ST10291238_CLDV6212_POE.Models
{
    public class OrdersTable
    {
        public static string con_string = "Server=tcp:josh-sql-server.database.windows.net,1433;Initial Catalog=josh-sql-DB;Persist Security Info=False;User ID=joshnapier21;Password=Metroplex65;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }

        public int insert_order(OrdersTable o)
        {
            string sql = "INSERT INTO OrdersTable (CustomerID, ProductID) SELECT CustomerTable.CustomerID, ProductTable.ProductID FROM CustomerTable INNER JOIN ProductTable ON CustomerTable.OrderID = ProductTable.OrderID";
            SqlConnection con = new SqlConnection(con_string);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CustomerID", o.CustomerID);
            cmd.Parameters.AddWithValue("@productID", o.ProductID);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
    }
}
