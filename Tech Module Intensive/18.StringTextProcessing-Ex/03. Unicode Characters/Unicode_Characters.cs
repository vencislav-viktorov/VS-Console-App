using System;

namespace _03.Unicode_Characters
{
    public class Unicode_Characters
    {
        public static void Main()
        {
            char[] chars = Console.ReadLine().ToCharArray();

            foreach (char chara in chars)
            {
                Console.Write("\\u{0:x4}", Convert.ToUInt16(chara));
            }
        }
    }
}
