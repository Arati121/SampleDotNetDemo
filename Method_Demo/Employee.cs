﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
   public class Employee
    {
        protected int eid;
        protected String ename;
        protected double esal,hra,da,pf,grossSal;

        public Employee()
        {
            eid = 101;
            ename = "Sharma";
            esal = 45000;
        }

        public Employee(int eid,String ename,int esal)
        {
            this.eid = eid;
           this.ename = ename;
            this.esal = esal;
        }

        public virtual void caculate()
        {
            hra = esal * 0.40;
            da = esal * 0.20;
            pf = esal * 0.10;
            grossSal = (esal + hra + da) - pf;


        }

        ////public String GetData()
        //{
        //    return "employee Hra= " + hra + " employee name= " + eid + " employee salaray= " + esal;
        //}

        public override string ToString()
        {
            return "employee id= " + eid + " employee name= " + ename + " employee salaray= " + esal+"Hra="+hra+" DA= "+da+"pf= "+pf+"GrossSalary= "+grossSal ;
        }
    }
}
