using System;

namespace Quadratic
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			QuadraticFunc func = new QuadraticFunc();

			Console.Write("2次方程式 a*x*x + b*x + c = 0 における解を求めます。");
			Console.WriteLine();
			Console.Write("※虚数解の場合は、NaN(Not a Number)が表示されます。");
			Console.WriteLine();

			Console.Write("a = ");
			var a1 = int.Parse(Console.ReadLine());
			Console.Write("b = ");
			var b1 = int.Parse(Console.ReadLine());
			Console.Write("c = ");
			var c1 = int.Parse(Console.ReadLine());

			var x1ans1 = func.QuadraticArgPlus(a1, b1, c1);
			var x2ans1 = func.QuadraticArgMinus(a1, b1, c1);

			Console.Write("xの解は以下の2つです。");
			Console.WriteLine();
			Console.Write("x1 = {0}", x1ans1);
			Console.WriteLine();
			Console.Write("x2 = {0}", x2ans1);
			Console.WriteLine();

			Console.Write("2次方程式 a*(x - p)*(x - p) + q = 0 における解を求めます。");
			Console.WriteLine();
			Console.Write("※虚数解の場合は、NaN(Not a Number)が表示されます。");
			Console.WriteLine();

			Console.Write("a = ");
			var aPre2 = int.Parse(Console.ReadLine());
			Console.Write("p = ");
			var pPre2 = int.Parse(Console.ReadLine());
			Console.Write("q = ");
			var qPre2 = int.Parse(Console.ReadLine());

			var a2 = aPre2;
			var b2 = -2*aPre2*pPre2;
			var c2 = aPre2*pPre2*pPre2 + qPre2;

			var x1ans2 = func.QuadraticArgPlus(a2, b2, c2);
			var x2ans2 = func.QuadraticArgMinus(a2, b2, c2);

			Console.Write("xの解は以下の2つです。");
			Console.WriteLine();
			Console.Write("x1 = {0}", x1ans2);
			Console.WriteLine();
			Console.Write("x2 = {0}", x2ans2);
			Console.WriteLine();

			Console.Write("2次方程式 (a*x + b)*(c*x + d)= 0 における解を求めます。");
			Console.WriteLine();
			Console.Write("※虚数解の場合は、NaN(Not a Number)が表示されます。");
			Console.WriteLine();

			Console.Write("a = ");
			var aPre3 = int.Parse(Console.ReadLine());
			Console.Write("b = ");
			var bPre3 = int.Parse(Console.ReadLine());
			Console.Write("c = ");
			var cPre3 = int.Parse(Console.ReadLine());
			Console.Write("d = ");
			var dPre3 = int.Parse(Console.ReadLine());

			var a3 = aPre3*cPre3;
			var b3 = bPre3*cPre3;
			var c3 = aPre3*dPre3 + bPre3*dPre3;

			var x1ans3 = func.QuadraticArgPlus(a3, b3, c3);
			var x2ans3 = func.QuadraticArgMinus(a3, b3, c3);

			Console.Write("xの解は以下の2つです。");
			Console.WriteLine();
			Console.Write("x1 = {0}", x1ans3);
			Console.WriteLine();
			Console.Write("x2 = {0}", x2ans3);
			Console.WriteLine();
		}
	}

	class QuadraticFunc
	{
		public double QuadraticArgPlus(int a, int b, int c)
		{
			double x1 = (-b + Math.Sqrt(b*b - 4*a*c)) / 2*a;
			return x1;
		}

		public double QuadraticArgMinus(int a, int b, int c)
		{
			double x2 = (-b - Math.Sqrt(b*b - 4*a*c)) / 2*a;			
			return x2;
		}
	}

}