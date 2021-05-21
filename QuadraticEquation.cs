using System;

namespace Quadratic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            QuadraticFunc quadraticFunc = new QuadraticFunc();

            // Asking for Question 1
            quadraticFunc.QuadraticNumber1();

            // Asking for Question 2
            quadraticFunc.QuadraticNumber2();

            // Asking for Question 3
            quadraticFunc.QuadraticNumber3();
        }
    }

    class QuadraticFunc
    {
        // Formulas for solutions of quadratic equations (Plus Ver.)
        public double QuadraticArgPlus(int a, int b, int c)
        {
            double x1 = (-b + Math.Sqrt(b*b - 4*a*c)) / 2*a;
            return x1;
        }

        // Formulas for solutions of quadratic equations (minus Ver.)
        public double QuadraticArgMinus(int a, int b, int c)
        {
            double x2 = (-b - Math.Sqrt(b*b - 4*a*c)) / 2*a;
            return x2;
        }

        // Outputting the solution
        public void Ans(double x1, double x2)
        {
            if (double.IsNaN(x1) == false)
            {
                if (double.IsNaN(x2) == false)
                {
                    Console.Write("There are two solutions for x.\r\n");
                    Console.Write("x1 = {0}\r\n", x1);
                    Console.Write("x2 = {0}\r\n\r\n", x2);
                }
            }
            else
            {
                Console.Write("It cannot be obtained because the solution is imaginary.\r\n\r\n");
            }
        }

        // Solution to Question 1
        public void QuadraticNumber1()
        {
            Console.Write("Find the solution to the quadratic equation a*x*x + b*x + c = 0\r\n");
            Console.Write("Enter the values for a, b, and c in order.\r\n");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a, b, c);
            double x2 = this.QuadraticArgMinus(a, b, c);

            this.Ans(x1, x2);
        }

        // Solution to Question 2
        public void QuadraticNumber2()
        {
            Console.Write("Find the solution to the quadratic equation a*(x-p)*(x-p) + q = 0\r\n");
            Console.Write("Enter the values for a, p, and q in order.\r\n");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a, -2*a*p, a*p*p + q);
            double x2 = this.QuadraticArgMinus(a, -2*a*p, a*p*p + q);

            this.Ans(x1, x2);
        }

        // Solution to Question 3
        public void QuadraticNumber3()
        {
            Console.Write("Find the solution to the quadratic equation (a*x + b)*(c*x + d) = 0\r\n");
            Console.Write("Enter the values for a, b, c, and d in order.\r\n");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a*c, a*d + b*c, b*d);
            double x2 = this.QuadraticArgMinus(a*c, a*d + b*c, b*d);

            this.Ans(x1, x2);
        }
    }
}