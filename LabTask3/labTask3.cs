using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Labtask3
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public string Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public string Department
        {
            get
            { return department; }
            set
            { department = value; }
        }
        public float Cgpa
        {
            get
            { return cgpa; }
            set
            { cgpa = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Student name :" + name);
            Console.WriteLine("Student ID :" + id);
            Console.WriteLine("Student Department :" + department);
            Console.WriteLine("Students Cgpa" + cgpa);

        }


    }

    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get
            { return x; }
            set
            { x = value; }
        }
        public int Y
        {
            get
            { return y; }
            set
            { y = value; }
        }
        public int Z
        {
            get
            { return z; }
            set
            { z = value; }
        }
        public void ShowInfo()
        {  
            Console.WriteLine("Value of X :" + x);
            Console.WriteLine("Value of y:" + y);
            Console.WriteLine("Value of z :" + z);
        }

        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The triangle is equilateral");

            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("This is an isosceles triangle");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle");
            }
        }



    }
    class Account
    {
        private String accName;
        private String acid;
        private int balance;
        public String AccName
        {
            get
            { return accName; }
            set
            { accName = value; }
        }
        public String Acid
        {
            get
            { return acid; }
            set
            { acid = value; }
        }

        public int Balance
        {
            get
            { return balance; }
            set
            { balance = value; }
        }
        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("deposited amount =" + amount);
            }
            else { Console.WriteLine("Error"); }
            return amount;

        }
        public int Withdraw(int amount)
        {
            if (amount <= balance)
            {
                Console.WriteLine("Amount withdrawed");

            }
            else
            {
                Console.WriteLine("You do not have enough balance to withdraw");
            }
            return amount;
        }
    }
        class Course
        {
            private String courseName;
            private String courseCode;
            private int courseCredit;
        public String CourseName
        {
            get
            { return courseName; }
            set
            { courseName = value; }
        }
        public String CourseCode
        {
            get
            { return courseCode; }
            set
            { courseCode = value; }
        }
        public int CourseCredit
        {
            get
            { return courseCredit ; }
            set
            {  courseCredit = value; }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name   : " + courseName);
            Console.WriteLine("Course code   : " + courseCode);
            Console.WriteLine("Course credit : " + courseCredit);

        }

    }
    class Program
    {
         static void Main(String[] args)
        {
            Student s = new Student();
            s.Name = "Zafrin";
            s.Id = "19-39345-1";
            s.Department = "CSE";
            s.Cgpa =3.87f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 4;
            t.Y = 4;
            t.Z = 3;
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "zafrinjolly";
            a.Acid = "1234abc";
            a.Balance = 1000;
            a.Deposit(100);
            a.Withdraw(200);

            

        }
    }




}
