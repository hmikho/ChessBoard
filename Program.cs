using System;
using static System.Net.Mime.MediaTypeNames;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Hur stort ska schackbrädet vara? Skriv in en siffra: ");

            string text = Console.ReadLine();
            int number = Int32.Parse(text);

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("■ ");
                    }
                    else
                    {
                        Console.Write("□ ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
