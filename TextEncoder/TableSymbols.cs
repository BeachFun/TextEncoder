using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncoder
{
	public class TableSymbols
	{
		public enum Symbols
		{
			// Русский алфавит
			/* А = 1,  Б = 2,  В = 3,  Г = 4,  Д = 5,  Е = 6,
			   Ё = 7,  Ж = 8,  З = 9,  И = 10, Й = 11, К = 12,
			   Л = 13, М = 14, Н = 15, О = 16, П = 17, Р = 18,
			   С = 19, Т = 20, У = 21, Ф = 22, Х = 23, Ц = 24,
			   Ч = 25, Ш = 26, Щ = 27, Ъ = 28, Ы = 29, Ь = 30,
			   Э = 31, Ю = 32, Я = 33 */

			// Английский алфавит
			/* A = 1,  B = 2,  C = 3,  D = 4,  E = 5,  F = 6,
			   G = 7,  H = 8,  I = 9,  J = 10, K = 11, L = 12,
			   M = 13, N = 14, O = 15, P = 16, Q = 17, R = 18,
			   S = 19, T = 20, U = 21, V = 22, W = 23, X = 24,
			   Y = 25, Z = 26 */



			А = 'А', Б = 'Б', В = 'В', Г = 'Г', Д = 'Д', Е = 'Е',
			Ё = 'Ё', Ж = 'Ж', З = 'З', И = 'И', Й = 'Й', К = 'К',
			Л = 'Л', М = 'М', Н = 'Н', О = 'О', П = 'П', Р = 'Р',
			С = 'С', Т = 'Т', У = 'У', Ф = 'Ф', Х = 'Х', Ц = 'Ц',
			Ч = 'Ч', Ш = 'Ш', Щ = 'Щ', Ъ = 'Ъ', Ы = 'Ы', Ь = 'Ь',
			Э = 'Э', Ю = 'Ю', Я = 'Я',

			а = 'а', б = 'б', в = 'в', г = 'г', д = 'д', е = 'е',
			ё = 'ё', ж = 'ж', з = 'з', и = 'и', й = 'й', к = 'к',
			л = 'л', м = 'м', н = 'н', о = 'о', п = 'п', р = 'р',
			с = 'с', т = 'т', у = 'у', ф = 'ф', х = 'х', ц = 'ц',
			ч = 'ч', ш = 'ш', щ = 'щ', ъ = 'ъ', ы = 'ы', ь = 'ь',
			э = 'э', ю = 'ю', я = 'я',

			A = 'A', B = 'B', C = 'C', D = 'D', E = 'E', F = 'F',
			G = 'G', H = 'H', I = 'I', J = 'J', K = 'K', L = 'L',
			M = 'M', N = 'N', O = 'O', P = 'P', Q = 'Q', R = 'R',
			S = 'S', T = 'T', U = 'U', V = 'V', W = 'W', X = 'X',
			Y = 'Y', Z = 'Z',

			a = 'a', b = 'b', c = 'c', d = 'd', e = 'e', f = 'f',
			g = 'g', h = 'h', i = 'i', j = 'j', k = 'k', l = 'l',
			m = 'm', n = 'n', o = 'o', p = 'p', q = 'q', r = 'r',
			s = 's', t = 't', u = 'u', v = 'v', w = 'w', x = 'x',
			y = 'y', z = 'z',
		}

		/// <summary>
		/// Возвращает соответсвующее число из кодовой таблицы. Если такого символа нет, то результатом будет значение -1
		/// </summary>
		/// <param name="symbol"></param>
		/// <returns></returns>
		public static int GetNumber(char symbol)
		{
			// Символы русского алфавита верхнего регистра
			for (int k = 'А', number = 1; k <= 'Я'; k++, number++)
			{
				if ((char)k == symbol)
					return number;

				if (k == 'Е') number++;
			}

			// Символы русского алфавита нижнего регистра
			for (int k = 'а', number = 1; k <= 'я'; k++, number++)
			{
				if ((char)k == symbol)
					return number;

				if (k == 'е') number++;
			}

			// Символы английского алфавита верхнего регистра
			for (int k = 'A', number = 1; k <= 'Z'; k++, number++)
			{
				if ((char)k == symbol)
				{
					return number;
				}
			}

			// Символы английского алфавита верхнего регистра
			for (int k = 'a', number = 1; k <= 'z'; k++, number++)
			{
				if ((char)k == symbol)
				{
					return number;
				}
			}



			// [Exception] Так как в кодовой таблице в промежутке от 'А' до 'Я' нет 'Ё' то происходит проверка
			if (symbol == 'Ё') return 7;

			// [Exception] Так как в кодовой таблице в промежутке от 'а' до 'я' нет 'ё' то происходит проверка
			if (symbol == 'ё') return 7;



			return -1;
		}


		/// <summary>
		/// Возвращает соотвествующий символ из кодовой таблицы чисел.
		/// </summary>
		/// <param name="symbol"></param>
		/// <returns></returns>
		public static char GetSymbol(char symbol)
        {

			// 
			for (int k = '0', symb = 'a'; k <= '9'; k++, symb++)
			{
				if ((char)k == symbol)
				{
					return (char)symb;
				}
			}

			return 
		}
	}
}



//switch (symbol)
//{
//    case (char)Symbols.А:
//    case (char)Symbols.а:
//        return 1;
//    case (char)Symbols.Б:
//    case (char)Symbols.б:
//        return 2;
//    case (char)Symbols.В:
//    case (char)Symbols.в:
//        return 3;
//    case (char)Symbols.Г:
//    case (char)Symbols.г:
//        return 4;
//    case (char)Symbols.Д:
//    case (char)Symbols.д:
//        return 5;
//    case (char)Symbols.Е:
//    case (char)Symbols.е:
//        return 6; //
//    case (char)Symbols.Ё:
//    case (char)Symbols.ё:
//        return 1;
//    case (char)Symbols.Ж:
//    case (char)Symbols.ж:
//        return 1;
//    case (char)Symbols.З:
//    case (char)Symbols.з:
//        return 1;
//    case (char)Symbols.И:
//    case (char)Symbols.и:
//        return 1;
//    case (char)Symbols.Й:
//    case (char)Symbols.й:
//        return 1;
//    case (char)Symbols.К:
//    case (char)Symbols.к:
//        return 1;
//    case (char)Symbols.Л:
//    case (char)Symbols.л:
//        return 1;
//    case (char)Symbols.М:
//    case (char)Symbols.м:
//        return 1;
//    case (char)Symbols.Н:
//    case (char)Symbols.н:
//        return 1;
//    case (char)Symbols.О:
//    case (char)Symbols.о:
//        return 1;
//    case (char)Symbols.П:
//    case (char)Symbols.п:
//        return 1;
//    case (char)Symbols.Р:
//    case (char)Symbols.р:
//        return 1;
//    case (char)Symbols.С:
//    case (char)Symbols.с:
//        return 1;
//    case (char)Symbols.Т:
//    case (char)Symbols.т:
//        return 1;
//    case (char)Symbols.У:
//    case (char)Symbols.у:
//        return 1;
//    case (char)Symbols.Ф:
//    case (char)Symbols.ф:
//        return 1;
//    case (char)Symbols.Х:
//    case (char)Symbols.х:
//        return 1;
//    case (char)Symbols.Ц:
//    case (char)Symbols.ц:
//        return 1;
//    case (char)Symbols.Ч:
//    case (char)Symbols.ч:
//        return 1;
//    case (char)Symbols.Ш:
//    case (char)Symbols.ш:
//        return 1;
//    case (char)Symbols.Щ:
//    case (char)Symbols.щ:
//        return 1;
//    case (char)Symbols.Ъ:
//    case (char)Symbols.ъ:
//        return 1;
//    case (char)Symbols.Ы:
//    case (char)Symbols.ы:
//        return 1;
//    case (char)Symbols.Ь:
//    case (char)Symbols.ь:
//        return 1;
//    case (char)Symbols.Э:
//    case (char)Symbols.э:
//        return 1;
//    case (char)Symbols.Ю:
//    case (char)Symbols.ю:
//        return 1;
//    case (char)Symbols.Я:
//    case (char)Symbols.я:
//        return 1;
//}

