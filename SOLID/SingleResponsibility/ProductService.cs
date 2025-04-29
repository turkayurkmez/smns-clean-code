using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True";
        public string CreateProduct(string name, decimal price)
        {            
            var commandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            SqlProvider sqlProvider = new SqlProvider(connectionString);
            var affectedRows = sqlProvider.ExecuteNonQuery(commandText, parameters);

            return affectedRows > 0 ? "Başarılı" : "Başarısız";

        }
    }
}
