﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Line_UC2
    {
        public static void Line2()
        {
            int x1,x2,y1,y2,x3,y3;
            double A, B, C, D, x, y, a, b;
            Console.WriteLine("enter co-ordinates for Line 1 & LINE 2");
            Console.WriteLine("enter point (x1,y1)");
            x1=Convert.ToInt32(Console.ReadLine());
            y1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter point (x2,y2)");
            x2= Convert.ToInt32(Console.ReadLine());
            y2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter point (x3,y3)");
            x3= Convert.ToInt32(Console.ReadLine());
            y3=Convert.ToInt32(Console.ReadLine());

            A = (x2-x1);
            B = (y2-y1);

            x=Math.Pow(A,2) + Math.Pow(B,2);
            a=Math.Sqrt(x);
            Console.WriteLine("length of line = " +a);

            C = (x3 - x2);
            D = (y3 - y2);

            y = Math.Pow(C, 2) + Math.Pow(D, 2);
            b = Math.Sqrt(y);
            Console.WriteLine("length of line = " + b);

            Console.WriteLine("line 1 is equal to line 2");
            Console.WriteLine(a.Equals(b));





        }
    }
}
