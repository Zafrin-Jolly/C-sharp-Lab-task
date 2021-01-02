using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var books = GetBooks();
            dataGridView.DataSource = books;
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
         }
        private ArrayList GetBooks()
        {
            var conn = Database.ConnectDB();
            conn.Open();
            String query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList books = new ArrayList();
            while (reader.Read())
            {
                books b = new books();
                b.BookName = reader.GetString(reader.GetOrdinal("BookNames"));
                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.AuthorName = reader.GetString(reader.GetOrdinal("AuthorName"));
                b.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(b);
            }
            conn.Close();
            return books;
        }
            /*  SqlDataReader reader = cmd.ExecuteReader();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds);
              dataGridView.DataSource = ds.Tables[0]; */

        }
    }

       
        
    

