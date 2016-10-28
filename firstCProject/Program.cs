using System;

namespace firstCProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string yourName;
			Console.WriteLine ("What is your name?");
			yourName = Console.ReadLine ();
			Console.WriteLine ("What is your age?");
			int age = Convert.ToInt32 ((Console.ReadLine ()));
			Console.WriteLine ("Hello {0}", yourName);
			Console.WriteLine ("You are {0} years old", age);
			int x = 16;
			int y = 5;
			Console.WriteLine (x / y);
			Console.WriteLine ("Hello World!");
			// ++x; Prefix increments value then proceds
			//x++; postfix evluates esxpression then increments
			int a =15;
			int b=6;
			a%=b;
			Console.WriteLine(a);
			int x2 = 1;
			int count = 0;
			while (x2++<5)
			{
				count += 1;
				if (x2 % 2==0)
					x2+=2;
			}
			Console.WriteLine ("while loop answer: {0}",count);
			Console.Clear ();
			//print only even number
			for (int c =0; c<99; c++) 
			{
				if (c % 2 != 0)
					continue;
				Console.WriteLine (c);
			}
			Console.Clear ();
			int x3 = 5;int y3 = 12;
			if (x > 10 || y / x > 1)
				Console.Write (y3 - x3);
			else
				Console.Write (y3);
			Console.Clear ();
			//the ?: operator
			int age2 = 42;
			string msg;
			msg = (age2 >= 18) ? "Welcome" : "Sorry";
			Console.WriteLine (msg);
			Console.Clear ();
			int x4 = 4;int y4 = 9;
			x4 = (y4 % x4 != 0) ? y4 / x4 : y4;
			Console.WriteLine (x4);
		}
	}
}
