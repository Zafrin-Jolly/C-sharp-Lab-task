using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace labTask6
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Department
        {
            get { return department; }
            set { department = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {
            Console.WriteLine("Empty");
        }
        public Student(String name, String id, String department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department=department;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department " + department);
            Console.WriteLine("CGPA :" + cgpa);
        }
    }
    class Account
    {
        private String accName;
        private String acid;
        private int balance;

        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public String Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {
            Console.WriteLine("Empty ");
        }
        public Account(String accName,String acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposite(int amount)
        { balance += amount; }
        public void Withdraw(int amount) { balance -= amount; }
        public void Transfer(int amount, Account receiver)
        {
            if (amount <= balance)
            {
                balance -= amount;
                receiver.balance = amount + balance;
                Console.WriteLine("Balance transfer successful.Amount:" + amount);
            }
            else
            { Console.WriteLine("Not sufficient balance"); }
        }

    }
    class Book
    {
        private String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        private int bookCopy;

        public String BookName
        {
            get { return bookName; }
            set { BookName = value; }
        }
        public String BookAuthor
        {
            get { return bookAuthor; }
            set { BookAuthor = value; }
        }
        public String BookId
        {
            get { return  bookId; }
            set { bookId = value; }
        }
        public String BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            Console.WriteLine("Empty");
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Author: " + bookAuthor);
            Console.WriteLine("ID: " + bookId);
            Console.WriteLine("Type: " + bookType);
            Console.WriteLine("Copy: " + bookCopy);
        }
        public void AddBookCopy(int x)
        {
            bookCopy += x;
        }
    }
    class Library
    {
        private String libName;
        private String libAddress;
        private Book[] listOfBook;
        private int totalBook;

        public String LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        public String LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        
        public Library()
        {
            listOfBook = new Book[1000];
            Console.WriteLine("Empty");
        }
        public Library(String libName, String libAddress, int totalBook)
        {
            listOfBook = new Book[1000];
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
        }
        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name :" + libName);
            Console.WriteLine("Library Address :" + libAddress);
            Console.WriteLine("total Book: " + totalBook);
        }
        public void AddNewBook(Book book)
        {
            if (totalBook < 1000)

                listOfBook[totalBook++] = book;
            else
                Console.WriteLine(" amount is full");

        }

        public void DeleteBook(Book book)
        {
            listOfBook[totalBook--] = book;
        }

    }

}
