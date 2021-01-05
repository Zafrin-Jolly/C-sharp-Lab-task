using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class Books
    {
        SqlConnection conn;
        public Books() { }
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public ArrayList GetAllBook2(int id)
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = String.Format("Select * FROM Books WHERE ID='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(book);
            }

            conn.Close();
            return books;
        }
    }
}
