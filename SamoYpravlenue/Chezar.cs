using System;
using System.Text;

namespace SamoYpravlenue
{
	internal class Chezar
	{
		public string GetChezar()// a - 97 | z -122
		{
			string link = "go to - jiraffy.ru";
			//string link = "АБВГД";
			string sntext = ChezarWork(link);
			ChezarBack(sntext);
			return link;
		}

		private void ChezarBack(string sntext)
		{
			StringBuilder sb = new StringBuilder();
			StringBuilder sb2 = new StringBuilder();
			sb2 = sb;
			sb.AppendLine(sntext);
			for (int j = 1; j < 27; j++)
			{
				for (int i = 0; i < sntext.Length; i++)
				{
					char q = sb[i];
					int b = (int)q - j;
					if (q != (char)32 && q != (char)46 && q != (char)45)
					{
						if (b < 97)
						{
							b = 122 + b - 97;
						}							
						q = (char)b;
						sb2[i] = q;
					}
				}
				Console.WriteLine(j + " " + sb2.ToString());
			}

		}

		private string ChezarWork(string text)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(text);
			Random random = new Random();
			var a = random.Next(1, 27);
			//var a = 1;
			for (int i = 0; i < text.Length; i++)
			{
				//char c = (char)a;
				char q = stringBuilder[i];
				//Console.WriteLine((int)q);
				if (q != (char)32 && q != (char)46 && q != (char)45)
				{
					int b = (q + a);
					if (b > 122)
					{
						b = b % 122;
						b += 97;
					}

					q = (char)b;
					stringBuilder[i] = q;
					b = 0;
				}

			}
			Console.WriteLine($"rand number - {a}");
			Console.WriteLine(stringBuilder.ToString());
			return stringBuilder.ToString();
		}
	}
}
