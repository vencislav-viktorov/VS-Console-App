using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main()
        {
            Func<IEnumerable<int>, IEnumerable<int>> sort = x => x.Where(e => e % 2 == 0)
                                                                  .OrderBy(e => e)
                                                                  .Concat(x.Where(o => o % 2 != 0)
                                                                           .OrderBy(o => o));

            Console.WriteLine(string.Join(" ", sort(Console.ReadLine()
                                                    .Split()
                                                    .Select(int.Parse))));
        }
    }
}