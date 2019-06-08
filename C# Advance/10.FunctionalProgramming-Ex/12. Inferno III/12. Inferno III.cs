using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Inferno_III
{
    class Program
    {
        static void Main()
        {
            Func<string, int, List<int>, int> func = (criterion, index, nums) => criterion == "Sum Left" ?
                                       index > 0 ? nums[index - 1] + nums[index] : 0 + nums[index]
                                       : criterion == "Sum Right" ?
                                       index > nums.Count - 2 ? 0 + nums[index] : nums[index + 1] + nums[index]
                                       : index > 0 && index <= nums.Count - 2 ? nums[index - 1] + nums[index] + nums[index + 1]
                                       : index > 0 && index > nums.Count - 2 ? 0 + nums[index] + nums[index - 1]
                                       : index == 0 && index <= nums.Count - 2 ? 0 + nums[index] + nums[index + 1] : nums[index];

            List<int> gems = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> commands = new List<string>();

            string[] command = Console.ReadLine()
                .Split(';');

            while (command[0] != "Forge")
            {
                switch (command[0])
                {
                    case "Exclude":
                        commands.Add($"{command[1]};{command[2]}");
                        break;

                    case "Reverse":
                        commands.Remove($"{command[1]};{command[2]}");
                        break;
                }

                command = Console.ReadLine()
                    .Split(';');
            }

            for (int j = commands.Count - 1; j >= 0; j--)
            {
                string sides = commands[j]
                    .Split(';')
                    .First();
                int compareTo = int.Parse(commands[j]
                    .Split(';')
                    .Last());

                for (int i = gems.Count - 1; i >= 0; i--)
                {
                    int sum = func(sides, i, gems);

                    if (sum == compareTo)
                    {
                        gems.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", gems));
        }
    }
}