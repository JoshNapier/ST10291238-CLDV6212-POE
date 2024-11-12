using System.Data.SqlClient;

namespace ST10291238_CLDV6212_POE.Models
{
    public class ProductTable
    {
        public static string con_string = "Server=tcp:josh-sql-server.database.windows.net,1433;Initial Catalog=josh-sql-db;Persist Security Info=False;User ID=joshnapier21;Password=Metroplex65;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        public string Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }

        public int insert_Product(ProductTable p)
        {
            string sql = "INSERT INTO ProductTable (ProductName, ProductPrice, ProductCategory) VALUES (@ProductName, @ProductPrice, @ProductCategory)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ProductName", p.Name);
            cmd.Parameters.AddWithValue("@ProductPrice", p.Price);
            cmd.Parameters.AddWithValue("@ProductCategory", p.Category);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }
    }
}
