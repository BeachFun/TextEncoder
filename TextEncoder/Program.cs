using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncoder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "TextEncoder";			
			while (true)
			{
				Console.Clear();

				Console.CursorTop = 1;
				Console.Write("  Введите текст --> ");
				string text = Console.ReadLine();

                text = TextEditing(text);

                text = TextProcessing(text);

				Console.WriteLine("  Результат --> " + text);
				Console.WriteLine("\n  Нажмите \'Enter\', чтобы продолжить или введите \"Exit\", чтобы выйти из приложения...");

				string exit = Console.ReadLine();

				if (exit == "Exit") break;
			}
		}


		/// <summary>
		/// Первичная обработка текста
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		static string TextEditing(string text)
		{
			text = text.Trim();
			return text;
		}


		/// <summary>
		/// Преобразует текст. Заменяет знакомые символы на числа
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		static string TextProcessing(string text)
		{
			string readyText = "";

			foreach(char symbol in text)
			{
				int number = TableSymbols.GetNumber(symbol);

				if(number == -1)
                {
					readyText += symbol;
				}
                else
                {
					readyText += number.ToString();
                }
			}

			return readyText;
		}
	}
}
