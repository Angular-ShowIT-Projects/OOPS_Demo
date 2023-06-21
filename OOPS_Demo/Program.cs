using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Demo
{
    internal class Program

         
    {
        static void Main(string[] args)

        {
            // Static or Compile Time Polymorphism 

            DemoNumber num  = new DemoNumber();
            int sum2 = num.AddNumber(5, 10);
            int sum3 = num.AddNumber(5, 10, 15);


            Console.WriteLine("Sum of 2 Number:" + sum2);
            Console.WriteLine("Sum of 3 Number:" + sum3);

            Console.WriteLine("----------------------------------------");

            //encap demo

            DemoEncap myAccount = new DemoEncap(1000);

            myAccount.deposit(500);
            Console.WriteLine("Balance:" + myAccount.getbalance());

            myAccount.withdraw(2000);
            Console.WriteLine("Balance:" + myAccount.getbalance());

            myAccount.withdraw(1000);
            Console.WriteLine("Balance:" + myAccount.getbalance());


            Console.WriteLine("--------------------------------------" );


            //inheritance demo

            Rectangle rect = new Rectangle(5, 10, "Red");

            Console.WriteLine("Area of Rectangle:" + rect.getArea());
            Console.WriteLine("Color of Rectangle:" + rect.getColor());

        }
    }

    // Static - Compile Time Polymorphism class
    class DemoNumber
    {


        public int AddNumber(int a, int b)
        {
            return a + b;
        }

        public int AddNumber(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    //multiple inheritance Demo
    interface Shape
    {
        double getArea();   // calculate area
    }

    interface Color
    {
        string getColor();  // display color
    }

    class Rectangle: Shape, Color
    {
        private double length;
        private double width;
        private string color;

        public Rectangle(double length, double width, string color)
        {
            this.length = length;
            this.width = width;
            this.color = color;
        }

        public double getArea()
        {
            return length * width;
        }

        public string getColor()
        {
            return color;
        }

    }

   
}
