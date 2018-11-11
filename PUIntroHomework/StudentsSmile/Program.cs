using System;
using System.IO;
using System.Text;

namespace studentsmiles
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			int sum = 0;
			int smile = '\u263a';

			string[] lines = File.ReadAllLines(@"C:\Users\Ioana\Desktop\homewor4k\PU-IntroCSharp-2018-1801681024\PUIntroHomework\StudentsSmile\files\students.txt");

			Console.WriteLine("Contents of student.txt = ");
			foreach (string line in lines)
			{
				string[] students = line.Split(' ');
				string firstName = students[1];
				string secondName = students[2];
				string lastName = students[3];
				string fullName = $"{firstName} {secondName} {lastName}";

				for (int i = 0; i < fullName.Length; i++)
				{
					sum = sum + (int)fullName[i];
				}
				if (sum > 15000)
					Console.WriteLine($" {fullName} {(char)smile} => {sum}");
			}
		}
	}
}
