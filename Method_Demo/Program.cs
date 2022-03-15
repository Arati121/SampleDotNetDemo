using System;

namespace Method_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Department dept = new Department();

            //string str = dept.GetData();
            //Console.WriteLine(str);

            //Department dept1 = new Department(101,"mechanical","mumbai");
            //Console.WriteLine(dept1.GetData() );

            //Department dept2 = new Department(102, "xyx", "kolhapur");
            //Console.WriteLine(dept2.GetData());
            //Student s = new Student();
            //Console.WriteLine(s.GetData());

            //Student s1 = new Student(101, "akash", "ENTC", 75.5f);
            //Console.WriteLine(s1.GetData());

            //Employee e1 = new Employee();
            //e1.GetData();

            //Employee e2 = new Employee(111,"rohit",75000.5f);
            //e2.GetData();
            //Employee e3 = new Employee(105, "nbvfh", 85.6f);
            //e3.GetData();
            // Employee e1 = new Employee();
            //Console.WriteLine(e1);
            //e1.caculate();
            //Console.WriteLine(e1);


            //Employee e2 = new Employee(101,"rajesh",35000);
            //e2.caculate();
            //Console.WriteLine(e2);


            //Manager man1 = new Manager(101,"xyz",50000,45000,1000);
            //man1.caculate();
            //Console.WriteLine(man1);


            //SaleManager s1 = new SaleManager(101, "rahul", 55000, 1000, 1500, 1200);
            //s1.caculate();
            //Console.WriteLine(s1);

            Calcualtion_MethodOver c1 = new Calcualtion_MethodOver();
            Console.WriteLine(c1.calculation(10, 5));
            Console.WriteLine(c1.calculation(10, 10, 10));
            Console.WriteLine(c1.calculation(15, 4, 5, 1));
            

           



        }

    }
}
