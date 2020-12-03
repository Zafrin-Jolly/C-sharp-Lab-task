﻿using System;
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


}
