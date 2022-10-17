using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exce_Declareint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算1+(2+2)*3-1
			Console.WriteLine("計算1+(2+2)*3-1");

			int number1 = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine(number1);
			Console.WriteLine();

			//求120/7的商及餘數是多少
			Console.WriteLine("求120/7的商及餘數是多少");

			int number2 = 120;
			int Quotient = number2 / 7;
			int Mod = number2 % 7;
			Console.WriteLine("商:" + Quotient.ToString() + "\t" + "餘數" + Mod.ToString());
			Console.WriteLine();

			//判斷9,202特別是基數還是偶數
			Console.WriteLine("判斷9,202特別是基數還是偶數");

			int number3 = 9;
			int number4 = 202;

			if (number3 % 2 == 0)
			{
				Console.WriteLine(number3.ToString() + "是偶數");
			}
			else
			{
				Console.WriteLine(number3.ToString() + "是奇數");
			}

			if (number4 % 2 == 0)
			{
				Console.WriteLine(number4.ToString() + "是偶數");
			}
			else
			{
				Console.WriteLine(number4.ToString() + "是奇數");
			}
			Console.WriteLine();

			//根據兩變數大小,是需要對調兩個變數的值  
			Console.WriteLine("根據兩變數大小,是需要對調兩個變數的值");
			Console.WriteLine("輸入兩個數");
			string input1 = Console.ReadLine();
			string input2 = Console.ReadLine();

			int number5 = Convert.ToInt32(input1);
			int number6 = Convert.ToInt32(input2);
			if (number5 < number6)
			{
				Console.WriteLine(number5.ToString() + "," + number6.ToString());
			}
			else
			{
				Console.WriteLine(number6.ToString() + "," + number5.ToString());
			}


			Console.ReadKey();
		}
	}
}


