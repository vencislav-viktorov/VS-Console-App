using System.IO;
using System.Linq;

namespace _4._Merge_Files
{
    class Program
    {
        static void Main()
        {
            var input1 = File.ReadAllLines(@"../../../Resources/FileOne.txt");

            var input2 = File.ReadAllLines(@"../../../Resources/FileTwo.txt");

            File.WriteAllText("output.txt", "");

            var result = input1.Concat(input2).OrderBy(x => x).ToArray();

            foreach (var item in result)
            {
                File.AppendAllText("output.txt", item + "\r\n");
            }
        }
    }
}
