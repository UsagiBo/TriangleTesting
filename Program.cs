using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTesting
{
    public class Program
    {
        static bool isit = false;

        public static void notZero(int a, int b ,int c)
        {
            if (a!=0 && b!=0 && c != 0)
            {
            }
            else
            {
                Console.WriteLine("Sides of triangle can not be Null!");
            }
        }

        public static void equilateral(int a, int b, int c)
        {
            if (a==b && b==c && c == a)
            {
                isit = true;
                //Console.WriteLine("This triangle is Equilateral!");
            }
            else
            {
                isit = false;
            }
            //else
            //{
            //    Console.WriteLine("This triangle is NOT Equilateral!");
            //}

        }

        public static void isosceles(int a, int b, int c) {
            if (a==b || a==c || c == b)
            {
                isit = true;
                //Console.WriteLine("This triangle is Isosceles!");
            }
            else
            {
                isit = false;
            }
            //else
            //{
            //    Console.WriteLine("This triangle is NOT Isosceles!");
            //}
        }

        public static void scalene(int a, int b, int c)
        {
            if (c > a && c > b)
            {
                int akv = a * a;
                int bkv = b * b;
                int ckv = c * c;

                if (akv + bkv == ckv)
                {
                    isit = true;
                    //Console.WriteLine("This triangle is Scalene ");

                }
                else
                {
                    isit = false;
                }
            //    else
            //    {
            //        Console.WriteLine("This triangle is NOT Scalene ");
            //    }
            //    if (a == b)
            //        Console.WriteLine("This triangle is Scalene and Equilateral");
            }
        }

            public static string WhatIsThisTriangle(int d,int e, int f)
        {
            equilateral(d, e, f);
            if (isit == true)
            {
                return "equilateral";
            }
            isosceles(d, e, f);
            if (isit == true)
            {
                return "isosceles";
            }
            scalene(d, e, f);
            if (isit == true)
            {
                return "scalene";
            }
            else return "false";
        }
        

        static void Main(string[] args)
        {
            //string input;
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("Please enter three values in the following order:");
            //Console.WriteLine("Enter value for side 'a': ");
            //input = Console.ReadLine();
            //a = Int32.Parse(input);
            //Console.WriteLine("Enter value for side 'b': ");
            //input = Console.ReadLine();
            //b = Int32.Parse(input);
            //Console.WriteLine("Enter value for side 'c': ");
            //input = Console.ReadLine();
            //c = Int32.Parse(input);

            //notZero(a, b, c);
            //equilateral(a, b, c);
            //isosceles(a, b, c);
            //scalene(a, b, c);




            Console.ReadLine();
        }
    }
}
