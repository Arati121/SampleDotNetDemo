using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
    public class Department
    {

        private int id;
        private string deptName, location;

        public Department()
        {
            Console.WriteLine("I am default constructor");
            id = 101;
            deptName = "Design";
            location = "pune";
        }
        public Department(int i,string dname,string l)
        {
            Console.WriteLine("I am parametric constructor");
            id = i;
            deptName = dname;
            location = l;
        }
        public string GetData()
        {
            return "department Id= " + id + " department name= " + deptName + "Location= " + location;
        }

    }
}
