using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
    class Employee
    {
        private int eid;
        private String ename;
        private float esal;

        public Employee()
        {
            eid = 101;
            ename = "Sharma";
            esal = 45000.45f
        }

        public Employee(int id,String name,float sal)
        {
            eid = id;
            ename = name;
            esal = sal;
        }

        public String GetData()
        {
            return "employee id= " + eid + " employee name= " + eid + " employee salaray= " + esal;
        }

    }
}
