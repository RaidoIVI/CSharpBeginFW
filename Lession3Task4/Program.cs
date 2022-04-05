using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession3Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int BoardSize = 10;
            int[,] Board = new int[BoardSize + 2, BoardSize + 2];
            for (int i = 0; i < BoardSize + 2; i++)
            {
                for (int j = 0; j < BoardSize + 2; j++)
                {
                    if (i == 0 || i == BoardSize + 1 || j == 0 || j == BoardSize + 1)
                    {
                        Board[i, j] = 2;
                    }
                }
            }
            var Rnd = new Random();
            int CoordinatesX = Rnd.Next(BoardSize + 1) + 1;
            int CoordinatesY = Rnd.Next(BoardSize + 1) + 1;
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 4, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 3, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 3, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 2, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 2, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 2, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 1, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 1, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 1, Rnd.Next(11) % 2 == 0));
            do { } while (!Ships.ShipCreate(Board, Rnd.Next(BoardSize + 1), Rnd.Next(BoardSize + 1), 1, Rnd.Next(11) % 2 == 0));

            for (int i = 1; i < BoardSize + 1; i++)
            {
                for (int j = 1; j < BoardSize + 1; j++)
                {
                    if (Board[i, j] == 1) 
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                    else { Console.Write("  "); };
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        class Ships
        {
            internal static bool ShipCreate (int [,] board ,int valueX , int valueY , int size , bool horizontal) 
            {
                //bool tmp = false;
                
                if ( horizontal ) 
                {
                    for (int i = 0; i < size ; i++) 
                    {
                        if ( board [valueX  + i ,valueY] != 0) { return false; }
                    }
                }
                else 
                {
                    for (int i = 0; i < size; i++)
                    {
                        if ( board [valueX ,valueY + i] != 0) { return false; }
                    }
                }
                if (horizontal)
                {
                    board [valueX - 1, valueY - 1] = 2; board[valueX + size, valueY - 1] = 2;
                    board [valueX - 1, valueY    ] = 2; board[valueX + size, valueY    ] = 2;
                    board [valueX - 1, valueY + 1] = 2; board[valueX + size, valueY + 1] = 2;

                    for (int i = 0; i < size; i++)
                    {
                        board[valueX + i, valueY    ] = 1;
                        board[valueX + i, valueY + 1] = 2;
                        board[valueX + i, valueY - 1] = 2;

                    }
                }
                else
                {
                    board[valueX - 1, valueY - 1] = 2; board[valueX - 1, valueY + size] = 2;
                    board[valueX    , valueY - 1] = 2; board[valueX    , valueY + size] = 2;
                    board[valueX + 1, valueY - 1] = 2; board[valueX + 1, valueY + size] = 2;

                    for (int i = 0; i < size; i++)
                    {
                        board[valueX    , valueY + i] = 1;
                        board[valueX + 1, valueY + i] = 2;
                        board[valueX - 1, valueY + i] = 2;
                    }
                }
                return true;
            }
        }
    }
}
