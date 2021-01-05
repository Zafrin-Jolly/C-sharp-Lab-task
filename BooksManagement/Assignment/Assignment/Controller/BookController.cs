using Assignment.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Controller
{
    public class BookController
    {
        public static Database db = new Database();
        public static ArrayList GetAllBook2(int id)
        {
            return db.Books.GetAllBook2(id);
        }
    }
}
