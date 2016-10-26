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
			for (int x3 = 1; x3 < 8; x3++)
			{
				if (x3 > 5)
					break;
				Console.WriteLine(x3);
			}
		}
	}
}
