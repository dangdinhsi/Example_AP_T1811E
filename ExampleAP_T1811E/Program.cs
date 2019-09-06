using System;
using System.Collections.Generic;

namespace ExampleAP_T1811E
{
    class Program
    {
        static List<Product> list = new List<Product>();
        static void Main(string[] args)
        {
            
            Book b1 = new Book("b1","Java",500, "anonymous1");
            Book b2 = new Book("b2", "C#", 1000, "anonymous2");
            Book b3 = new Book("b3", "HTML/CSS", 400, "anonymous");
            MobilePhone m1 = new MobilePhone("m1","IP5",1000, "Apple");
            MobilePhone m2 = new MobilePhone("m2", "IP7", 1500, "Apple");
            MobilePhone m3 = new MobilePhone("m3", "IP8", 3000, "Apple");
            list.Add(b1);
            list.Add(b2);
            list.Add(b3);
            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            double taxBook = 0;
            double taxMobile = 0;
            foreach(var x in list)
            {
                if (x.GetType() == typeof(Book))
                {
                    taxBook += x.ComputeTax();
                }
                if(x.GetType() == typeof(MobilePhone))
                {
                    taxMobile += x.ComputeTax();
                }
            }
            Console.WriteLine("Tax of Book:"+taxBook);
            Console.WriteLine("Tax of MobilePhone:"+taxMobile);

        }
    }
}
