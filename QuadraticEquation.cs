using System;

namespace Quadratic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            QuadraticFunc func = new QuadraticFunc();

            //問1を求める
            func.Quadratic_No1();

            //問2を求める
            func.Quadratic_No2();

            //問3を求める
            func.Quadratic_No3();
        }
    }

    class QuadraticFunc
    {
        //2次方程式の解の公式(プラスVer.)
        public double QuadraticArgPlus(int a, int b, int c)
        {
            double x1 = (-b + Math.Sqrt(b*b - 4*a*c)) / 2*a;
            return x1;
        }

        //2次方程式の解の公式(マイナスVer.)
        public double QuadraticArgMinus(int a, int b, int c)
        {
            double x2 = (-b - Math.Sqrt(b*b - 4*a*c)) / 2*a;
            return x2;
        }

        //解の出力
        public void Ans(double x1, double x2)
        {
            if (double.IsNaN(x1) == false)
            {
                if (double.IsNaN(x2) == false)
                {
                    Console.Write("xの解は以下の2つです。\r\n");
                    Console.Write("x1 = {0}\r\n", x1);
                    Console.Write("x2 = {0}\r\n\r\n", x2);
                }
            }
            else
            {
                Console.Write("解が虚数になるため求められません。\r\n\r\n");
            }
        }

        //問1の解法
        public void Quadratic_No1()
        {
            Console.Write("2次方程式 a*x*x + b*x + c = 0 における解を求めます。\r\n");
            Console.Write("a, b, cの値を順に入力して下さい。\r\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a, b, c);
            double x2 = this.QuadraticArgMinus(a, b, c);

            this.Ans(x1, x2);
        }

        //問2の解法
        public void Quadratic_No2()
        {
            Console.Write("2次方程式 a*(x - p)*(x - p) + q = 0 における解を求めます。\r\n");
            Console.Write("a, p, qの値を順に入力して下さい。\r\n");

            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a, -2*a*p, a*p*p + q);
            double x2 = this.QuadraticArgMinus(a, -2*a*p, a*p*p + q);

            this.Ans(x1, x2);
        }

        //問3の解法
        public void Quadratic_No3()
        {
            Console.Write("2次方程式 (a*x + b)*(c*x + d)= 0 における解を求めます。\r\n");
            Console.Write("a, b, c, dの値を順に入力して下さい。\r\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            double x1 = this.QuadraticArgPlus(a*c, a*d + b*c, b*d);
            double x2 = this.QuadraticArgMinus(a*c, a*d + b*c, b*d);

            this.Ans(x1, x2);
        }
    }
}
