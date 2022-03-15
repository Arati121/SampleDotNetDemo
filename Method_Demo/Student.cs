using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
    public class Student
    {
        private int sid;
        private string sname, department;
        private float percentage;

        public Student()
        {
            Console.WriteLine(" default consutror");
            sid = 11;
            sname = "Rohit";
            department = "Civil";
            percentage= 85.5f;
        }

        
        public Student(int i,string name,string dept,float per)
        {
            Console.WriteLine("  parametric consutror");
            sid = i;
            sname = name;
            department = dept;
            percentage = per;
        }

        public String GetData()
        {
            return " id= " + sid + "Name= " + sname + " Department= " + department + "Percentage= " + percentage;
        }
       
    }
}
