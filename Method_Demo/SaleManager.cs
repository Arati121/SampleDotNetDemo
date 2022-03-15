using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
   public class SaleManager:Employee
    {
        private double comm, foodallow, ta;

        public SaleManager():base()
        {
            comm = 0.0;
            foodallow = 0.0;
            ta = 0.0;
        }
        public SaleManager(int id,string name,int sal,double comm,double foodallow,double ta):base(id,name,sal)
        {
            this.comm = comm;
            this.foodallow = foodallow;
            this.ta = ta;
        }

        public override void caculate()
        {

            hra = esal * 0.40;
            da = esal * 0.20;
            pf = esal * 0.10;
            grossSal = (esal + hra + da + foodallow + ta+comm) - pf;
        }

        public override string ToString()
        {
            return "Manager id= " + eid + " manager name= " + ename + "  manager salaray= " + esal + "Hra=" + hra + " DA= " + da + "pf= " + pf + " foodallow=  " + foodallow + " travaling= " + ta +"commision= "+comm + "grosssalary= " + grossSal;
        }
    }
}
