using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    public class Camera_View
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().ToList();

            var camera = Console.ReadLine();

            var pattern = @"\|<[^|<]{" + nums[0] + @"}(?<view>[^|<]{0," + nums[1] + @"})";

            var views = Regex.Matches(camera, pattern).Cast<Match>().Select(x => x.Groups["view"].Value).ToList();
            
            Console.WriteLine(string.Join(", ", views));
        }
    }
}
