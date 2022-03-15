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

            Employee e1 = new Employee();
            e1.GetData();

            Employee e2 = new Employee(111,"rohit",75000.5f);
            e2.GetData();


        }

    }
}
