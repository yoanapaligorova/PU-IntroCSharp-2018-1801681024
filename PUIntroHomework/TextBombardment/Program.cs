using System;
using System.Linq;

namespace TextBombardment
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter the sentence you want to bombed");
				string sentence = Console.ReadLine();
				int length = sentence.Length;
				int width = int.Parse(Console.ReadLine());
				int height = (length / width);
				height += sentence.Length % width == 0 ? 0 : 1;

				string bombs = Console.ReadLine();
				int[] bombCols = bombs.Split(' ').Select(int.Parse).ToArray();

				int[] nbombCols = bombCols.Distinct().ToArray();



				char[,] table = new char[height, width];

				int index = 0;
				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						table[i, j] = sentence[index++];

						if (index >= length)
						{
							break;
						}
					}
				}
				for (int i = 0; i < bombCols.Length; i++)
				{
					int bomb = int.Parse(bombCols[i].ToString());
					for (int b = 0; b < height; b++)
					{
						int row = b;
						int col = bomb;
						if (table[b, bomb] == ' ')
						{
							continue;
						}

						table[b, bomb] = ' ';

						if (b + 1 < height)
						{
							if (table[b + 1, bomb] == ' ')
							{
								break;
							}
						}
					}
				}


				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						char letter = table[i, j];
						if (letter != '\0')
						{
							Console.Write(table[i, j]);
						}
					}
				}
				Console.WriteLine();
			}


			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
	}
}
