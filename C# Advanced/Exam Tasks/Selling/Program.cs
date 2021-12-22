using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            char[,] bakery = new char[size, size];
            var myRow = 0;
            var myCol = 0;
            var countOfPilars = 0;
            var firstPilarRow = 0;
            var secondPilarRow = 0;
            var firstPilarCol = 0;
            var secondPilarCol = 0;
            var price = 0;
            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine();
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    bakery[row, col] = currentRow[col];
                    if (currentRow[col] == 'S')
                    {
                        myRow = row;
                        myCol = col;
                    }
                    if (countOfPilars == 0 && currentRow[col] == 'O')
                    {
                        firstPilarRow = row;
                        firstPilarCol = col;
                        countOfPilars++;
                    }
                    else if (countOfPilars == 1 && currentRow[col] == 'O')
                    {
                        secondPilarRow = row;
                        secondPilarCol = col;
                    }
                }
            }

            while (price < 50)
            {
                var command = Console.ReadLine();
                if (command == "up")
                {
                    if (myRow == 0)
                    {
                        bakery[myRow, myCol] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {price}");
                        break;
                    }
                    if (bakery[myRow - 1, myCol] == 'O' && myRow - 1 == firstPilarRow)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = secondPilarRow;
                        myCol = secondPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[firstPilarRow, firstPilarCol] = '-';
                    }
                    else if (bakery[myRow - 1, myCol] == 'O' && myRow - 1 == secondPilarRow)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = firstPilarRow;
                        myCol = firstPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[secondPilarRow, secondPilarCol] = '-';
                    }
                    else if (bakery[myRow - 1, myCol] != 'O' && bakery[myRow - 1, myCol] != '-')
                    {
                        var clientPrice = (int)bakery[myRow - 1, myCol] - 48;
                        price += clientPrice;
                        bakery[myRow, myCol] = '-';
                        myRow -= 1;
                        bakery[myRow, myCol] = 'S';
                    }
                    else
                    {
                        bakery[myRow, myCol] = '-';
                        myRow -= 1;
                        bakery[myRow, myCol] = 'S';
                    }
                }
                else if (command == "down")
                {
                    if (myRow == bakery.GetLength(0) - 1)
                    {
                        bakery[myRow, myCol] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {price}");
                        break;
                    }
                    if (bakery[myRow + 1, myCol] == 'O' && myRow + 1 == firstPilarRow)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = secondPilarRow;
                        myCol = secondPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[firstPilarRow, firstPilarCol] = '-';
                    }
                    else if (bakery[myRow + 1, myCol] == 'O' && myRow + 1 == secondPilarRow)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = firstPilarRow;
                        myCol = firstPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[secondPilarRow, secondPilarCol] = '-';
                    }
                    else if (bakery[myRow + 1, myCol] != 'O' && bakery[myRow + 1, myCol] != '-')
                    {
                        var clientPrice = (int)bakery[myRow + 1, myCol] - 48;
                        price += clientPrice;
                        bakery[myRow, myCol] = '-';
                        myRow += 1;
                        bakery[myRow, myCol] = 'S';
                    }
                    else
                    {
                        bakery[myRow, myCol] = '-';
                        myRow += 1;
                        bakery[myRow, myCol] = 'S';
                    }
                }
                else if (command == "left")
                {
                    if (myCol == 0)
                    {
                        bakery[myRow, myCol] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {price}");
                        break;
                    }
                    if (bakery[myRow, myCol - 1] == 'O' && myCol - 1 == firstPilarCol)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = secondPilarRow;
                        myCol = secondPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[firstPilarRow, firstPilarCol] = '-';
                    }
                    else if (bakery[myRow, myCol - 1] == 'O' && myCol - 1 == secondPilarCol)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = firstPilarRow;
                        myCol = firstPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[secondPilarRow, secondPilarCol] = '-';
                    }
                    else if (bakery[myRow, myCol - 1] != 'O' && bakery[myRow, myCol - 1] != '-')
                    {
                        var clientPrice = (int)bakery[myRow, myCol - 1] - 48;
                        price += clientPrice;
                        bakery[myRow, myCol] = '-';
                        myCol -= 1;
                        bakery[myRow, myCol] = 'S';
                    }
                    else
                    {
                        bakery[myRow, myCol] = '-';
                        myCol -= 1;
                        bakery[myRow, myCol] = 'S';
                    }
                }
                else if (command == "right")
                {
                    if (myCol == bakery.GetLength(1) - 1)
                    {
                        bakery[myRow, myCol] = '-';
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {price}");
                        break;
                    }
                    if (bakery[myRow, myCol + 1] == 'O' && myCol + 1 == firstPilarCol)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = secondPilarRow;
                        myCol = secondPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[firstPilarRow, firstPilarCol] = '-';
                    }
                    else if (bakery[myRow, myCol + 1] == 'O' && myCol + 1 == secondPilarCol)
                    {
                        bakery[myRow, myCol] = '-';
                        myRow = firstPilarRow;
                        myCol = firstPilarCol;
                        bakery[myRow, myCol] = 'S';
                        bakery[secondPilarRow, secondPilarCol] = '-';
                    }
                    else if (bakery[myRow, myCol + 1] != 'O' && bakery[myRow, myCol + 1] != '-')
                    {
                        var clientPrice = (int)bakery[myRow, myCol + 1] - 48;
                        price += clientPrice;
                        bakery[myRow, myCol] = '-';
                        myCol += 1;
                        bakery[myRow, myCol] = 'S';
                    }
                    else
                    {
                        bakery[myRow, myCol] = '-';
                        myCol += 1;
                        bakery[myRow, myCol] = 'S';
                    }
                }
            }
            if (price >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
                Console.WriteLine($"Money: {price}");
            }
            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
