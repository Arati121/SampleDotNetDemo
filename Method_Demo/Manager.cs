using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
    public class Manager : Employee
    {
        private double foodallow, ta;

        public Manager():base()
        {
            foodallow = 0.0;
            ta = 0.0;
        }

        public Manager(int id,string nm,int sal,double foodallow,double ta):base(id,nm,sal)
        {
            this.foodallow = foodallow;
            this.ta = ta;
        }

        public override void caculate()
        {
            hra = esal * 0.40;
            da = esal * 0.20;
            pf = esal * 0.10;
            grossSal = (esal + hra + da +foodallow+ta) - pf;
        }
        public override string ToString()
        {
            return "Manager id= " + eid + " manager name= " + ename + "  manager salaray= " + esal + "Hra=" + hra + " DA= " + da + "pf= " + pf +" foodallow=  "+foodallow+" travaling= "+ta+"grosssalary= "+grossSal;
        }






    }
}
