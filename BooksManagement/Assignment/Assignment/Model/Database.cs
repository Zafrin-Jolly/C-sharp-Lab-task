using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connetionString = "Server = JOLLY\\ZAFRINJOLLY; Database =DBMS; User Id = sa; Password = @Jolly147570";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    }
}
