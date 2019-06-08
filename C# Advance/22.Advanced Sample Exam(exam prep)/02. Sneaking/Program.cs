using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var room = new char[n][];

            var samRow = -1;
            var samCol = -1;
            
            for (int i = 0; i < n; i++)
            {
                room[i] = Console.ReadLine()
                    .ToCharArray();

                if (room[i].Contains('S'))
                {
                    var index = Array.IndexOf(room[i], 'S');
                    samRow = i;
                    samCol = index;
                    room[samRow][samCol] = '.';
                }
            }

            var commands = Console.ReadLine()
                .ToCharArray();

            foreach (var command in commands)
            {
                MoveEnemies(room);

                if ((room[samRow].Contains('b') && Array.IndexOf(room[samRow], 'b') < samCol) ||
                    (room[samRow].Contains('d') && Array.IndexOf(room[samRow], 'd') > samCol))
                {
                    room[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }

                switch (command)
                {
                    case 'U':
                        samRow--;
                        break;

                    case 'D':
                        samRow++;
                        break;

                    case 'L':
                        samCol--;
                        break;

                    case 'R':
                        samCol++;
                        break;

                    default:
                        break;
                }

                if (room[samRow][samCol] == 'b' ||
                    room[samRow][samCol] == 'd')
                {
                    room[samRow][samCol] = '.';
                }

                if (room[samRow].Contains('N'))
                {
                    var nikoladzeCol = Array.IndexOf(room[samRow], 'N');
                    room[samRow][nikoladzeCol] = 'X';
                    room[samRow][samCol] = 'S';
                    Console.WriteLine($"Nikoladze killed!");
                    break;
                }
            }

            foreach (var row in room)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void MoveEnemies(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                var rowLength = room[i].Length;

                if (room[i].Contains('b') &&
                    Array.IndexOf(room[i], 'b') < rowLength - 1)
                {
                    var index = Array.IndexOf(room[i], 'b');
                    room[i][index] = '.';
                    room[i][index + 1] = 'b';
                }

                else if (room[i].Contains('b') &&
                    Array.IndexOf(room[i], 'b') == rowLength - 1)
                {
                    room[i][rowLength - 1] = 'd';
                }
                
                else if (room[i].Contains('d') &&
                    Array.IndexOf(room[i], 'd') > 0)
                {
                    var index = Array.IndexOf(room[i], 'd');
                    room[i][index] = '.';
                    room[i][index - 1] = 'd';
                }

                else if (room[i].Contains('d') &&
                    Array.IndexOf(room[i], 'd') == 0)
                {
                    room[i][0] = 'b';
                }
            }
        }
    }
}