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
            {
                return 
            }
        }


    }
}
