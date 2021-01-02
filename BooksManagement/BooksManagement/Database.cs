using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BooksManagement
{
    public class Database
    {
        public static SqlConnection ConnectDB()
        {
            String conString = @"Server=JOLLY\ZAFRINJOLLY;Database=BooksManagement;User Id=sa;Password=@Jolly147570";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
    }
}
