using System;

namespace MethodApp
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Method structure
			//int num = -30;

			//if (isPositive(num))
			//{
			//	Console.WriteLine(num + " is positive number");
			//}
			//else
			//{
			//	Console.WriteLine($"{num} is negative number");
			//}

			//int[] arr = { 1, 5, -75, 30, -9, -83, 42 };

			//int positiveCounter = 0;
			//int negativeCounter = 0;


			//foreach (int item in arr)
			//{
			//	if (isPositive(item))
			//	{
			//		positiveCounter++;
			//	}
			//	else
			//	{
			//		negativeCounter++;
			//	}
			//}
			//Console.WriteLine(negativeCounter);
			//Console.WriteLine(positiveCounter);

			//Program pro = new Program();

			//isPositive(-70);

			//int result = Calc(5, 15);

			//Console.WriteLine(result);
			//VoidTest();
			//Test(10, 7);
			//Console.WriteLine(Calc(num2: 5, num1: 15));
			#endregion

			#region Method overloading
			//Console.WriteLine(Sum());
			//Console.WriteLine(Sum(50, 30));
			//Console.WriteLine(Sum("Hello", "World"));
			#endregion

			int input = 37;

			int result = input;

			if(input % 7 == 0)
			{
				Console.WriteLine($"{input} 7-ye bolunur");
			}
			else
			{
				int remainder = input % 7;

				if(remainder > 3)
				{
					while (result % 7 !=0)
					{
						result++;
					}
				}
				else
				{
					while (result % 7 !=0)
					{
						result--;
					}
				}
				Console.WriteLine(result);
				

			}


		}

		public static bool isPositive(int num)
		{
			if (num >= 0)
			{
				return true;

			}
			else
			{
				return false;
			}
		}

		public static int Calc(int num1,int num2)
		{
			return num1-num2;
		}

		public static void VoidTest()
		{
			Console.WriteLine("its void method");
		}

		public static void Test(int num1,int num2)
		{
			Console.WriteLine(num1 * num2);
		}

		#region Method Overloading
		public static int Sum()
		{
			return 5 + 10;
		}
		public static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}


		// Bu formatda  yazila bilmez. Cunki methodlarin return type - lari onlarin imzasi sayilmir

		//public static string Sum(int num1, int num2)
		//{
		//	return (num1 + num2).ToString();
		//}

		public static string Sum(string str1, string str2)
		{
			return str1 + " " + str2;
		}
		#endregion
	}
}
