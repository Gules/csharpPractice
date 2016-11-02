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
			Console.Clear ();
			Console.WriteLine ("5 squared is {0}", Sqr (5));
			Console.WriteLine (Vol (2, 4));
			Console.WriteLine(Area(l:5,w:8));
			Console.Clear ();
			int a2;
			int z = Test (out a2);
			Console.WriteLine (a2 + z);
			Console.Clear ();
			Person p1 = new Person (yourName);
			Console.WriteLine (p1.getName ());
			p1.SayHi ();
			Dog bob = new Dog ();
			bob.name = "Bobby";
			bob.age = 3;
			Console.WriteLine (bob.age);
			//arrays
			int[] array = new int[5];
			array [0] = 10;
			Console.WriteLine (array [0]);
			string[] names = { "john", "Mary", "Phil" };
			Console.WriteLine(names[1]);




		}
		class Person
		{
			private int age;
			private string name;
			public void SayHi()
			{
				Console.WriteLine ("Hi");
			}
			public Person(string nm)
			{
				Console.WriteLine("Created Person");
				name =nm;
			}
			public string getName()
			{
				return name;
			}
		}
		class Dog
		{
			public string name;
			public int age;
		}

		//square the number 
		static int Sqr(int x)
		{
			int result = x * x;
			return result;
		}
		static int Test(out int x5,int y5=4)
		{
			x5 = 6;
			return x5 * y5;
		}
		static int Vol(int x,int y=3,int z=1)
		{
			return x * y * z;
		}
		static int Area(int w, int l)
		{
			return l * w;
		}

	}
}
