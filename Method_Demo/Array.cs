using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Demo
{
    class Array
    {

        static void Main(string[] args)
        {
            int[] rainfall = new int[5] { 100, 102, 105, 107, 110 };
            int[] list1 = new int[5];

            string[] name = { "arati", "sagar", "deven" };
            for(int i=0; i<rainfall.Length;i++)
            {
                Console.WriteLine(rainfall[i]);
            }
            Array.Copy(rainfall,1)
        }
    }
}
